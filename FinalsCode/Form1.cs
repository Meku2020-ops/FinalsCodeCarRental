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
            fleetPreviewGrid.EnableHeadersVisualStyles = false;
            fleetPreviewGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(16, 24, 28);
            fleetPreviewGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(110, 231, 183);
            fleetPreviewGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            fleetPreviewGrid.DefaultCellStyle.BackColor = Color.FromArgb(22, 28, 38);
            fleetPreviewGrid.DefaultCellStyle.ForeColor = Color.White;
            fleetPreviewGrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(5, 150, 105);
            fleetPreviewGrid.DefaultCellStyle.SelectionForeColor = Color.White;
            fleetPreviewGrid.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            fleetPreviewGrid.RowTemplate.Height = 32;
            fleetPreviewGrid.GridColor = Color.FromArgb(43, 52, 66);
            fleetPreviewGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            fleetPreviewGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            fleetPreviewGrid.Columns.Clear();
            int colModel = fleetPreviewGrid.Columns.Add("Model", "Vehicle Model");
            int colCategory = fleetPreviewGrid.Columns.Add("Category", "Type");
            int colSeaters = fleetPreviewGrid.Columns.Add("Seaters", "Seaters");
            int colRate = fleetPreviewGrid.Columns.Add("DailyRate", "Rate / Day");
            int colStatus = fleetPreviewGrid.Columns.Add("Status", "Status");

            fleetPreviewGrid.Columns[colModel].FillWeight = 38;
            fleetPreviewGrid.Columns[colCategory].FillWeight = 20;
            fleetPreviewGrid.Columns[colSeaters].FillWeight = 18;
            fleetPreviewGrid.Columns[colRate].FillWeight = 24;
            fleetPreviewGrid.Columns[colStatus].FillWeight = 20;
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
                    car.Seaters + " Seaters",
                    "₱" + car.DailyRate.ToString("F2"),
                    car.Status
                );

                if (car.Status == "Available")
                {
                    fleetPreviewGrid.Rows[rowIndex].Cells["Status"].Style.ForeColor = Color.FromArgb(52, 211, 153);
                }
                else
                {
                    fleetPreviewGrid.Rows[rowIndex].Cells["Status"].Style.ForeColor = Color.FromArgb(251, 146, 60);
                }
            }

            var stats = CarRentalService.GetDashboardStats();
            pillTotal.Text = "🚘 " + stats.TotalCars + " Registered Units";
            pillAvailable.Text = "🟢 " + stats.AvailableCars + " Ready for Lease";

            if (cars.Count > 0)
            {
                lblStatus.ForeColor = Color.FromArgb(52, 211, 153);
                lblStatus.Text = "Connected to CarRentalDB. " + cars.Count + " showroom vehicles loaded.";
            }
        }

        private void btnGetStarted_Click(object sender, EventArgs e)
        {
            lblStatus.ForeColor = Color.FromArgb(110, 231, 183);
            lblStatus.Text = "Opening Apex Fleet Console...";

            this.Hide();
            using (DashboardForm dashboard = new DashboardForm())
            {
                dashboard.ShowDialog();
            }
            this.Show();

            LoadFleetPreview();
            lblStatus.ForeColor = Color.FromArgb(160, 174, 192);
            lblStatus.Text = "Console Session Active. Ready for new operations.";
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
