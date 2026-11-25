using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FinalsCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            if (DesignMode) return;

            ConfigurePreviewGrid();
            CarRentalService.EnsureDatabaseTables(out _);
            LoadFleetPreview();
        }

        private void ConfigurePreviewGrid()
        {
            fleetPreviewGrid.EnableHeadersVisualStyles = false;
            fleetPreviewGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 23, 42);
            fleetPreviewGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(148, 163, 184);
            fleetPreviewGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            fleetPreviewGrid.DefaultCellStyle.BackColor = Color.FromArgb(30, 41, 59);
            fleetPreviewGrid.DefaultCellStyle.ForeColor = Color.White;
            fleetPreviewGrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(37, 99, 235);
            fleetPreviewGrid.DefaultCellStyle.SelectionForeColor = Color.White;
            fleetPreviewGrid.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            fleetPreviewGrid.RowTemplate.Height = 32;
            fleetPreviewGrid.GridColor = Color.FromArgb(51, 65, 85);
            fleetPreviewGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            fleetPreviewGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            fleetPreviewGrid.Columns.Clear();
            fleetPreviewGrid.Columns.Add("Model", "Vehicle Model");
            fleetPreviewGrid.Columns.Add("Category", "Type");
            fleetPreviewGrid.Columns.Add("DailyRate", "Rate / Day");
            fleetPreviewGrid.Columns.Add("Status", "Status");

            if (fleetPreviewGrid.Columns["Model"] != null) fleetPreviewGrid.Columns["Model"]!.FillWeight = 45;
            if (fleetPreviewGrid.Columns["Category"] != null) fleetPreviewGrid.Columns["Category"]!.FillWeight = 25;
            if (fleetPreviewGrid.Columns["DailyRate"] != null) fleetPreviewGrid.Columns["DailyRate"]!.FillWeight = 30;
            if (fleetPreviewGrid.Columns["Status"] != null) fleetPreviewGrid.Columns["Status"]!.FillWeight = 25;
        }

        private void LoadFleetPreview()
        {
            fleetPreviewGrid.Rows.Clear();
            var cars = CarRentalService.GetCars();

            foreach (var car in cars)
            {
                int rowIndex = fleetPreviewGrid.Rows.Add(
                    $"{car.Brand} {car.Model}",
                    car.Category,
                    $"${car.DailyRate:F2}",
                    car.Status
                );

                if (car.Status == "Available")
                {
                    fleetPreviewGrid.Rows[rowIndex].Cells["Status"].Style.ForeColor = Color.FromArgb(74, 222, 128);
                }
                else
                {
                    fleetPreviewGrid.Rows[rowIndex].Cells["Status"].Style.ForeColor = Color.FromArgb(251, 146, 60);
                }
            }

            var stats = CarRentalService.GetDashboardStats();
            pillTotal.Text = $"🚘 {stats.TotalCars} in SQL DB";
            pillAvailable.Text = $"🟢 {stats.AvailableCars} Available";

            if (cars.Count > 0)
            {
                lblStatus.ForeColor = Color.FromArgb(74, 222, 128);
                lblStatus.Text = $"Connected to CarRentalDB. {cars.Count} vehicles loaded from database.";
            }
        }

        private void btnGetStarted_Click(object sender, EventArgs e)
        {
            lblStatus.ForeColor = Color.FromArgb(96, 165, 250);
            lblStatus.Text = "Opening Car Rental Dashboard...";

            this.Hide();
            using var dashboard = new DashboardForm();
            dashboard.ShowDialog();
            this.Show();

            LoadFleetPreview();
            lblStatus.ForeColor = Color.FromArgb(148, 163, 184);
            lblStatus.Text = "Welcome back! Ready to explore or make a new booking.";
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            btnTestConnection.Enabled = false;
            btnTestConnection.Text = "Connecting...";
            lblStatus.ForeColor = Color.FromArgb(251, 191, 36);
            lblStatus.Text = "Testing connection and ensuring tables in CarRentalDB...";
            Application.DoEvents();

            bool isConnected = CarRentalService.EnsureDatabaseTables(out string message);

            btnTestConnection.Enabled = true;
            btnTestConnection.Text = "🔌 Test SQL Connection";

            if (isConnected)
            {
                lblStatus.ForeColor = Color.FromArgb(74, 222, 128);
                lblStatus.Text = "✅ Connected to CarRentalDB! Tables verified.";
                MessageBox.Show("Successfully connected to SQL Server (CarRentalDB)!\n\nCars and Rentals tables have been verified / created.",
                    "Connection Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadFleetPreview();
            }
            else
            {
                lblStatus.ForeColor = Color.FromArgb(248, 113, 113);
                lblStatus.Text = "⚠️ Unable to connect to SQL Server (RIAMU\\SQLEXPRESS).";
                MessageBox.Show($"Could not connect to SQL Server:\n{message}\n\nPlease make sure SQLEXPRESS service is running on RIAMU.",
                    "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void statsPillPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pillAvailable_Click(object sender, EventArgs e)
        {

        }
    }
}
