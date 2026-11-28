using System;
using System.Drawing;
using System.Windows.Forms;

namespace FinalsCode
{
    public partial class DashboardForm : Form
    {
        private readonly System.Windows.Forms.Timer _clockTimer;
        private bool _isUpdatingDates;

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

            InitializeReservationForm();
            SetupGrids();
            CarRentalService.EnsureDatabaseTables(out _);
            LoadAllData();
            UpdateClock();

            txtConnString.Text = CarRentalService.ConnectionString;
            if (cmbAddCategory.Items.Count > 0) cmbAddCategory.SelectedIndex = 0;
            if (cmbFleetFilter.Items.Count > 0) cmbFleetFilter.SelectedIndex = 0;
        }

        private void InitializeReservationForm()
        {
            ResetDates(dtpResPickupDate, dtpResReturnDate, numResDays);
            if (cmbResIdType.Items.Count > 0) cmbResIdType.SelectedIndex = 0;
            if (cmbResPickupLocation.Items.Count > 0) cmbResPickupLocation.SelectedIndex = 0;
            if (cmbResPaymentMethod.Items.Count > 0) cmbResPaymentMethod.SelectedIndex = 0;
        }

        private void ResetDates(DateTimePicker pickupPicker, DateTimePicker returnPicker, NumericUpDown daysInput)
        {
            _isUpdatingDates = true;
            try
            {
                DateTime today = DateTime.Today;
                pickupPicker.MinDate = today;
                pickupPicker.Value = today;
                daysInput.Value = 1;
                returnPicker.MinDate = today.AddDays(1);
                returnPicker.Value = today.AddDays((int)daysInput.Value);
            }
            finally
            {
                _isUpdatingDates = false;
            }
        }

        private void UpdateClock()
        {
            lblLiveClock.Text = DateTime.Now.ToString("dddd, MMM dd, yyyy  hh:mm:ss tt");
        }

