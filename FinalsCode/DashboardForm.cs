using System;
using System.Drawing;
using System.Windows.Forms;

namespace FinalsCode
{
    public partial class DashboardForm : Form
    {
        private readonly System.Windows.Forms.Timer _clockTimer;

        public DashboardForm()
        {
            InitializeComponent();
            _clockTimer = new System.Windows.Forms.Timer();
            this.Load += DashboardForm_Load;
        }

        private void DashboardForm_Load(object? sender, EventArgs e)
        {
            if (DesignMode) return;

            _clockTimer.Interval = 1000;
            _clockTimer.Tick += (s, ev) => UpdateClock();
            _clockTimer.Start();

            SetupGrids();
            CarRentalService.EnsureDatabaseTables(out _);
            LoadAllData();
            UpdateClock();

            txtConnString.Text = CarRentalService.ConnectionString;
            if (cmbAddCategory.Items.Count > 0) cmbAddCategory.SelectedIndex = 0;
            if (cmbFleetFilter.Items.Count > 0) cmbFleetFilter.SelectedIndex = 0;
        }

        private void UpdateClock()
        {
            lblLiveClock.Text = DateTime.Now.ToString("dddd, MMM dd, yyyy  hh:mm:ss tt");
        }

        private void SetupGrids()
        {
            gridOverviewFleet.Columns.Clear();
            gridOverviewFleet.Columns.Add("Model", "Model");
            gridOverviewFleet.Columns.Add("Category", "Category");
            gridOverviewFleet.Columns.Add("Plate", "Plate Number");
            gridOverviewFleet.Columns.Add("Rate", "Daily Rate");
            gridOverviewFleet.Columns.Add("Status", "Status");

            gridFleet.Columns.Clear();
            gridFleet.Columns.Add("Id", "ID");
            gridFleet.Columns.Add("Brand", "Brand");
            gridFleet.Columns.Add("Model", "Model");
            gridFleet.Columns.Add("Category", "Category");
            gridFleet.Columns.Add("Plate", "Plate No.");
            gridFleet.Columns.Add("Rate", "Daily Rate");
            gridFleet.Columns.Add("Status", "Status");

            gridRentals.Columns.Clear();
            gridRentals.Columns.Add("RentalId", "Rental #");
            gridRentals.Columns.Add("Customer", "Customer Name");
            gridRentals.Columns.Add("Phone", "Phone");
            gridRentals.Columns.Add("Car", "Rented Vehicle");
            gridRentals.Columns.Add("RentDate", "Start Date");
            gridRentals.Columns.Add("ReturnDate", "Due Date");
            gridRentals.Columns.Add("Days", "Days");
            gridRentals.Columns.Add("Cost", "Total Cost");
            gridRentals.Columns.Add("Status", "Status");
        }

        public void LoadAllData()
        {
            UpdateStats();
            LoadOverviewFleet();
            LoadFleetGrid();
            LoadRentalsGrid();
            PopulateCarComboBox();
            RecalculateBookingCost();
        }

        private void UpdateStats()
        {
            var stats = CarRentalService.GetDashboardStats();
            lblStatTotalVal.Text = stats.TotalCars + " Cars";
            lblStatAvailVal.Text = stats.AvailableCars + " Cars";
            lblStatRentedVal.Text = stats.RentedCars + " Cars";
            lblStatRevenueVal.Text = "₱" + stats.TotalRevenue.ToString("N2");
        }

        private void LoadOverviewFleet()
        {
            gridOverviewFleet.Rows.Clear();
            var availCars = CarRentalService.GetAvailableCars();

            foreach (var c in availCars)
            {
                int idx = gridOverviewFleet.Rows.Add(
                    c.Brand + " " + c.Model,
                    c.Category,
                    c.PlateNumber,
                    "₱" + c.DailyRate.ToString("F2"),
                    c.Status
                );
                gridOverviewFleet.Rows[idx].Cells["Status"].Style.ForeColor = Color.Green;
            }
        }

