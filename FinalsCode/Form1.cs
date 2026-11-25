using System;
using System.Drawing;
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
            fleetPreviewGrid.Columns.Clear();
            int colModel = fleetPreviewGrid.Columns.Add("Model", "Vehicle Model");
            int colCategory = fleetPreviewGrid.Columns.Add("Category", "Type");
            int colRate = fleetPreviewGrid.Columns.Add("DailyRate", "Rate / Day");
            int colStatus = fleetPreviewGrid.Columns.Add("Status", "Status");

            fleetPreviewGrid.Columns[colModel].FillWeight = 45;
            fleetPreviewGrid.Columns[colCategory].FillWeight = 25;
            fleetPreviewGrid.Columns[colRate].FillWeight = 30;
            fleetPreviewGrid.Columns[colStatus].FillWeight = 25;
        }

        private void LoadFleetPreview()
        {
            fleetPreviewGrid.Rows.Clear();
            var cars = CarRentalService.GetCars();

            foreach (var car in cars)
            {
                int rowIndex = fleetPreviewGrid.Rows.Add(
                    car.Brand + " " + car.Model,
                    car.Category,
                    "₱" + car.DailyRate.ToString("F2"),
                    car.Status
                );

                if (car.Status == "Available")
                {
                    fleetPreviewGrid.Rows[rowIndex].Cells["Status"].Style.ForeColor = Color.LightGreen;
                }
                else
                {
                    fleetPreviewGrid.Rows[rowIndex].Cells["Status"].Style.ForeColor = Color.Orange;
                }
            }

            var stats = CarRentalService.GetDashboardStats();
            pillTotal.Text = "🚘 " + stats.TotalCars + " in SQL DB";
            pillAvailable.Text = "🟢 " + stats.AvailableCars + " Available";

            if (cars.Count > 0)
            {
                lblStatus.ForeColor = Color.LightGreen;
                lblStatus.Text = "Connected to CarRentalDB. " + cars.Count + " vehicles loaded from database.";
            }
        }

        private void btnGetStarted_Click(object sender, EventArgs e)
        {
            lblStatus.ForeColor = Color.SkyBlue;
            lblStatus.Text = "Opening Car Rental Dashboard...";

            this.Hide();
            using (DashboardForm dashboard = new DashboardForm())
            {
                dashboard.ShowDialog();
            }
            this.Show();

            LoadFleetPreview();
            lblStatus.ForeColor = Color.LightGray;
            lblStatus.Text = "Welcome back! Ready to explore or make a new booking.";
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            btnTestConnection.Enabled = false;
            btnTestConnection.Text = "Connecting...";
            lblStatus.ForeColor = Color.Yellow;
            lblStatus.Text = "Testing connection and ensuring tables in CarRentalDB...";
            Application.DoEvents();

            string message;
            bool isConnected = CarRentalService.EnsureDatabaseTables(out message);

            btnTestConnection.Enabled = true;
            btnTestConnection.Text = "🔌 Test SQL Connection";

            if (isConnected)
            {
                lblStatus.ForeColor = Color.LightGreen;
                lblStatus.Text = "✅ Connected to CarRentalDB! Tables verified.";
                MessageBox.Show("Successfully connected to SQL Server (CarRentalDB)!\n\nCars and Rentals tables have been verified / created.",
                    "Connection Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadFleetPreview();
            }
            else
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "⚠️ Unable to connect to SQL Server (RIAMU\\SQLEXPRESS).";
                MessageBox.Show("Could not connect to SQL Server:\n" + message + "\n\nPlease make sure SQLEXPRESS service is running on RIAMU.",
                    "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void statsPillPanel_Paint(object sender, PaintEventArgs e) { }
        private void pillAvailable_Click(object sender, EventArgs e) { }
        private void fleetPreviewGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