        private void StyleGrid(DataGridView grid)
        {
            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(24, 30, 38);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(167, 243, 208);
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            grid.DefaultCellStyle.BackColor = Color.White;
            grid.DefaultCellStyle.ForeColor = Color.FromArgb(18, 22, 28);
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(209, 250, 229);
            grid.DefaultCellStyle.SelectionForeColor = Color.FromArgb(6, 78, 59);
            grid.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            grid.RowTemplate.Height = 32;
            grid.GridColor = Color.FromArgb(226, 232, 240);
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void SetupGrids()
        {
            StyleGrid(gridOverviewFleet);
            gridOverviewFleet.Columns.Clear();
            gridOverviewFleet.Columns.Add("Model", "Model");
            gridOverviewFleet.Columns.Add("Category", "Category");
            gridOverviewFleet.Columns.Add("Seaters", "Seaters");
            gridOverviewFleet.Columns.Add("Plate", "Plate Number");
            gridOverviewFleet.Columns.Add("Rate", "Daily Rate");
            gridOverviewFleet.Columns.Add("Status", "Status");

            StyleGrid(gridFleet);
            gridFleet.Columns.Clear();
            gridFleet.Columns.Add("Id", "ID");
            gridFleet.Columns.Add("Brand", "Brand");
            gridFleet.Columns.Add("Model", "Model");
            gridFleet.Columns.Add("Category", "Category");
            gridFleet.Columns.Add("Seaters", "Seaters");
            gridFleet.Columns.Add("Plate", "Plate No.");
            gridFleet.Columns.Add("Rate", "Daily Rate");
            gridFleet.Columns.Add("Status", "Status");

            StyleGrid(gridRentals);
            gridRentals.Columns.Clear();
            gridRentals.Columns.Add("RentalId", "Rental #");
            gridRentals.Columns.Add("Customer", "Customer Name");
            gridRentals.Columns.Add("Phone", "Phone");
            gridRentals.Columns.Add("IdType", "Valid ID");
            gridRentals.Columns.Add("Car", "Rented Vehicle");
            gridRentals.Columns.Add("RentDate", "Pick-up Date");
            gridRentals.Columns.Add("ReturnDate", "Return Date");
            gridRentals.Columns.Add("Days", "Days");
            gridRentals.Columns.Add("Cost", "Total Cost");
            gridRentals.Columns.Add("PickupLocation", "Pick-up Location");
            gridRentals.Columns.Add("PaymentMethod", "Payment");
            gridRentals.Columns.Add("Status", "Status");
        }

        public void LoadAllData()
        {
            UpdateStats();
            LoadOverviewFleet();
            RefreshCategoryDropdowns();
            LoadFleetGrid();
            LoadRentalsGrid();
            PopulateCarComboBox();
            RecalculateReservationCost();
        }

        private void RefreshCategoryDropdowns()
        {
            var cars = CarRentalService.GetCars();
            foreach (var c in cars)
            {
                if (!string.IsNullOrWhiteSpace(c.Category))
                {
                    if (!cmbFleetFilter.Items.Contains(c.Category))
                    {
                        cmbFleetFilter.Items.Add(c.Category);
                    }

                    if (!cmbAddCategory.Items.Contains(c.Category))
                    {
                        int otherIdx = cmbAddCategory.Items.IndexOf("Other");
                        if (otherIdx >= 0)
                            cmbAddCategory.Items.Insert(otherIdx, c.Category);
                        else
                            cmbAddCategory.Items.Add(c.Category);
                    }
                }
            }
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
                    c.Seaters + " Seaters",
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
                    c.Seaters + " Seaters",
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
                    r.IdType,
                    r.CarName,
                    r.RentDate.ToString("yyyy-MM-dd"),
                    r.ReturnDate.ToString("yyyy-MM-dd"),
                    r.TotalDays + " days",
                    "₱" + r.TotalCost.ToString("F2"),
                    r.PickupLocation,
                    r.PaymentMethod,
                    r.Status
                );

                if (r.Status == "Active")
                {
                    gridRentals.Rows[idx].Cells["Status"].Style.ForeColor = Color.OrangeRed;
                }
                else if (r.Status == "Reserved")
                {
                    gridRentals.Rows[idx].Cells["Status"].Style.ForeColor = Color.FromArgb(37, 99, 235); // blue for advance booking
                }
                else
                {
                    gridRentals.Rows[idx].Cells["Status"].Style.ForeColor = Color.Green;
                }
            }
        }

        private void PopulateCarComboBox()
        {
            var allCars = CarRentalService.GetAllCarsForBooking();

            cmbResCar.DataSource = null;
            cmbResCar.DisplayMember = "DisplayName";
            cmbResCar.ValueMember = "Id";
            cmbResCar.DataSource = allCars;

            int availCount = 0;
            int rentedCount = 0;
            foreach (var c in allCars)
            {
                if (c.Status == "Available") availCount++;
                else if (c.Status == "Rented") rentedCount++;
            }

            if (allCars.Count == 0)
            {
                btnResSubmit.Enabled = false;
                lblResFeedback.ForeColor = Color.OrangeRed;
                lblResFeedback.Text = "No vehicles found in database.";
            }
            else
            {
                btnResSubmit.Enabled = true;
                lblResFeedback.ForeColor = Color.Gray;
                lblResFeedback.Text = availCount + " available now · " + rentedCount + " currently rented (advance booking allowed for non-conflicting dates)";
            }
        }

        private void RecalculateReservationCost()
        {
            Car? selectedCar = cmbResCar.SelectedItem as Car;
            if (selectedCar != null)
            {
                int days = (int)numResDays.Value;
                decimal total = selectedCar.DailyRate * days;

                // Show advance booking warning if car is currently rented
                if (selectedCar.Status == "Rented")
                {
                    lblResVehicleSummary.Text = "⚠️ ADVANCE BOOKING — " + selectedCar.Brand + " " + selectedCar.Model + " (currently rented, pick non-conflicting dates)";
                }
                else
                {
                    lblResVehicleSummary.Text = selectedCar.Brand + " " + selectedCar.Model + " (" + selectedCar.Seaters + "-Seater)";
                }

                lblResScheduleSummary.Text = dtpResPickupDate.Value.ToString("MMM dd, yyyy") + " → " +
                    dtpResReturnDate.Value.ToString("MMM dd, yyyy") + " (" + days + " day/s @ ₱" + selectedCar.DailyRate.ToString("F2") + "/day)";
                lblResTotalAmount.Text = "₱" + total.ToString("F2");
            }
            else
            {
                lblResVehicleSummary.Text = "No available vehicle selected";
                lblResScheduleSummary.Text = "Select dates to calculate total";
                lblResTotalAmount.Text = "₱0.00";
            }
        }

        private void SyncDatesFromPickup(DateTimePicker pickupPicker, DateTimePicker returnPicker, NumericUpDown daysInput)
        {
            if (_isUpdatingDates) return;

            _isUpdatingDates = true;
            try
            {
                DateTime pickup = pickupPicker.Value.Date;
                returnPicker.MinDate = pickup.AddDays(1);

                int days = (returnPicker.Value.Date - pickup).Days;
                if (days < 1)
                {
                    days = (int)daysInput.Value;
                    returnPicker.Value = pickup.AddDays(days);
                }
                else if (days > (int)daysInput.Maximum)
                {
                    days = (int)daysInput.Maximum;
                    returnPicker.Value = pickup.AddDays(days);
                }

                daysInput.Value = days;
            }
            finally
            {
                _isUpdatingDates = false;
            }
        }

        private void SyncDatesFromReturn(DateTimePicker pickupPicker, DateTimePicker returnPicker, NumericUpDown daysInput)
        {
            if (_isUpdatingDates) return;

            _isUpdatingDates = true;
            try
            {
                DateTime pickup = pickupPicker.Value.Date;
                int days = (returnPicker.Value.Date - pickup).Days;

                if (days < 1)
                {
                    days = 1;
                    returnPicker.Value = pickup.AddDays(1);
                }
                else if (days > (int)daysInput.Maximum)
                {
                    days = (int)daysInput.Maximum;
                    returnPicker.Value = pickup.AddDays(days);
                }

                daysInput.Value = days;
            }
            finally
            {
                _isUpdatingDates = false;
            }
        }

        private void SyncDatesFromDays(DateTimePicker pickupPicker, DateTimePicker returnPicker, NumericUpDown daysInput)
        {
            if (_isUpdatingDates) return;

            _isUpdatingDates = true;
            try
            {
                DateTime pickup = pickupPicker.Value.Date;
                returnPicker.MinDate = pickup.AddDays(1);
                returnPicker.Value = pickup.AddDays((int)daysInput.Value);
            }
            finally
            {
                _isUpdatingDates = false;
            }
        }

        private void cmbResCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecalculateReservationCost();
        }

        private void dtpResPickupDate_ValueChanged(object sender, EventArgs e)
        {
            SyncDatesFromPickup(dtpResPickupDate, dtpResReturnDate, numResDays);
            RecalculateReservationCost();
        }

        private void dtpResReturnDate_ValueChanged(object sender, EventArgs e)
        {
            SyncDatesFromReturn(dtpResPickupDate, dtpResReturnDate, numResDays);
            RecalculateReservationCost();
        }

        private void numResDays_ValueChanged(object sender, EventArgs e)
        {
            SyncDatesFromDays(dtpResPickupDate, dtpResReturnDate, numResDays);
            RecalculateReservationCost();
        }

        private void ClearReservationForm()
        {
            txtResCustName.Clear();
            txtResPhone.Clear();
            txtResEmail.Clear();
            if (cmbResIdType.Items.Count > 0) cmbResIdType.SelectedIndex = 0;
            txtResAddress.Clear();
            txtResNotes.Clear();
            if (cmbResPickupLocation.Items.Count > 0) cmbResPickupLocation.SelectedIndex = 0;
            if (cmbResPaymentMethod.Items.Count > 0) cmbResPaymentMethod.SelectedIndex = 0;
            ResetDates(dtpResPickupDate, dtpResReturnDate, numResDays);
            RecalculateReservationCost();
        }

        private void btnResClear_Click(object sender, EventArgs e)
        {
            ClearReservationForm();
            lblResFeedback.ForeColor = Color.Gray;
            lblResFeedback.Text = "Form cleared. Ready for a new reservation.";
            txtResCustName.Focus();
        }

        private void btnResSubmit_Click(object sender, EventArgs e)
        {
            Car? selectedCar = cmbResCar.SelectedItem as Car;
            if (selectedCar == null)
            {
                MessageBox.Show("Please select an available vehicle first.", "Selection Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = txtResCustName.Text.Trim();
            string phone = txtResPhone.Text.Trim();
            string email = txtResEmail.Text.Trim();
            string idType = cmbResIdType.SelectedItem?.ToString() ?? "";
            string address = txtResAddress.Text.Trim();
            string pickupLocation = cmbResPickupLocation.SelectedItem?.ToString() ?? "Main Office (Showroom)";
            string paymentMethod = cmbResPaymentMethod.SelectedItem?.ToString() ?? "Cash";
            string notes = txtResNotes.Text.Trim();
            DateTime pickupDate = dtpResPickupDate.Value.Date;
            DateTime returnDate = dtpResReturnDate.Value.Date;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter the customer's full name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtResCustName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Please enter the customer's contact number.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtResPhone.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(idType))
            {
                MessageBox.Show("Please select a valid ID type.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbResIdType.Focus();
                return;
            }

            using (Terms_and_Conditons termsForm = new Terms_and_Conditons())
            {
                if (termsForm.ShowDialog(this) != DialogResult.OK)
                {
                    return;
                }
            }

            Rental? rental;
            string error;
            bool success = CarRentalService.BookCar(
                name, phone, email, idType, address,
                selectedCar.Id, pickupDate, returnDate,
                pickupLocation, paymentMethod, notes,
                out rental, out error);

            if (success && rental != null)
            {
                lblResFeedback.ForeColor = Color.Green;
                lblResFeedback.Text = "✔ Reservation #" + rental.RentalId + " saved in SQL Server for " + rental.CustomerName + "!";

                // Show different message for advance (future) vs immediate (today) booking
                string bookingType = rental.Status == "Reserved" ? "ADVANCE RESERVATION (Future Date)" : "ACTIVE BOOKING (Starts Today)";

                MessageBox.Show(
                    "Reservation Saved to SQL Database!\n\n" +
                    "Booking Type: " + bookingType + "\n" +
                    "Reservation ID: #" + rental.RentalId + "\n" +
                    "Customer: " + rental.CustomerName + "\n" +
                    "Valid ID: " + rental.IdType + "\n" +
                    "Vehicle: " + rental.CarName + "\n" +
                    "Pick-up: " + rental.RentDate.ToString("yyyy-MM-dd") + " (" + rental.PickupLocation + ")\n" +
                    "Return: " + rental.ReturnDate.ToString("yyyy-MM-dd") + " (" + rental.TotalDays + " days)\n" +
                    "Payment Method: " + rental.PaymentMethod + "\n" +
                    "Total Amount: ₱" + rental.TotalCost.ToString("F2"),
                    "Reservation Recorded", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearReservationForm();
                LoadAllData();
            }
            else
            {
                lblResFeedback.ForeColor = Color.Red;
                lblResFeedback.Text = "⚠️ Failed to save reservation: " + error;
                MessageBox.Show("Failed to save reservation in SQL database:\n" + error, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbAddCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isOther = cmbAddCategory.SelectedItem != null && cmbAddCategory.SelectedItem.ToString() == "Other";
            lblAddCustomCategory.Visible = isOther;
            txtAddCustomCategory.Visible = isOther;
            if (isOther)
            {
                txtAddCustomCategory.Focus();
            }
            else
            {
                txtAddCustomCategory.Clear();
            }
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            string brand = txtAddBrand.Text.Trim();
            string model = txtAddModel.Text.Trim();
            string cat = cmbAddCategory.SelectedItem != null ? cmbAddCategory.SelectedItem.ToString()! : "Sedan";
            if (cat == "Other")
            {
                cat = txtAddCustomCategory.Text.Trim();
                if (string.IsNullOrWhiteSpace(cat))
                {
                    MessageBox.Show("Please enter the new custom category name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAddCustomCategory.Focus();
                    return;
                }
            }

            string plate = txtAddPlate.Text.Trim();
            int seaters = (int)numAddSeaters.Value;
            decimal rate = numAddRate.Value;

            string err;
            if (CarRentalService.AddCar(brand, model, cat, plate, seaters, rate, out err))
            {
                MessageBox.Show("Vehicle '" + brand + " " + model + "' successfully saved into SQL Server (Cars table)!",
                    "Saved to Database", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtAddBrand.Clear();
                txtAddModel.Clear();
                txtAddPlate.Clear();
                txtAddCustomCategory.Clear();
                txtAddCustomCategory.Visible = false;
                lblAddCustomCategory.Visible = false;
                numAddSeaters.Value = 5;
                numAddRate.Value = 60;

                if (!cmbAddCategory.Items.Contains(cat))
                {
                    int otherIdx = cmbAddCategory.Items.IndexOf("Other");
                    if (otherIdx >= 0)
                        cmbAddCategory.Items.Insert(otherIdx, cat);
                    else
                        cmbAddCategory.Items.Add(cat);
                }

                if (!cmbFleetFilter.Items.Contains(cat))
                {
                    cmbFleetFilter.Items.Add(cat);
                }

                cmbAddCategory.SelectedItem = cat;

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
                MessageBox.Show("Please select an Active rental row to process the return.", "Selection Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string rawId = gridRentals.SelectedRows[0].Cells["RentalId"].Value?.ToString() ?? "";
            string cleanId = rawId.Replace("#", "").Trim();
            string currentStatus = gridRentals.SelectedRows[0].Cells["Status"].Value?.ToString() ?? "";

            if (currentStatus != "Active")
            {
                MessageBox.Show(
                    "Process Return is for Active rentals only.\n\n" +
                    "Selected row status: " + currentStatus + "\n\n" +
                    "• After check-in, use the blue '🚘 Assign to Next Reserved' button on the Returned row.\n" +
                    "• To activate a Reserved booking directly, select that Reserved row and use Assign to Next Reserved.",
                    "Wrong Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

        // After a return (or on a Reserved row), give the Available car to the next Reserved client
        private void btnActivatePickup_Click(object sender, EventArgs e)
        {
            if (gridRentals.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a Returned rental (the car that was just checked in) or a Reserved booking.",
                    "Selection Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string rawId = gridRentals.SelectedRows[0].Cells["RentalId"].Value?.ToString() ?? "";
            string cleanId = rawId.Replace("#", "").Trim();
            string currentStatus = gridRentals.SelectedRows[0].Cells["Status"].Value?.ToString() ?? "";
            string carName = gridRentals.SelectedRows[0].Cells["Car"].Value?.ToString() ?? "this vehicle";

            if (currentStatus == "Active")
            {
                MessageBox.Show(
                    "This rental is still Active.\n\n" +
                    "Use the orange '🔑 Process Return / Check-In' button first. After the car is Returned/Available, assign it to the next Reserved client.",
                    "Return Required First", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rentalId;
            if (!int.TryParse(cleanId, out rentalId))
                return;

            if (currentStatus == "Returned")
            {
                DialogResult confirm = MessageBox.Show(
                    "Assign " + carName + " (returned rental #" + rentalId + ") to the next Reserved client waiting for this vehicle?\n\n" +
                    "The reservation will become Active and the car will be marked Rented.",
                    "Assign Available Car",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes) return;

                string msg;
                if (CarRentalService.AssignReturnedCarToNextReservation(rentalId, out msg))
                {
                    MessageBox.Show(msg, "Assigned to Next Reserved Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllData();
                }
                else
                {
                    MessageBox.Show(msg, "Cannot Assign", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return;
            }

            if (currentStatus != "Reserved")
            {
                MessageBox.Show(
                    "Select a Returned rental to assign that Available car, or a Reserved booking to activate pickup.\n\n" +
                    "Selected row status: " + currentStatus,
                    "Wrong Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmReserved = MessageBox.Show(
                "Confirm that the car is ready for pickup and activate Reservation #" + rentalId + "?\n\n" +
                "This will mark the booking as ACTIVE and the vehicle as RENTED.",
                "Confirm Pickup Activation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmReserved != DialogResult.Yes) return;

            string activateMsg;
            if (CarRentalService.ActivateReservation(rentalId, out activateMsg))
            {
                MessageBox.Show(activateMsg, "Pickup Activated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllData();
            }
            else
            {
                MessageBox.Show(activateMsg, "Cannot Activate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ShowView(Panel targetPanel, string title, string subtitle, Button activeButton)
        {
            panelOverview.Visible = false;
            panelReservation.Visible = false;
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
                btn.BackColor = Color.FromArgb(18, 22, 28);
                btn.ForeColor = Color.FromArgb(175, 185, 200);
                btn.Font = new Font("Segoe UI", 9.5F);
            }

            activeButton.BackColor = Color.FromArgb(5, 150, 105);
            activeButton.ForeColor = Color.White;
            activeButton.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
        }

        private void btnNavOverview_Click(object sender, EventArgs e)
        {
            ShowView(panelOverview, "Command Center & Live Overview", "Real-time fleet readiness, revenue metrics, and unit inventory", btnNavOverview);
            LoadAllData();
        }

        private void btnNavBooking_Click(object sender, EventArgs e)
        {
            ShowView(panelReservation, "Client Reservation Gateway", "Schedule client rentals, verify IDs, and execute lease agreements", btnNavBooking);
            LoadAllData();
            txtResCustName.Focus();
        }

        private void btnNavFleet_Click(object sender, EventArgs e)
        {
            ShowView(panelFleet, "Fleet Inventory Directory", "Manage vehicle specifications, custom categories, rates, and fleet entries", btnNavFleet);
            LoadFleetGrid();
        }

        private void btnNavRentals_Click(object sender, EventArgs e)
        {
            ShowView(panelRentals, "Contract Registry & Active Rentals", "Review active client contracts, return states, and leasing history", btnNavRentals);
            LoadRentalsGrid();
        }

        private void btnNavDatabase_Click(object sender, EventArgs e)
        {
            ShowView(panelDatabase, "Database Infrastructure", "SQL Server connection telemetry, table diagnostics, and initialization scripts", btnNavDatabase);
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
        Seaters INT NOT NULL DEFAULT 5,
        DailyRate DECIMAL(18,2) NOT NULL,
        Status NVARCHAR(20) NOT NULL DEFAULT 'Available'
    );

    EXEC(N'
        INSERT INTO Cars (Brand, Model, Category, PlateNumber, Seaters, DailyRate, Status) VALUES
        (''Toyota'', ''Camry SE'', ''Sedan'', ''ABC-1234'', 5, 45.00, ''Available''),
        (''Honda'', ''CR-V Hybrid'', ''SUV'', ''CRV-5678'', 5, 65.00, ''Available''),
        (''Tesla'', ''Model 3 Long Range'', ''Electric'', ''TSL-9988'', 5, 85.00, ''Available''),
        (''Ford'', ''Mustang GT'', ''Sports'', ''MST-4040'', 4, 95.00, ''Available''),
        (''BMW'', ''330i M Sport'', ''Luxury'', ''BMW-3301'', 5, 110.00, ''Available''),
        (''Hyundai'', ''Tucson Ultimate'', ''SUV'', ''TUC-7721'', 5, 55.00, ''Available''),
        (''Nissan'', ''Altima SV'', ''Sedan'', ''NSN-3344'', 5, 42.00, ''Available''),
        (''Mercedes-Benz'', ''C300 Sedan'', ''Luxury'', ''MBZ-8899'', 5, 125.00, ''Available'');
    ');
END
ELSE IF COL_LENGTH('Cars', 'Seaters') IS NULL
BEGIN
    ALTER TABLE Cars ADD Seaters INT NOT NULL DEFAULT 5;
    EXEC(N'UPDATE Cars SET Seaters = 4 WHERE PlateNumber = ''MST-4040'';');
END
GO

-- 2. Create Rentals table if it does not exist
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Rentals')
BEGIN
    CREATE TABLE Rentals (
        RentalId INT IDENTITY(1001,1) PRIMARY KEY,
        CustomerName NVARCHAR(100) NOT NULL,
        CustomerPhone NVARCHAR(50) NOT NULL,
        CustomerEmail NVARCHAR(100) NULL,
        IdType NVARCHAR(50) NULL,
        CustomerAddress NVARCHAR(200) NULL,
        CarId INT NOT NULL,
        RentDate DATETIME NOT NULL DEFAULT GETDATE(),
        ReturnDate DATETIME NOT NULL,
        TotalDays INT NOT NULL,
        TotalCost DECIMAL(18,2) NOT NULL,
        PickupLocation NVARCHAR(100) NULL,
        PaymentMethod NVARCHAR(50) NULL,
        SpecialRequest NVARCHAR(300) NULL,
        Status NVARCHAR(20) NOT NULL DEFAULT 'Active',
        CONSTRAINT FK_Rentals_Cars FOREIGN KEY (CarId) REFERENCES Cars(CarId)
    );
END
ELSE
BEGIN
    IF COL_LENGTH('Rentals', 'CustomerEmail') IS NULL ALTER TABLE Rentals ADD CustomerEmail NVARCHAR(100) NULL;
    IF COL_LENGTH('Rentals', 'IdType') IS NULL ALTER TABLE Rentals ADD IdType NVARCHAR(50) NULL;
    IF COL_LENGTH('Rentals', 'CustomerAddress') IS NULL ALTER TABLE Rentals ADD CustomerAddress NVARCHAR(200) NULL;
    IF COL_LENGTH('Rentals', 'PickupLocation') IS NULL ALTER TABLE Rentals ADD PickupLocation NVARCHAR(100) NULL;
    IF COL_LENGTH('Rentals', 'PaymentMethod') IS NULL ALTER TABLE Rentals ADD PaymentMethod NVARCHAR(50) NULL;
    IF COL_LENGTH('Rentals', 'SpecialRequest') IS NULL ALTER TABLE Rentals ADD SpecialRequest NVARCHAR(300) NULL;
END
GO

-- 3. Verification query
SELECT * FROM Cars;
SELECT * FROM Rentals;
GO";
            txtDbLog.Text = script;
            MessageBox.Show("SQL script loaded into the console below! You can copy and execute it directly in SQL Server Management Studio (SSMS).", "SQL Script", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblStatRevenueVal_Click(object sender, EventArgs e) { }

        private void lblLiveClock_Click(object sender, EventArgs e)
        {

        }
    }
}