        private void LoadFleetGrid()
        {
            gridFleet.Rows.Clear();
            string search = txtFleetSearch.Text.Trim().ToLower();
            string categoryFilter = cmbFleetFilter.SelectedItem != null ? cmbFleetFilter.SelectedItem.ToString()! : "All Categories";

            var cars = CarRentalService.GetCars();
            foreach (var c in cars)
            {
                if (categoryFilter != "All Categories" && c.Category != categoryFilter)
                {
                    continue;
                }

                if (!string.IsNullOrEmpty(search))
                {
                    bool match = c.Brand.ToLower().Contains(search) ||
                                 c.Model.ToLower().Contains(search) ||
                                 c.PlateNumber.ToLower().Contains(search);
                    if (!match) continue;
                }

                int idx = gridFleet.Rows.Add(
                    c.Id,
                    c.Brand,
                    c.Model,
                    c.Category,
                    c.PlateNumber,
                    "₱" + c.DailyRate.ToString("F2"),
                    c.Status
                );

                if (c.Status == "Available")
                {
                    gridFleet.Rows[idx].Cells["Status"].Style.ForeColor = Color.Green;
                }
                else
                {
                    gridFleet.Rows[idx].Cells["Status"].Style.ForeColor = Color.OrangeRed;
                }
            }
        }

        private void LoadRentalsGrid()
        {
            gridRentals.Rows.Clear();
            var rentals = CarRentalService.GetRentals();

            foreach (var r in rentals)
            {
                int idx = gridRentals.Rows.Add(
                    "#" + r.RentalId,
                    r.CustomerName,
                    r.CustomerPhone,
                    r.CarName,
                    r.RentDate.ToString("yyyy-MM-dd"),
                    r.ReturnDate.ToString("yyyy-MM-dd"),
                    r.TotalDays + " days",
                    "₱" + r.TotalCost.ToString("F2"),
                    r.Status
                );

                if (r.Status == "Active")
                {
                    gridRentals.Rows[idx].Cells["Status"].Style.ForeColor = Color.OrangeRed;
                }
                else
                {
                    gridRentals.Rows[idx].Cells["Status"].Style.ForeColor = Color.Green;
                }
            }
        }

        private void PopulateCarComboBox()
        {
            var availCars = CarRentalService.GetAvailableCars();
            cmbCars.DataSource = null;
            cmbCars.DisplayMember = "DisplayName";
            cmbCars.ValueMember = "Id";
            cmbCars.DataSource = availCars;

            if (availCars.Count == 0)
            {
                btnConfirmBooking.Enabled = false;
                lblBookingFeedback.ForeColor = Color.OrangeRed;
                lblBookingFeedback.Text = "All cars are currently rented out or database has no available cars.";
            }
            else
            {
                btnConfirmBooking.Enabled = true;
                lblBookingFeedback.ForeColor = Color.Gray;
                lblBookingFeedback.Text = availCars.Count + " vehicles currently available in database.";
            }
        }

        private void RecalculateBookingCost()
        {
            Car? selectedCar = cmbCars.SelectedItem as Car;
            if (selectedCar != null)
            {
                int days = (int)numDays.Value;
                decimal total = selectedCar.DailyRate * days;
                lblDailyRateNote.Text = "₱" + selectedCar.DailyRate.ToString("F2") + "/day x " + days + " day(s)";
                lblTotalCalculated.Text = "₱" + total.ToString("F2");
            }
            else
            {
                lblDailyRateNote.Text = "Estimated Total:";
                lblTotalCalculated.Text = "₱0.00";
            }
        }

        private void cmbCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecalculateBookingCost();
        }

