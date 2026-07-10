using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Driving_License_Management_System.LicenseManage
{
    public partial class frmLicenseManage : Form
    {
        private DataTable _applications = new DataTable();

        public frmLicenseManage()
        {
            InitializeComponent();
            UiTheme.Apply(this);
        }

        private void LicenseManage_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            LoadApplications();
            InitializeFilters();
        }

        private void ConfigureDataGridView()
        {
            dgvApplicaton.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvApplicaton.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvApplicaton.MultiSelect = false;
            dgvApplicaton.ReadOnly = true;
            dgvApplicaton.AllowUserToAddRows = false;
            dgvApplicaton.AllowUserToDeleteRows = false;
            dgvApplicaton.RowHeadersVisible = false;
        }

        private void LoadApplications()
        {
            _applications =
                DVLD_Business_Layer.LicensManage.DBALicenseManage.GetallApplicaiton();

            _applications.DefaultView.RowFilter = string.Empty;
            dgvApplicaton.DataSource = _applications;
            UpdateRecordCount();
        }

        private void InitializeFilters()
        {
            cbfilter.SelectedIndexChanged -= cbfilter_SelectedIndexChanged;
            textBox1.TextChanged -= textBox1_TextChanged;

            cbfilter.Items.Clear();
            cbfilter.Items.Add("None");
            cbfilter.Items.Add("Local License Application ID");
            cbfilter.Items.Add("National ID");
            cbfilter.Items.Add("Status");

            cbfilter.SelectedIndex = 0;
            textBox1.Clear();
            textBox1.Visible = false;

            cbfilter.SelectedIndexChanged += cbfilter_SelectedIndexChanged;
            textBox1.TextChanged += textBox1_TextChanged;
        }

        private void cbfilter_SelectedIndexChanged(object? sender, EventArgs e)
        {
            textBox1.Clear();

            bool filterEnabled = cbfilter.SelectedItem?.ToString() != "None";
            textBox1.Visible = filterEnabled;

            if (!filterEnabled)
            {
                _applications.DefaultView.RowFilter = string.Empty;
                dgvApplicaton.DataSource = _applications;
                UpdateRecordCount();
                return;
            }

            textBox1.Focus();
        }

        private void textBox1_TextChanged(object? sender, EventArgs e)
        {
            if (!textBox1.Visible)
                return;

            string value = textBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(value))
            {
                _applications.DefaultView.RowFilter = string.Empty;
                dgvApplicaton.DataSource = _applications;
                UpdateRecordCount();
                return;
            }

            string? columnName = ResolveColumnName(cbfilter.SelectedItem?.ToString());

            if (string.IsNullOrEmpty(columnName))
                return;

            DataView view = _applications.DefaultView;
            view.RowFilter = BuildRowFilter(columnName, value);
            dgvApplicaton.DataSource = view;
            UpdateRecordCount();
        }

        private string? ResolveColumnName(string? selectedFilter)
        {
            if (string.IsNullOrWhiteSpace(selectedFilter))
                return null;

            string[] candidates = selectedFilter switch
            {
                "Local License Application ID" => new[]
                {
                    "LocalDrivingLicenseApplicationID",
                    "Local License Application ID",
                    "ApplicationID"
                },
                "National ID" => new[] { "NationalID", "NationalNo", "National ID" },
                "Status" => new[] { "Status", "ApplicationStatus" },
                _ => Array.Empty<string>()
            };

            return candidates.FirstOrDefault(_applications.Columns.Contains);
        }

        private static string BuildRowFilter(string columnName, string value)
        {
            string escapedValue = value.Replace("'", "''");
            string escapedColumn = columnName.Replace("]", "]]");

            return $"Convert([{escapedColumn}], 'System.String') LIKE '%{escapedValue}%'";
        }

        private void UpdateRecordCount()
        {
            lbRecorde.Text = dgvApplicaton.Rows.Count.ToString();
        }
    }
}
