using Driving_License_Management_System.Forms.Users;
using System.Drawing;
using System.Windows.Forms;

namespace Driving_License_Management_System
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmLogin());
        }
    }

    internal static class UiTheme
    {
        private static readonly Font DefaultFont =
            new("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);

        private static readonly Font HeaderFont =
            new("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);

        private static readonly Color PageBackground = Color.FromArgb(244, 247, 251);
        private static readonly Color Surface = Color.White;
        private static readonly Color SurfaceAlt = Color.FromArgb(238, 244, 248);
        private static readonly Color Border = Color.FromArgb(211, 220, 230);
        private static readonly Color TextPrimary = Color.FromArgb(31, 41, 55);
        private static readonly Color TextMuted = Color.FromArgb(85, 100, 116);
        private static readonly Color Primary = Color.FromArgb(15, 118, 110);
        private static readonly Color PrimaryDark = Color.FromArgb(17, 71, 85);
        private static readonly Color Accent = Color.FromArgb(217, 119, 6);
        private static readonly Color Danger = Color.FromArgb(185, 28, 28);
        private static readonly Color Neutral = Color.FromArgb(71, 85, 105);

        public static void Apply(Form form)
        {
            form.SuspendLayout();

            form.Font = DefaultFont;
            form.BackColor = PageBackground;
            form.ForeColor = TextPrimary;

            if (form.WindowState != FormWindowState.Maximized)
            {
                form.StartPosition = FormStartPosition.CenterScreen;
            }

            ApplyToControls(form.Controls);
            StyleContextMenu(form.ContextMenuStrip);

            form.ResumeLayout(false);
        }

        public static void Apply(UserControl control)
        {
            control.SuspendLayout();

            control.Font = DefaultFont;
            control.BackColor = PageBackground;
            control.ForeColor = TextPrimary;

            ApplyToControls(control.Controls);
            StyleContextMenu(control.ContextMenuStrip);

            control.ResumeLayout(false);
        }

        private static void ApplyToControls(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                StyleControl(control);
                ApplyToControls(control.Controls);
            }
        }

        private static void StyleControl(Control control)
        {
            control.ForeColor = TextPrimary;
            StyleContextMenu(control.ContextMenuStrip);

            switch (control)
            {
                case MenuStrip menuStrip:
                    StyleMenuStrip(menuStrip);
                    break;

                case DataGridView grid:
                    StyleGrid(grid);
                    break;

                case Button button:
                    StyleButton(button);
                    break;

                case TextBox textBox:
                    StyleTextBox(textBox);
                    break;

                case RichTextBox richTextBox:
                    StyleRichTextBox(richTextBox);
                    break;

                case ComboBox comboBox:
                    StyleComboBox(comboBox);
                    break;

                case LinkLabel linkLabel:
                    StyleLinkLabel(linkLabel);
                    break;

                case GroupBox groupBox:
                    StyleGroupBox(groupBox);
                    break;

                case TabControl tabControl:
                    StyleTabControl(tabControl);
                    break;

                case TabPage tabPage:
                    tabPage.BackColor = PageBackground;
                    break;

                case CheckBox checkBox:
                    StyleCheckBox(checkBox);
                    break;

                case RadioButton radioButton:
                    StyleRadioButton(radioButton);
                    break;

                case Label label:
                    StyleLabel(label);
                    break;

                case DateTimePicker dateTimePicker:
                    StyleDateTimePicker(dateTimePicker);
                    break;

                case PictureBox pictureBox:
                    pictureBox.BackColor = Color.Transparent;
                    break;
            }
        }

        private static void StyleMenuStrip(MenuStrip menuStrip)
        {
            menuStrip.BackColor = PrimaryDark;
            menuStrip.ForeColor = Color.White;
            menuStrip.Font = HeaderFont;
            menuStrip.Padding = new Padding(10, 5, 10, 5);
            menuStrip.Renderer = new ToolStripProfessionalRenderer(new AppColorTable());

            StyleToolStripItems(menuStrip.Items, true);
        }

        private static void StyleContextMenu(ContextMenuStrip? contextMenu)
        {
            if (contextMenu == null)
            {
                return;
            }

            contextMenu.BackColor = Surface;
            contextMenu.ForeColor = TextPrimary;
            contextMenu.Font = DefaultFont;
            contextMenu.Renderer = new ToolStripProfessionalRenderer(new AppColorTable());

            StyleToolStripItems(contextMenu.Items, false);
        }

        private static void StyleToolStripItems(
            ToolStripItemCollection items,
            bool topLevel)
        {
            foreach (ToolStripItem item in items)
            {
                item.Font = topLevel ? HeaderFont : DefaultFont;
                item.ForeColor = topLevel ? Color.White : TextPrimary;
                item.BackColor = topLevel ? PrimaryDark : Surface;
                item.Padding = topLevel
                    ? new Padding(10, 4, 10, 4)
                    : new Padding(8, 4, 8, 4);

                if (item is ToolStripMenuItem menuItem)
                {
                    menuItem.DropDown.BackColor = Surface;
                    menuItem.DropDown.ForeColor = TextPrimary;
                    menuItem.DropDown.Padding = new Padding(4);
                    StyleToolStripItems(menuItem.DropDownItems, false);
                }
            }
        }

        private static void StyleGrid(DataGridView grid)
        {
            grid.EnableHeadersVisualStyles = false;
            grid.BackgroundColor = Surface;
            grid.BorderStyle = BorderStyle.None;
            grid.GridColor = Border;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            grid.ColumnHeadersDefaultCellStyle.BackColor = PrimaryDark;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = HeaderFont;
            grid.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            grid.ColumnHeadersHeight = Math.Max(grid.ColumnHeadersHeight, 38);

            grid.DefaultCellStyle.BackColor = Surface;
            grid.DefaultCellStyle.ForeColor = TextPrimary;
            grid.DefaultCellStyle.SelectionBackColor = Primary;
            grid.DefaultCellStyle.SelectionForeColor = Color.White;
            grid.DefaultCellStyle.Font = DefaultFont;
            grid.DefaultCellStyle.Padding = new Padding(4, 2, 4, 2);

            grid.AlternatingRowsDefaultCellStyle.BackColor = SurfaceAlt;
            grid.AlternatingRowsDefaultCellStyle.ForeColor = TextPrimary;
            grid.RowTemplate.Height = Math.Max(grid.RowTemplate.Height, 32);
        }

        private static void StyleButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.UseVisualStyleBackColor = false;
            button.Cursor = Cursors.Hand;
            button.Font = HeaderFont;
            button.ForeColor = Color.White;
            button.BackColor = ButtonColor(button.Text);
        }

        private static Color ButtonColor(string text)
        {
            string normalized = text.Trim().ToLowerInvariant();

            if (normalized.Contains("delete") || normalized.Contains("delet"))
            {
                return Danger;
            }

            if (normalized.Contains("close") || normalized.Contains("cancel"))
            {
                return Neutral;
            }

            if (normalized.Contains("next"))
            {
                return Accent;
            }

            return Primary;
        }

        private static void StyleTextBox(TextBox textBox)
        {
            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.BackColor = Surface;
            textBox.ForeColor = TextPrimary;
        }

        private static void StyleRichTextBox(RichTextBox richTextBox)
        {
            richTextBox.BorderStyle = BorderStyle.FixedSingle;
            richTextBox.BackColor = Surface;
            richTextBox.ForeColor = TextPrimary;
        }

        private static void StyleComboBox(ComboBox comboBox)
        {
            comboBox.FlatStyle = FlatStyle.Flat;
            comboBox.BackColor = Surface;
            comboBox.ForeColor = TextPrimary;
        }

        private static void StyleLinkLabel(LinkLabel linkLabel)
        {
            linkLabel.BackColor = Color.Transparent;
            linkLabel.LinkColor = Primary;
            linkLabel.ActiveLinkColor = Accent;
            linkLabel.VisitedLinkColor = PrimaryDark;
        }

        private static void StyleLabel(Label label)
        {
            label.BackColor = Color.Transparent;

            if (label.Font.Bold && label.Font.Size >= 14F)
            {
                label.ForeColor = PrimaryDark;
                return;
            }

            label.ForeColor = label.Font.Bold ? TextPrimary : TextMuted;
        }

        private static void StyleGroupBox(GroupBox groupBox)
        {
            groupBox.BackColor = PageBackground;
            groupBox.ForeColor = TextPrimary;
            groupBox.Font = HeaderFont;
        }

        private static void StyleTabControl(TabControl tabControl)
        {
            tabControl.Font = HeaderFont;
            tabControl.BackColor = PageBackground;
        }

        private static void StyleCheckBox(CheckBox checkBox)
        {
            checkBox.BackColor = Color.Transparent;
            checkBox.ForeColor = TextPrimary;
        }

        private static void StyleRadioButton(RadioButton radioButton)
        {
            radioButton.BackColor = Color.Transparent;
            radioButton.ForeColor = TextPrimary;
        }

        private static void StyleDateTimePicker(DateTimePicker dateTimePicker)
        {
            dateTimePicker.CalendarTitleBackColor = PrimaryDark;
            dateTimePicker.CalendarTitleForeColor = Color.White;
            dateTimePicker.CalendarForeColor = TextPrimary;
            dateTimePicker.CalendarMonthBackground = Surface;
        }

        private sealed class AppColorTable : ProfessionalColorTable
        {
            public override Color ToolStripGradientBegin => PrimaryDark;
            public override Color ToolStripGradientMiddle => PrimaryDark;
            public override Color ToolStripGradientEnd => PrimaryDark;
            public override Color MenuStripGradientBegin => PrimaryDark;
            public override Color MenuStripGradientEnd => PrimaryDark;
            public override Color ToolStripDropDownBackground => Surface;
            public override Color MenuBorder => Border;
            public override Color MenuItemBorder => Primary;
            public override Color MenuItemSelected => Color.FromArgb(222, 241, 239);
            public override Color MenuItemSelectedGradientBegin =>
                Color.FromArgb(222, 241, 239);
            public override Color MenuItemSelectedGradientEnd =>
                Color.FromArgb(222, 241, 239);
            public override Color MenuItemPressedGradientBegin => Primary;
            public override Color MenuItemPressedGradientMiddle => Primary;
            public override Color MenuItemPressedGradientEnd => Primary;
            public override Color ImageMarginGradientBegin => SurfaceAlt;
            public override Color ImageMarginGradientMiddle => SurfaceAlt;
            public override Color ImageMarginGradientEnd => SurfaceAlt;
        }
    }
}