        private void numDays_ValueChanged(object sender, EventArgs e)
        {
            RecalculateBookingCost();
        }

        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            Car? selectedCar = cmbCars.SelectedItem as Car;
            if (selectedCar == null)
            {
                MessageBox.Show("Please select an available car first.", "Selection Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = txtCustName.Text.Trim();
            string phone = txtCustPhone.Text.Trim();
            int days = (int)numDays.Value;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter the customer's full name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Please enter the customer's contact number.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustPhone.Focus();
                return;
            }

            Rental? rental;
            string error;
            bool success = CarRentalService.BookCar(name, phone, selectedCar.Id, days, out rental, out error);

            if (success && rental != null)
            {
                lblBookingFeedback.ForeColor = Color.Green;
                lblBookingFeedback.Text = "✔ Booking #" + rental.RentalId + " recorded in SQL Server for " + rental.CustomerName + "!";

                MessageBox.Show(
                    "Booking Saved to SQL Database!\n\n" +
                    "Rental ID: #" + rental.RentalId + "\n" +
                    "Customer: " + rental.CustomerName + "\n" +
                    "Vehicle: " + rental.CarName + "\n" +
                    "Duration: " + rental.TotalDays + " days\n" +
                    "Total Amount: ₱" + rental.TotalCost.ToString("F2") + "\n" +
                    "Due Date: " + rental.ReturnDate.ToString("yyyy-MM-dd"),
                    "Rental Recorded in Database", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCustName.Clear();
                txtCustPhone.Clear();
                numDays.Value = 3;

                LoadAllData();
            }
            else
            {
                MessageBox.Show("Failed to book car in SQL database:\n" + error, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            string brand = txtAddBrand.Text.Trim();
            string model = txtAddModel.Text.Trim();
            string cat = cmbAddCategory.SelectedItem != null ? cmbAddCategory.SelectedItem.ToString()! : "Sedan";
            string plate = txtAddPlate.Text.Trim();
            decimal rate = numAddRate.Value;

            string err;
            if (CarRentalService.AddCar(brand, model, cat, plate, rate, out err))
            {
                MessageBox.Show("Vehicle '" + brand + " " + model + "' successfully saved into SQL Server (Cars table)!",
                    "Saved to Database", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtAddBrand.Clear();
                txtAddModel.Clear();
                txtAddPlate.Clear();
                numAddRate.Value = 60;

                LoadAllData();
            }
            else
            {
                MessageBox.Show("Could not save to database:\n" + err, "Validation/Database Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReturnCar_Click(object sender, EventArgs e)
        {
            if (gridRentals.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a rental record to mark as returned.", "Selection Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string rawId = gridRentals.SelectedRows[0].Cells["RentalId"].Value?.ToString() ?? "";
            string cleanId = rawId.Replace("#", "").Trim();

            int rentalId;
            if (int.TryParse(cleanId, out rentalId))
            {
                string msg;
                if (CarRentalService.ReturnCar(rentalId, out msg))
                {
                    MessageBox.Show(msg, "Return Processed in SQL Database", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllData();
                }
                else
                {
                    MessageBox.Show(msg, "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ShowView(Panel targetPanel, string title, string subtitle, Button activeButton)
        {
            panelOverview.Visible = false;
            panelFleet.Visible = false;
            panelRentals.Visible = false;
            panelDatabase.Visible = false;

            targetPanel.Visible = true;
            targetPanel.BringToFront();

            lblPageTitle.Text = title;
            lblPageSubtitle.Text = subtitle;

            Button[] navButtons = { btnNavOverview, btnNavBooking, btnNavFleet, btnNavRentals, btnNavDatabase };
            foreach (Button btn in navButtons)
            {
                btn.BackColor = Color.FromArgb(15, 23, 42);
                btn.ForeColor = Color.FromArgb(203, 213, 225);
                btn.Font = new Font("Segoe UI", 9.5F);
            }

            activeButton.BackColor = Color.FromArgb(37, 99, 235);
            activeButton.ForeColor = Color.White;
            activeButton.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
        }

        private void btnNavOverview_Click(object sender, EventArgs e)
        {
            ShowView(panelOverview, "Dashboard Overview", "Real-time car fleet overview, instant reservations, and rental activity", btnNavOverview);
            LoadAllData();
        }

        private void btnNavBooking_Click(object sender, EventArgs e)
        {
            ShowView(panelOverview, "Quick Rent (Get Started)", "Make a new car rental reservation for a customer", btnNavBooking);
            txtCustName.Focus();
        }

        private void btnNavFleet_Click(object sender, EventArgs e)
        {
            ShowView(panelFleet, "Fleet Inventory", "Browse, search, filter and register vehicles in your rental fleet", btnNavFleet);
            LoadFleetGrid();
        }

        private void btnNavRentals_Click(object sender, EventArgs e)
        {
            ShowView(panelRentals, "Active Rentals & History", "Track active client contracts and mark returned vehicles", btnNavRentals);
            LoadRentalsGrid();
        }

        private void btnNavDatabase_Click(object sender, EventArgs e)
        {
            ShowView(panelDatabase, "SQL Database Connection", "Test and inspect your SQL Server CarRentalDB configuration", btnNavDatabase);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFleetSearch_TextChanged(object sender, EventArgs e)
        {
            LoadFleetGrid();
        }

        private void cmbFleetFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFleetGrid();
        }

        private void btnTestDbInDash_Click(object sender, EventArgs e)
        {
            CarRentalService.ConnectionString = txtConnString.Text.Trim();
            txtDbLog.AppendText("[" + DateTime.Now.ToString("HH:mm:ss") + "] Connecting to SQL Server: " + CarRentalService.ConnectionString + "...\r\n");

            string msg;
            bool ok = CarRentalService.EnsureDatabaseTables(out msg);
            if (ok)
            {
                txtDbLog.AppendText("[" + DateTime.Now.ToString("HH:mm:ss") + "] SUCCESS: " + msg + "\r\n\r\n");
                MessageBox.Show("Connected to SQL Server and verified Cars & Rentals tables successfully!",
                    "Connection & Tables Verified", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllData();
            }
            else
            {
                txtDbLog.AppendText("[" + DateTime.Now.ToString("HH:mm:ss") + "] ERROR: " + msg + "\r\n\r\n");
                MessageBox.Show("Failed to connect:\n" + msg, "Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGenerateSql_Click(object sender, EventArgs e)
        {
            string script = @"USE CarRentalDB;
GO

-- 1. Create Cars table if it does not exist
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Cars')
BEGIN
    CREATE TABLE Cars (
        CarId INT IDENTITY(1,1) PRIMARY KEY,
        Brand NVARCHAR(50) NOT NULL,
        Model NVARCHAR(50) NOT NULL,
        Category NVARCHAR(50) NOT NULL,
        PlateNumber NVARCHAR(20) UNIQUE NOT NULL,
        DailyRate DECIMAL(18,2) NOT NULL,
        Status NVARCHAR(20) NOT NULL DEFAULT 'Available'
    );

    INSERT INTO Cars (Brand, Model, Category, PlateNumber, DailyRate, Status) VALUES
    ('Toyota', 'Camry SE', 'Sedan', 'ABC-1234', 45.00, 'Available'),
    ('Honda', 'CR-V Hybrid', 'SUV', 'CRV-5678', 65.00, 'Available'),
    ('Tesla', 'Model 3 Long Range', 'Electric', 'TSL-9988', 85.00, 'Available'),
    ('Ford', 'Mustang GT', 'Sports', 'MST-4040', 95.00, 'Available'),
    ('BMW', '330i M Sport', 'Luxury', 'BMW-3301', 110.00, 'Available'),
    ('Hyundai', 'Tucson Ultimate', 'SUV', 'TUC-7721', 55.00, 'Available'),
    ('Nissan', 'Altima SV', 'Sedan', 'NSN-3344', 42.00, 'Available'),
    ('Mercedes-Benz', 'C300 Sedan', 'Luxury', 'MBZ-8899', 125.00, 'Available');
END
GO

-- 2. Create Rentals table if it does not exist
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Rentals')
BEGIN
    CREATE TABLE Rentals (
        RentalId INT IDENTITY(1001,1) PRIMARY KEY,
        CustomerName NVARCHAR(100) NOT NULL,
        CustomerPhone NVARCHAR(50) NOT NULL,
        CarId INT NOT NULL,
        RentDate DATETIME NOT NULL DEFAULT GETDATE(),
        ReturnDate DATETIME NOT NULL,
        TotalDays INT NOT NULL,
        TotalCost DECIMAL(18,2) NOT NULL,
        Status NVARCHAR(20) NOT NULL DEFAULT 'Active',
        CONSTRAINT FK_Rentals_Cars FOREIGN KEY (CarId) REFERENCES Cars(CarId)
    );
END
GO

-- 3. Verification query
SELECT * FROM Cars;
SELECT * FROM Rentals;
GO";
            txtDbLog.Text = script;
            MessageBox.Show("SQL script loaded into the console below! You can copy and execute it directly in SQL Server Management Studio (SSMS).", "SQL Script", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void costSummaryPanel_Paint(object sender, PaintEventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void lblStatRevenueVal_Click(object sender, EventArgs e) { }
    }
}
