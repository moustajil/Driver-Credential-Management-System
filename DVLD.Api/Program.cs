using System.Data;
using DVLD_Business_Layer;
using DVLD_Business_Layer.ApplicationTestType;
using DVLD_Business_Layer.ApplicationType;
using DVLD_Business_Layer.LicenseClasses;
using DVLD_Business_Layer.LicensManage;
using DVLD_Business_Layer.Users;
using BNPeople = DVLD_Business_Layer.DVLD_Business_Layer.BNPeople;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowLocalClients", policy =>
        policy.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod());
});

var app = builder.Build();

app.UseHttpsRedirection();
app.UseCors("AllowLocalClients");

app.MapGet("/", () => Results.Ok(new
{
    name = "Driver Credential Management System API",
    status = "Running"
}));

var people = app.MapGroup("/api/people");

people.MapGet("/", () => Results.Ok(TableRows(BNPeople.GetAllPeople())));

people.MapGet("/{id:int}", (int id) =>
{
    BNPeople? person = BNPeople.Find(id);
    return person is null ? Results.NotFound() : Results.Ok(person);
});

people.MapGet("/search", (string column, string value) =>
    Results.Ok(TableRows(BNPeople.FindByCol(column, value))));

people.MapPost("/", (PersonRequest request) =>
{
    var person = new BNPeople(
        request.NationalID,
        request.FirstName,
        request.SecondName,
        request.ThirdName,
        request.LastName,
        request.DateOfBirth,
        request.Gender,
        request.Address,
        request.Phone,
        request.Email,
        request.NationalityCountryID,
        request.ImagePath ?? string.Empty);

    int personId = person.AddNewPerson();
    return personId > 0
        ? Results.Created($"/api/people/{personId}", new { personId })
        : Results.BadRequest(new { message = "Person was not created." });
});

people.MapPut("/{id:int}", (int id, PersonRequest request) =>
{
    BNPeople? person = BNPeople.Find(id);

    if (person is null)
        return Results.NotFound();

    person.NationalID = request.NationalID;
    person.FirstName = request.FirstName;
    person.SecondName = request.SecondName;
    person.ThirdName = request.ThirdName;
    person.LastName = request.LastName;
    person.DateOfBirth = request.DateOfBirth;
    person.Gender = request.Gender;
    person.Address = request.Address;
    person.Phone = request.Phone;
    person.Email = request.Email;
    person.NationalityCountryID = request.NationalityCountryID;
    person.ImagePath = request.ImagePath ?? string.Empty;

    return person.UpdatePerson() ? Results.NoContent() : Results.BadRequest();
});

people.MapDelete("/{id:int}", (int id) =>
    BNPeople.DeletePerson(id) ? Results.NoContent() : Results.NotFound());

var users = app.MapGroup("/api/users");

users.MapGet("/", () => Results.Ok(TableRows(BNUser.GetAllUsers())));

users.MapGet("/{id:int}", (int id) =>
{
    DataTable user = BNUser.FindUserByID(id);
    return user.Rows.Count == 0 ? Results.NotFound() : Results.Ok(TableRows(user));
});

users.MapGet("/by-person/{personId:int}", (int personId) =>
{
    DataTable user = BNUser.FindUserByPersonID(personId);
    return user.Rows.Count == 0 ? Results.NotFound() : Results.Ok(TableRows(user));
});

users.MapGet("/search", (string column, string value) =>
    Results.Ok(TableRows(BNUser.FindUserByColums(column, value))));

users.MapPost("/", (UserRequest request) =>
{
    int userId = BNUser.AddUser(
        request.PersonID,
        request.UserName,
        request.Password,
        request.IsActive);

    return userId > 0
        ? Results.Created($"/api/users/{userId}", new { userId })
        : Results.BadRequest(new { message = "User was not created." });
});

users.MapPut("/{id:int}", (int id, UserRequest request) =>
    BNUser.UpdateUser(
        id,
        request.PersonID,
        request.UserName,
        request.Password,
        request.IsActive)
        ? Results.NoContent()
        : Results.BadRequest());

users.MapPatch("/{id:int}/password", (int id, PasswordRequest request) =>
    BNUser.UpdatePassword(id, request.Password)
        ? Results.NoContent()
        : Results.BadRequest());

users.MapDelete("/{id:int}", (int id) =>
    BNUser.DeletUser(id) ? Results.NoContent() : Results.NotFound());

app.MapPost("/api/auth/login", (LoginRequest request) =>
    BNUser.checkIfUserExists(request.UserName, request.Password)
        ? Results.Ok(new { authenticated = true })
        : Results.Unauthorized());

var applicationTypes = app.MapGroup("/api/application-types");

applicationTypes.MapGet("/", () =>
    Results.Ok(TableRows(BNApplicationType.GetAllApplicationTypes())));

applicationTypes.MapGet("/{id:int}", (int id) =>
{
    DataTable applicationType = BNApplicationType.FindApplicatonTypeByID(id);
    return applicationType.Rows.Count == 0
        ? Results.NotFound()
        : Results.Ok(TableRows(applicationType));
});

applicationTypes.MapPut("/{id:int}", (int id, ApplicationTypeRequest request) =>
    BNApplicationType.UpdateApplicationType(id, request.Title, request.Fees)
        ? Results.NoContent()
        : Results.BadRequest());

var testTypes = app.MapGroup("/api/test-types");

testTypes.MapGet("/", () =>
    Results.Ok(TableRows(BNApplicationTestType.GetAllApplicationTestType())));

testTypes.MapGet("/{id:int}", (int id) =>
{
    DataTable testType = BNApplicationTestType.GetApplicationTestTypeByID(id);
    return testType.Rows.Count == 0
        ? Results.NotFound()
        : Results.Ok(TableRows(testType));
});

testTypes.MapPut("/{id:int}", (int id, TestTypeRequest request) =>
    BNApplicationTestType.UpdateTestType(
        id,
        request.Title,
        request.Description,
        request.Fees)
        ? Results.NoContent()
        : Results.BadRequest());

app.MapGet("/api/countries", () => Results.Ok(BnCountries.GetAllCountries()));

app.MapGet("/api/countries/{id:int}", (int id) =>
{
    string country = BnCountries.GetCountryNameByCountryID(id);
    return string.IsNullOrWhiteSpace(country)
        ? Results.NotFound()
        : Results.Ok(new { id, name = country });
});

app.MapGet("/api/license-classes", () =>
    Results.Ok(TableRows(BNLinceClasses.GetAllClasses())));

var localApplications = app.MapGroup("/api/local-driving-license-applications");

localApplications.MapGet("/", () =>
    Results.Ok(TableRows(DBALicenseManage.GetallApplicaiton())));

localApplications.MapPost("/", (LocalDrivingLicenseApplicationRequest request) =>
{
    int applicationId = DBALicenseManage.DBBInsertApplication(
        request.ClassName,
        request.NationalID,
        request.FullName,
        request.ApplicationDate);

    return applicationId > 0
        ? Results.Created(
            $"/api/local-driving-license-applications/{applicationId}",
            new { applicationId })
        : Results.BadRequest(new { message = "Application was not created." });
});

app.Run();

static IReadOnlyList<Dictionary<string, object?>> TableRows(DataTable table)
{
    return table.Rows
        .Cast<DataRow>()
        .Select(row => table.Columns
            .Cast<DataColumn>()
            .ToDictionary(
                column => column.ColumnName,
                column => row[column] == DBNull.Value ? null : row[column]))
        .ToList();
}

public sealed record LoginRequest(string UserName, string Password);

public sealed record PasswordRequest(string Password);

public sealed record UserRequest(
    int PersonID,
    string UserName,
    string Password,
    bool IsActive);

public sealed record PersonRequest(
    string NationalID,
    string FirstName,
    string SecondName,
    string ThirdName,
    string LastName,
    DateTime DateOfBirth,
    int Gender,
    string Address,
    string Phone,
    string Email,
    int NationalityCountryID,
    string? ImagePath);

public sealed record ApplicationTypeRequest(string Title, decimal Fees);

public sealed record TestTypeRequest(
    string Title,
    string Description,
    decimal Fees);

public sealed record LocalDrivingLicenseApplicationRequest(
    string ClassName,
    string NationalID,
    string FullName,
    DateTime ApplicationDate);
