namespace FinalsCode
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            sidebarPanel = new Panel();
            brandPanel = new Panel();
            lblLogo = new Label();
            lblBrandSub = new Label();
            btnNavOverview = new Button();
            btnNavBooking = new Button();
            btnNavFleet = new Button();
            btnNavRentals = new Button();
            btnNavDatabase = new Button();
            btnBack = new Button();
            topBarPanel = new Panel();
            lblPageTitle = new Label();
            lblPageSubtitle = new Label();
            lblLiveClock = new Label();
            lblStatusBadge = new Label();
            mainContainerPanel = new Panel();
            panelOverview = new Panel();
            overviewStatsLayout = new TableLayoutPanel();
            cardTotalCars = new Panel();
            lblStatTotalVal = new Label();
            lblStatTotalTitle = new Label();
            cardAvailCars = new Panel();
            lblStatAvailVal = new Label();
            lblStatAvailTitle = new Label();
            cardRentedCars = new Panel();
            lblStatRentedVal = new Label();
            lblStatRentedTitle = new Label();
            cardRevenue = new Panel();
            lblStatRevenueVal = new Label();
            lblStatRevenueTitle = new Label();
            overviewSplit = new TableLayoutPanel();
            bookingBoxPanel = new Panel();
            lblBookingTitle = new Label();
            lblBookingSub = new Label();
            lblCustName = new Label();
            txtCustName = new TextBox();
            lblCustPhone = new Label();
            txtCustPhone = new TextBox();
            lblSelectCar = new Label();
            cmbCars = new ComboBox();
            lblDays = new Label();
            numDays = new NumericUpDown();
            costSummaryPanel = new Panel();
            lblDailyRateNote = new Label();
            lblTotalCalculated = new Label();
            btnConfirmBooking = new Button();
            lblBookingFeedback = new Label();
            overviewFleetCard = new Panel();
            lblOverviewFleetTitle = new Label();
            gridOverviewFleet = new DataGridView();
            panelFleet = new Panel();
            fleetHeaderPanel = new Panel();
            lblFleetTitle = new Label();
            txtFleetSearch = new TextBox();
            cmbFleetFilter = new ComboBox();
            gridFleet = new DataGridView();
            addCarBox = new Panel();
            lblAddCarTitle = new Label();
            txtAddBrand = new TextBox();
            txtAddModel = new TextBox();
            cmbAddCategory = new ComboBox();
            txtAddPlate = new TextBox();
            numAddRate = new NumericUpDown();
            btnAddCar = new Button();
            panelRentals = new Panel();
            rentalsHeaderPanel = new Panel();
            lblRentalsTitle = new Label();
            btnReturnCar = new Button();
            gridRentals = new DataGridView();
            panelDatabase = new Panel();
            dbCard = new Panel();
            lblDbTitle = new Label();
            lblDbSub = new Label();
            txtConnString = new TextBox();
            btnTestDbInDash = new Button();
            btnGenerateSql = new Button();
            txtDbLog = new TextBox();
            sidebarPanel.SuspendLayout();
            brandPanel.SuspendLayout();
            topBarPanel.SuspendLayout();
            mainContainerPanel.SuspendLayout();
            panelOverview.SuspendLayout();
            overviewStatsLayout.SuspendLayout();
            cardTotalCars.SuspendLayout();
            cardAvailCars.SuspendLayout();
            cardRentedCars.SuspendLayout();
            cardRevenue.SuspendLayout();
            overviewSplit.SuspendLayout();
            bookingBoxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDays).BeginInit();
            costSummaryPanel.SuspendLayout();
            overviewFleetCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridOverviewFleet).BeginInit();
            panelFleet.SuspendLayout();
            fleetHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridFleet).BeginInit();
            addCarBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAddRate).BeginInit();
            panelRentals.SuspendLayout();
            rentalsHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridRentals).BeginInit();
            panelDatabase.SuspendLayout();
            dbCard.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.FromArgb(15, 23, 42);
            sidebarPanel.Controls.Add(btnBack);
            sidebarPanel.Controls.Add(btnNavDatabase);
            sidebarPanel.Controls.Add(btnNavRentals);
            sidebarPanel.Controls.Add(btnNavFleet);
            sidebarPanel.Controls.Add(btnNavBooking);
            sidebarPanel.Controls.Add(btnNavOverview);
            sidebarPanel.Controls.Add(brandPanel);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(230, 700);
            sidebarPanel.TabIndex = 0;
            // 
            // brandPanel
            // 
            brandPanel.BackColor = Color.FromArgb(10, 15, 30);
            brandPanel.Controls.Add(lblBrandSub);
            brandPanel.Controls.Add(lblLogo);
            brandPanel.Dock = DockStyle.Top;
            brandPanel.Location = new Point(0, 0);
            brandPanel.Name = "brandPanel";
            brandPanel.Padding = new Padding(18, 16, 18, 16);
            brandPanel.Size = new Size(230, 75);
            brandPanel.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(14, 14);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(130, 25);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "🚗 DriveHub";
            // 
            // lblBrandSub
            // 
            lblBrandSub.AutoSize = true;
            lblBrandSub.Font = new Font("Segoe UI Semibold", 7.5F, FontStyle.Bold);
            lblBrandSub.ForeColor = Color.FromArgb(96, 165, 250);
            lblBrandSub.Location = new Point(18, 42);
            lblBrandSub.Name = "lblBrandSub";
            lblBrandSub.Size = new Size(135, 12);
            lblBrandSub.TabIndex = 1;
            lblBrandSub.Text = "CAR RENTAL MANAGEMENT";
            // 
            // btnNavOverview
            // 
            btnNavOverview.BackColor = Color.FromArgb(37, 99, 235);
            btnNavOverview.Cursor = Cursors.Hand;
            btnNavOverview.FlatAppearance.BorderSize = 0;
            btnNavOverview.FlatStyle = FlatStyle.Flat;
            btnNavOverview.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnNavOverview.ForeColor = Color.White;
            btnNavOverview.Location = new Point(12, 95);
            btnNavOverview.Name = "btnNavOverview";
            btnNavOverview.Padding = new Padding(12, 0, 0, 0);
            btnNavOverview.Size = new Size(206, 44);
            btnNavOverview.TabIndex = 1;
            btnNavOverview.Text = "📊  Overview";
            btnNavOverview.TextAlign = ContentAlignment.MiddleLeft;
            btnNavOverview.UseVisualStyleBackColor = false;
            btnNavOverview.Click += btnNavOverview_Click;
            // 
            // btnNavBooking
            // 
            btnNavBooking.BackColor = Color.FromArgb(15, 23, 42);
            btnNavBooking.Cursor = Cursors.Hand;
            btnNavBooking.FlatAppearance.BorderSize = 0;
            btnNavBooking.FlatStyle = FlatStyle.Flat;
            btnNavBooking.Font = new Font("Segoe UI", 9.5F);
            btnNavBooking.ForeColor = Color.FromArgb(203, 213, 225);
            btnNavBooking.Location = new Point(12, 145);
            btnNavBooking.Name = "btnNavBooking";
            btnNavBooking.Padding = new Padding(12, 0, 0, 0);
            btnNavBooking.Size = new Size(206, 44);
            btnNavBooking.TabIndex = 2;
            btnNavBooking.Text = "📝  Quick Rent (Get Started)";
            btnNavBooking.TextAlign = ContentAlignment.MiddleLeft;
            btnNavBooking.UseVisualStyleBackColor = true;
            btnNavBooking.Click += btnNavBooking_Click;
            // 
            // btnNavFleet
            // 
            btnNavFleet.BackColor = Color.FromArgb(15, 23, 42);
            btnNavFleet.Cursor = Cursors.Hand;
            btnNavFleet.FlatAppearance.BorderSize = 0;
            btnNavFleet.FlatStyle = FlatStyle.Flat;
            btnNavFleet.Font = new Font("Segoe UI", 9.5F);
            btnNavFleet.ForeColor = Color.FromArgb(203, 213, 225);
            btnNavFleet.Location = new Point(12, 195);
            btnNavFleet.Name = "btnNavFleet";
            btnNavFleet.Padding = new Padding(12, 0, 0, 0);
            btnNavFleet.Size = new Size(206, 44);
            btnNavFleet.TabIndex = 3;
            btnNavFleet.Text = "🚘  Fleet Inventory";
            btnNavFleet.TextAlign = ContentAlignment.MiddleLeft;
            btnNavFleet.UseVisualStyleBackColor = true;
            btnNavFleet.Click += btnNavFleet_Click;
            // 
            // btnNavRentals
            // 
            btnNavRentals.BackColor = Color.FromArgb(15, 23, 42);
            btnNavRentals.Cursor = Cursors.Hand;
            btnNavRentals.FlatAppearance.BorderSize = 0;
            btnNavRentals.FlatStyle = FlatStyle.Flat;
            btnNavRentals.Font = new Font("Segoe UI", 9.5F);
            btnNavRentals.ForeColor = Color.FromArgb(203, 213, 225);
            btnNavRentals.Location = new Point(12, 245);
            btnNavRentals.Name = "btnNavRentals";
            btnNavRentals.Padding = new Padding(12, 0, 0, 0);
            btnNavRentals.Size = new Size(206, 44);
            btnNavRentals.TabIndex = 4;
            btnNavRentals.Text = "📋  Active Rentals";
            btnNavRentals.TextAlign = ContentAlignment.MiddleLeft;
            btnNavRentals.UseVisualStyleBackColor = true;
            btnNavRentals.Click += btnNavRentals_Click;
            // 
            // btnNavDatabase
            // 
            btnNavDatabase.BackColor = Color.FromArgb(15, 23, 42);
            btnNavDatabase.Cursor = Cursors.Hand;
            btnNavDatabase.FlatAppearance.BorderSize = 0;
            btnNavDatabase.FlatStyle = FlatStyle.Flat;
            btnNavDatabase.Font = new Font("Segoe UI", 9.5F);
            btnNavDatabase.ForeColor = Color.FromArgb(203, 213, 225);
            btnNavDatabase.Location = new Point(12, 295);
            btnNavDatabase.Name = "btnNavDatabase";
            btnNavDatabase.Padding = new Padding(12, 0, 0, 0);
            btnNavDatabase.Size = new Size(206, 44);
            btnNavDatabase.TabIndex = 5;
            btnNavDatabase.Text = "⚙️  SQL Database";
            btnNavDatabase.TextAlign = ContentAlignment.MiddleLeft;
            btnNavDatabase.UseVisualStyleBackColor = true;
            btnNavDatabase.Click += btnNavDatabase_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnBack.BackColor = Color.FromArgb(30, 41, 59);
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 9F);
            btnBack.ForeColor = Color.FromArgb(148, 163, 184);
            btnBack.Location = new Point(12, 642);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(206, 42);
            btnBack.TabIndex = 6;
            btnBack.Text = "⬅️  Back to Welcome";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // topBarPanel
            // 
            topBarPanel.BackColor = Color.White;
            topBarPanel.Controls.Add(lblStatusBadge);
            topBarPanel.Controls.Add(lblLiveClock);
            topBarPanel.Controls.Add(lblPageSubtitle);
            topBarPanel.Controls.Add(lblPageTitle);
            topBarPanel.Dock = DockStyle.Top;
            topBarPanel.Location = new Point(230, 0);
            topBarPanel.Name = "topBarPanel";
            topBarPanel.Padding = new Padding(24, 12, 24, 12);
            topBarPanel.Size = new Size(890, 75);
            topBarPanel.TabIndex = 1;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblPageTitle.Location = new Point(22, 14);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(187, 25);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Dashboard Overview";
            // 
            // lblPageSubtitle
            // 
            lblPageSubtitle.AutoSize = true;
            lblPageSubtitle.Font = new Font("Segoe UI", 9F);
            lblPageSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblPageSubtitle.Location = new Point(24, 42);
            lblPageSubtitle.Name = "lblPageSubtitle";
            lblPageSubtitle.Size = new Size(350, 15);
            lblPageSubtitle.TabIndex = 1;
            lblPageSubtitle.Text = "Real-time car fleet overview, instant reservations, and rental activity";
            // 
            // lblLiveClock
            // 
            lblLiveClock.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLiveClock.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblLiveClock.ForeColor = Color.FromArgb(71, 85, 105);
            lblLiveClock.Location = new Point(620, 14);
            lblLiveClock.Name = "lblLiveClock";
            lblLiveClock.Size = new Size(246, 22);
            lblLiveClock.TabIndex = 2;
            lblLiveClock.Text = "Live System";
            lblLiveClock.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblStatusBadge
            // 
            lblStatusBadge.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStatusBadge.AutoSize = true;
            lblStatusBadge.BackColor = Color.FromArgb(240, 253, 244);
            lblStatusBadge.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            lblStatusBadge.ForeColor = Color.FromArgb(22, 101, 52);
            lblStatusBadge.Location = new Point(748, 42);
            lblStatusBadge.Name = "lblStatusBadge";
            lblStatusBadge.Padding = new Padding(6, 3, 6, 3);
            lblStatusBadge.Size = new Size(118, 21);
            lblStatusBadge.TabIndex = 3;
            lblStatusBadge.Text = "🟢 System Online";
            // 
            // mainContainerPanel
            // 
            mainContainerPanel.BackColor = Color.FromArgb(241, 245, 249);
            mainContainerPanel.Controls.Add(panelOverview);
            mainContainerPanel.Controls.Add(panelFleet);
            mainContainerPanel.Controls.Add(panelRentals);
            mainContainerPanel.Controls.Add(panelDatabase);
            mainContainerPanel.Dock = DockStyle.Fill;
            mainContainerPanel.Location = new Point(230, 75);
            mainContainerPanel.Name = "mainContainerPanel";
            mainContainerPanel.Padding = new Padding(20);
            mainContainerPanel.Size = new Size(890, 625);
            mainContainerPanel.TabIndex = 2;
            // 
            // panelOverview
            // 
            panelOverview.Controls.Add(overviewSplit);
            panelOverview.Controls.Add(overviewStatsLayout);
            panelOverview.Dock = DockStyle.Fill;
            panelOverview.Location = new Point(20, 20);
            panelOverview.Name = "panelOverview";
            panelOverview.Size = new Size(850, 585);
            panelOverview.TabIndex = 0;
            // 
            // overviewStatsLayout
            // 
            overviewStatsLayout.ColumnCount = 4;
            overviewStatsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            overviewStatsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            overviewStatsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            overviewStatsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            overviewStatsLayout.Controls.Add(cardTotalCars, 0, 0);
            overviewStatsLayout.Controls.Add(cardAvailCars, 1, 0);
            overviewStatsLayout.Controls.Add(cardRentedCars, 2, 0);
            overviewStatsLayout.Controls.Add(cardRevenue, 3, 0);
            overviewStatsLayout.Dock = DockStyle.Top;
            overviewStatsLayout.Location = new Point(0, 0);
            overviewStatsLayout.Name = "overviewStatsLayout";
            overviewStatsLayout.RowCount = 1;
            overviewStatsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            overviewStatsLayout.Size = new Size(850, 95);
            overviewStatsLayout.TabIndex = 0;
            // 
            // cardTotalCars
            // 
            cardTotalCars.BackColor = Color.White;
            cardTotalCars.Controls.Add(lblStatTotalVal);
            cardTotalCars.Controls.Add(lblStatTotalTitle);
            cardTotalCars.Dock = DockStyle.Fill;
            cardTotalCars.Location = new Point(0, 0);
            cardTotalCars.Margin = new Padding(0, 0, 10, 0);
            cardTotalCars.Name = "cardTotalCars";
            cardTotalCars.Padding = new Padding(14);
            cardTotalCars.Size = new Size(202, 95);
            cardTotalCars.TabIndex = 0;
            // 
            // lblStatTotalTitle
            // 
            lblStatTotalTitle.AutoSize = true;
            lblStatTotalTitle.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            lblStatTotalTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblStatTotalTitle.Location = new Point(12, 14);
            lblStatTotalTitle.Name = "lblStatTotalTitle";
            lblStatTotalTitle.Size = new Size(76, 15);
            lblStatTotalTitle.TabIndex = 0;
            lblStatTotalTitle.Text = "TOTAL FLEET";
            // 
            // lblStatTotalVal
            // 
            lblStatTotalVal.AutoSize = true;
            lblStatTotalVal.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblStatTotalVal.ForeColor = Color.FromArgb(37, 99, 235);
            lblStatTotalVal.Location = new Point(10, 36);
            lblStatTotalVal.Name = "lblStatTotalVal";
            lblStatTotalVal.Size = new Size(95, 32);
            lblStatTotalVal.TabIndex = 1;
            lblStatTotalVal.Text = "8 Cars";
            // 
            // cardAvailCars
            // 
            cardAvailCars.BackColor = Color.White;
            cardAvailCars.Controls.Add(lblStatAvailVal);
            cardAvailCars.Controls.Add(lblStatAvailTitle);
            cardAvailCars.Dock = DockStyle.Fill;
            cardAvailCars.Location = new Point(212, 0);
            cardAvailCars.Margin = new Padding(0, 0, 10, 0);
            cardAvailCars.Name = "cardAvailCars";
            cardAvailCars.Padding = new Padding(14);
            cardAvailCars.Size = new Size(202, 95);
            cardAvailCars.TabIndex = 1;
            // 
            // lblStatAvailTitle
            // 
            lblStatAvailTitle.AutoSize = true;
            lblStatAvailTitle.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            lblStatAvailTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblStatAvailTitle.Location = new Point(12, 14);
            lblStatAvailTitle.Name = "lblStatAvailTitle";
            lblStatAvailTitle.Size = new Size(97, 15);
            lblStatAvailTitle.TabIndex = 0;
            lblStatAvailTitle.Text = "AVAILABLE NOW";
            // 
            // lblStatAvailVal
            // 
            lblStatAvailVal.AutoSize = true;
            lblStatAvailVal.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblStatAvailVal.ForeColor = Color.FromArgb(22, 163, 74);
            lblStatAvailVal.Location = new Point(10, 36);
            lblStatAvailVal.Name = "lblStatAvailVal";
            lblStatAvailVal.Size = new Size(95, 32);
            lblStatAvailVal.TabIndex = 1;
            lblStatAvailVal.Text = "6 Cars";
            // 
            // cardRentedCars
            // 
            cardRentedCars.BackColor = Color.White;
            cardRentedCars.Controls.Add(lblStatRentedVal);
            cardRentedCars.Controls.Add(lblStatRentedTitle);
            cardRentedCars.Dock = DockStyle.Fill;
            cardRentedCars.Location = new Point(424, 0);
            cardRentedCars.Margin = new Padding(0, 0, 10, 0);
            cardRentedCars.Name = "cardRentedCars";
            cardRentedCars.Padding = new Padding(14);
            cardRentedCars.Size = new Size(202, 95);
            cardRentedCars.TabIndex = 2;
            // 
            // lblStatRentedTitle
            // 
            lblStatRentedTitle.AutoSize = true;
            lblStatRentedTitle.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            lblStatRentedTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblStatRentedTitle.Location = new Point(12, 14);
            lblStatRentedTitle.Name = "lblStatRentedTitle";
            lblStatRentedTitle.Size = new Size(88, 15);
            lblStatRentedTitle.TabIndex = 0;
            lblStatRentedTitle.Text = "RENTED / OUT";
            // 
            // lblStatRentedVal
            // 
            lblStatRentedVal.AutoSize = true;
            lblStatRentedVal.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblStatRentedVal.ForeColor = Color.FromArgb(234, 88, 12);
            lblStatRentedVal.Location = new Point(10, 36);
            lblStatRentedVal.Name = "lblStatRentedVal";
            lblStatRentedVal.Size = new Size(95, 32);
            lblStatRentedVal.TabIndex = 1;
            lblStatRentedVal.Text = "2 Cars";
            // 
            // cardRevenue
            // 
            cardRevenue.BackColor = Color.White;
            cardRevenue.Controls.Add(lblStatRevenueVal);
            cardRevenue.Controls.Add(lblStatRevenueTitle);
            cardRevenue.Dock = DockStyle.Fill;
            cardRevenue.Location = new Point(636, 0);
            cardRevenue.Margin = new Padding(0);
            cardRevenue.Name = "cardRevenue";
            cardRevenue.Padding = new Padding(14);
            cardRevenue.Size = new Size(214, 95);
            cardRevenue.TabIndex = 3;
            // 
            // lblStatRevenueTitle
            // 
            lblStatRevenueTitle.AutoSize = true;
            lblStatRevenueTitle.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            lblStatRevenueTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblStatRevenueTitle.Location = new Point(12, 14);
            lblStatRevenueTitle.Name = "lblStatRevenueTitle";
            lblStatRevenueTitle.Size = new Size(96, 15);
            lblStatRevenueTitle.TabIndex = 0;
            lblStatRevenueTitle.Text = "TOTAL REVENUE";
            // 
            // lblStatRevenueVal
            // 
            lblStatRevenueVal.AutoSize = true;
            lblStatRevenueVal.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblStatRevenueVal.ForeColor = Color.FromArgb(124, 58, 237);
            lblStatRevenueVal.Location = new Point(10, 36);
            lblStatRevenueVal.Name = "lblStatRevenueVal";
            lblStatRevenueVal.Size = new Size(92, 32);
            lblStatRevenueVal.TabIndex = 1;
            lblStatRevenueVal.Text = "$940.00";
            // 
            // overviewSplit
            // 
            overviewSplit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            overviewSplit.ColumnCount = 2;
            overviewSplit.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 360F));
            overviewSplit.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            overviewSplit.Controls.Add(bookingBoxPanel, 0, 0);
            overviewSplit.Controls.Add(overviewFleetCard, 1, 0);
            overviewSplit.Location = new Point(0, 110);
            overviewSplit.Name = "overviewSplit";
            overviewSplit.RowCount = 1;
            overviewSplit.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            overviewSplit.Size = new Size(850, 475);
            overviewSplit.TabIndex = 1;
            // 
            // bookingBoxPanel
            // 
            bookingBoxPanel.BackColor = Color.White;
            bookingBoxPanel.Controls.Add(lblBookingFeedback);
            bookingBoxPanel.Controls.Add(btnConfirmBooking);
            bookingBoxPanel.Controls.Add(costSummaryPanel);
            bookingBoxPanel.Controls.Add(numDays);
            bookingBoxPanel.Controls.Add(lblDays);
            bookingBoxPanel.Controls.Add(cmbCars);
            bookingBoxPanel.Controls.Add(lblSelectCar);
            bookingBoxPanel.Controls.Add(txtCustPhone);
            bookingBoxPanel.Controls.Add(lblCustPhone);
            bookingBoxPanel.Controls.Add(txtCustName);
            bookingBoxPanel.Controls.Add(lblCustName);
            bookingBoxPanel.Controls.Add(lblBookingSub);
            bookingBoxPanel.Controls.Add(lblBookingTitle);
            bookingBoxPanel.Dock = DockStyle.Fill;
            bookingBoxPanel.Location = new Point(0, 0);
            bookingBoxPanel.Margin = new Padding(0, 0, 14, 0);
            bookingBoxPanel.Name = "bookingBoxPanel";
            bookingBoxPanel.Padding = new Padding(18);
            bookingBoxPanel.Size = new Size(346, 475);
            bookingBoxPanel.TabIndex = 0;
            // 
            // lblBookingTitle
            // 
            lblBookingTitle.AutoSize = true;
            lblBookingTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBookingTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblBookingTitle.Location = new Point(14, 14);
            lblBookingTitle.Name = "lblBookingTitle";
            lblBookingTitle.Size = new Size(230, 21);
            lblBookingTitle.TabIndex = 0;
            lblBookingTitle.Text = "⚡ Quick Rent (Get Started)";
            // 
            // lblBookingSub
            // 
            lblBookingSub.AutoSize = true;
            lblBookingSub.Font = new Font("Segoe UI", 8.5F);
            lblBookingSub.ForeColor = Color.FromArgb(100, 116, 139);
            lblBookingSub.Location = new Point(16, 38);
            lblBookingSub.Name = "lblBookingSub";
            lblBookingSub.Size = new Size(207, 15);
            lblBookingSub.TabIndex = 1;
            lblBookingSub.Text = "Complete a customer rental in seconds";
            // 
            // lblCustName
            // 
            lblCustName.AutoSize = true;
            lblCustName.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            lblCustName.ForeColor = Color.FromArgb(51, 65, 85);
            lblCustName.Location = new Point(16, 64);
            lblCustName.Name = "lblCustName";
            lblCustName.Size = new Size(96, 15);
            lblCustName.TabIndex = 2;
            lblCustName.Text = "Customer Name *";
            // 
            // txtCustName
            // 
            txtCustName.Font = new Font("Segoe UI", 9.5F);
            txtCustName.Location = new Point(18, 83);
            txtCustName.Name = "txtCustName";
            txtCustName.PlaceholderText = "e.g. Alex Johnson";
            txtCustName.Size = new Size(308, 24);
            txtCustName.TabIndex = 3;
            // 
            // lblCustPhone
            // 
            lblCustPhone.AutoSize = true;
            lblCustPhone.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            lblCustPhone.ForeColor = Color.FromArgb(51, 65, 85);
            lblCustPhone.Location = new Point(16, 114);
            lblCustPhone.Name = "lblCustPhone";
            lblCustPhone.Size = new Size(95, 15);
            lblCustPhone.TabIndex = 4;
            lblCustPhone.Text = "Phone Number *";
            // 
            // txtCustPhone
            // 
            txtCustPhone.Font = new Font("Segoe UI", 9.5F);
            txtCustPhone.Location = new Point(18, 133);
            txtCustPhone.Name = "txtCustPhone";
            txtCustPhone.PlaceholderText = "e.g. 0917-123-4567";
            txtCustPhone.Size = new Size(308, 24);
            txtCustPhone.TabIndex = 5;
            // 
            // lblSelectCar
            // 
            lblSelectCar.AutoSize = true;
            lblSelectCar.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            lblSelectCar.ForeColor = Color.FromArgb(51, 65, 85);
            lblSelectCar.Location = new Point(16, 166);
            lblSelectCar.Name = "lblSelectCar";
            lblSelectCar.Size = new Size(89, 15);
            lblSelectCar.TabIndex = 6;
            lblSelectCar.Text = "Select Vehicle *";
            // 
            // cmbCars
            // 
            cmbCars.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCars.Font = new Font("Segoe UI", 9.5F);
            cmbCars.FormattingEnabled = true;
            cmbCars.Location = new Point(18, 185);
            cmbCars.Name = "cmbCars";
            cmbCars.Size = new Size(308, 25);
            cmbCars.TabIndex = 7;
            cmbCars.SelectedIndexChanged += cmbCars_SelectedIndexChanged;
            // 
            // lblDays
            // 
            lblDays.AutoSize = true;
            lblDays.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            lblDays.ForeColor = Color.FromArgb(51, 65, 85);
            lblDays.Location = new Point(16, 220);
            lblDays.Name = "lblDays";
            lblDays.Size = new Size(130, 15);
            lblDays.TabIndex = 8;
            lblDays.Text = "Rental Duration (Days) *";
            // 
            // numDays
            // 
            numDays.Font = new Font("Segoe UI", 9.5F);
            numDays.Location = new Point(18, 239);
            numDays.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            numDays.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numDays.Name = "numDays";
            numDays.Size = new Size(140, 24);
            numDays.TabIndex = 9;
            numDays.Value = new decimal(new int[] { 3, 0, 0, 0 });
            numDays.ValueChanged += numDays_ValueChanged;
            // 
            // costSummaryPanel
            // 
            costSummaryPanel.BackColor = Color.FromArgb(248, 250, 252);
            costSummaryPanel.BorderStyle = BorderStyle.FixedSingle;
            costSummaryPanel.Controls.Add(lblTotalCalculated);
            costSummaryPanel.Controls.Add(lblDailyRateNote);
            costSummaryPanel.Location = new Point(18, 275);
            costSummaryPanel.Name = "costSummaryPanel";
            costSummaryPanel.Padding = new Padding(10);
            costSummaryPanel.Size = new Size(308, 64);
            costSummaryPanel.TabIndex = 10;
            // 
            // lblDailyRateNote
            // 
            lblDailyRateNote.AutoSize = true;
            lblDailyRateNote.Font = new Font("Segoe UI", 8.5F);
            lblDailyRateNote.ForeColor = Color.FromArgb(100, 116, 139);
            lblDailyRateNote.Location = new Point(8, 8);
            lblDailyRateNote.Name = "lblDailyRateNote";
            lblDailyRateNote.Size = new Size(116, 15);
            lblDailyRateNote.TabIndex = 0;
            lblDailyRateNote.Text = "Estimated Total (3d):";
            // 
            // lblTotalCalculated
            // 
            lblTotalCalculated.AutoSize = true;
            lblTotalCalculated.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotalCalculated.ForeColor = Color.FromArgb(22, 163, 74);
            lblTotalCalculated.Location = new Point(8, 28);
            lblTotalCalculated.Name = "lblTotalCalculated";
            lblTotalCalculated.Size = new Size(81, 25);
            lblTotalCalculated.TabIndex = 1;
            lblTotalCalculated.Text = "$135.00";
            // 
            // btnConfirmBooking
            // 
            btnConfirmBooking.BackColor = Color.FromArgb(37, 99, 235);
            btnConfirmBooking.Cursor = Cursors.Hand;
            btnConfirmBooking.FlatAppearance.BorderSize = 0;
            btnConfirmBooking.FlatStyle = FlatStyle.Flat;
            btnConfirmBooking.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            btnConfirmBooking.ForeColor = Color.White;
            btnConfirmBooking.Location = new Point(18, 350);
            btnConfirmBooking.Name = "btnConfirmBooking";
            btnConfirmBooking.Size = new Size(308, 44);
            btnConfirmBooking.TabIndex = 11;
            btnConfirmBooking.Text = "🚀 Confirm Rental Booking";
            btnConfirmBooking.UseVisualStyleBackColor = false;
            btnConfirmBooking.Click += btnConfirmBooking_Click;
            // 
            // lblBookingFeedback
            // 
            lblBookingFeedback.Font = new Font("Segoe UI", 8.5F);
            lblBookingFeedback.ForeColor = Color.FromArgb(100, 116, 139);
            lblBookingFeedback.Location = new Point(18, 405);
            lblBookingFeedback.Name = "lblBookingFeedback";
            lblBookingFeedback.Size = new Size(308, 55);
            lblBookingFeedback.TabIndex = 12;
            lblBookingFeedback.Text = "Select a vehicle and click Confirm to record rental.";
            // 
            // overviewFleetCard
            // 
            overviewFleetCard.BackColor = Color.White;
            overviewFleetCard.Controls.Add(gridOverviewFleet);
            overviewFleetCard.Controls.Add(lblOverviewFleetTitle);
            overviewFleetCard.Dock = DockStyle.Fill;
            overviewFleetCard.Location = new Point(360, 0);
            overviewFleetCard.Margin = new Padding(0);
            overviewFleetCard.Name = "overviewFleetCard";
            overviewFleetCard.Padding = new Padding(16);
            overviewFleetCard.Size = new Size(490, 475);
            overviewFleetCard.TabIndex = 1;
            // 
            // lblOverviewFleetTitle
            // 
            lblOverviewFleetTitle.AutoSize = true;
            lblOverviewFleetTitle.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            lblOverviewFleetTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblOverviewFleetTitle.Location = new Point(14, 14);
            lblOverviewFleetTitle.Name = "lblOverviewFleetTitle";
            lblOverviewFleetTitle.Size = new Size(205, 21);
            lblOverviewFleetTitle.TabIndex = 0;
            lblOverviewFleetTitle.Text = "🚘 Ready Available Fleet";
            // 
            // gridOverviewFleet
            // 
            gridOverviewFleet.AllowUserToAddRows = false;
            gridOverviewFleet.AllowUserToDeleteRows = false;
            gridOverviewFleet.AllowUserToResizeRows = false;
            gridOverviewFleet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridOverviewFleet.BackgroundColor = Color.White;
            gridOverviewFleet.BorderStyle = BorderStyle.None;
            gridOverviewFleet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridOverviewFleet.Location = new Point(14, 46);
            gridOverviewFleet.Name = "gridOverviewFleet";
            gridOverviewFleet.ReadOnly = true;
            gridOverviewFleet.RowHeadersVisible = false;
            gridOverviewFleet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridOverviewFleet.Size = new Size(462, 413);
            gridOverviewFleet.TabIndex = 1;
            // 
            // panelFleet
            // 
            panelFleet.Controls.Add(gridFleet);
            panelFleet.Controls.Add(addCarBox);
            panelFleet.Controls.Add(fleetHeaderPanel);
            panelFleet.Dock = DockStyle.Fill;
            panelFleet.Location = new Point(20, 20);
            panelFleet.Name = "panelFleet";
            panelFleet.Size = new Size(850, 585);
            panelFleet.TabIndex = 1;
            panelFleet.Visible = false;
            // 
            // fleetHeaderPanel
            // 
            fleetHeaderPanel.BackColor = Color.White;
            fleetHeaderPanel.Controls.Add(cmbFleetFilter);
            fleetHeaderPanel.Controls.Add(txtFleetSearch);
            fleetHeaderPanel.Controls.Add(lblFleetTitle);
            fleetHeaderPanel.Dock = DockStyle.Top;
            fleetHeaderPanel.Location = new Point(0, 0);
            fleetHeaderPanel.Name = "fleetHeaderPanel";
            fleetHeaderPanel.Padding = new Padding(14);
            fleetHeaderPanel.Size = new Size(850, 60);
            fleetHeaderPanel.TabIndex = 0;
            // 
            // lblFleetTitle
            // 
            lblFleetTitle.AutoSize = true;
            lblFleetTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFleetTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblFleetTitle.Location = new Point(14, 18);
            lblFleetTitle.Name = "lblFleetTitle";
            lblFleetTitle.Size = new Size(157, 21);
            lblFleetTitle.TabIndex = 0;
            lblFleetTitle.Text = "🚘 Fleet Inventory";
            // 
            // txtFleetSearch
            // 
            txtFleetSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFleetSearch.Font = new Font("Segoe UI", 9.5F);
            txtFleetSearch.Location = new Point(480, 16);
            txtFleetSearch.Name = "txtFleetSearch";
            txtFleetSearch.PlaceholderText = "🔍 Search brand or model...";
            txtFleetSearch.Size = new Size(190, 24);
            txtFleetSearch.TabIndex = 1;
            txtFleetSearch.TextChanged += txtFleetSearch_TextChanged;
            // 
            // cmbFleetFilter
            // 
            cmbFleetFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbFleetFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFleetFilter.Font = new Font("Segoe UI", 9.5F);
            cmbFleetFilter.FormattingEnabled = true;
            cmbFleetFilter.Items.AddRange(new object[] { "All Categories", "Sedan", "SUV", "Luxury", "Sports", "Electric" });
            cmbFleetFilter.Location = new Point(680, 16);
            cmbFleetFilter.Name = "cmbFleetFilter";
            cmbFleetFilter.Size = new Size(150, 25);
            cmbFleetFilter.TabIndex = 2;
            cmbFleetFilter.SelectedIndexChanged += cmbFleetFilter_SelectedIndexChanged;
            // 
            // gridFleet
            // 
            gridFleet.AllowUserToAddRows = false;
            gridFleet.AllowUserToDeleteRows = false;
            gridFleet.AllowUserToResizeRows = false;
            gridFleet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridFleet.BackgroundColor = Color.White;
            gridFleet.BorderStyle = BorderStyle.None;
            gridFleet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridFleet.Location = new Point(0, 72);
            gridFleet.Name = "gridFleet";
            gridFleet.ReadOnly = true;
            gridFleet.RowHeadersVisible = false;
            gridFleet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridFleet.Size = new Size(850, 370);
            gridFleet.TabIndex = 1;
            // 
            // addCarBox
            // 
            addCarBox.BackColor = Color.White;
            addCarBox.Controls.Add(btnAddCar);
            addCarBox.Controls.Add(numAddRate);
            addCarBox.Controls.Add(txtAddPlate);
            addCarBox.Controls.Add(cmbAddCategory);
            addCarBox.Controls.Add(txtAddModel);
            addCarBox.Controls.Add(txtAddBrand);
            addCarBox.Controls.Add(lblAddCarTitle);
            addCarBox.Dock = DockStyle.Bottom;
            addCarBox.Location = new Point(0, 455);
            addCarBox.Name = "addCarBox";
            addCarBox.Padding = new Padding(16);
            addCarBox.Size = new Size(850, 130);
            addCarBox.TabIndex = 2;
            // 
            // lblAddCarTitle
            // 
            lblAddCarTitle.AutoSize = true;
            lblAddCarTitle.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblAddCarTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblAddCarTitle.Location = new Point(14, 12);
            lblAddCarTitle.Name = "lblAddCarTitle";
            lblAddCarTitle.Size = new Size(183, 19);
            lblAddCarTitle.TabIndex = 0;
            lblAddCarTitle.Text = "➕ Add New Vehicle to Fleet";
            // 
            // txtAddBrand
            // 
            txtAddBrand.Font = new Font("Segoe UI", 9.5F);
            txtAddBrand.Location = new Point(16, 42);
            txtAddBrand.Name = "txtAddBrand";
            txtAddBrand.PlaceholderText = "Brand (e.g. Toyota)";
            txtAddBrand.Size = new Size(150, 24);
            txtAddBrand.TabIndex = 1;
            // 
            // txtAddModel
            // 
            txtAddModel.Font = new Font("Segoe UI", 9.5F);
            txtAddModel.Location = new Point(176, 42);
            txtAddModel.Name = "txtAddModel";
            txtAddModel.PlaceholderText = "Model (e.g. RAV4)";
            txtAddModel.Size = new Size(160, 24);
            txtAddModel.TabIndex = 2;
            // 
            // cmbAddCategory
            // 
            cmbAddCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAddCategory.Font = new Font("Segoe UI", 9.5F);
            cmbAddCategory.FormattingEnabled = true;
            cmbAddCategory.Items.AddRange(new object[] { "Sedan", "SUV", "Luxury", "Sports", "Electric" });
            cmbAddCategory.Location = new Point(346, 42);
            cmbAddCategory.Name = "cmbAddCategory";
            cmbAddCategory.Size = new Size(130, 25);
            cmbAddCategory.TabIndex = 3;
            // 
            // txtAddPlate
            // 
            txtAddPlate.Font = new Font("Segoe UI", 9.5F);
            txtAddPlate.Location = new Point(486, 42);
            txtAddPlate.Name = "txtAddPlate";
            txtAddPlate.PlaceholderText = "Plate (e.g. XYZ-9988)";
            txtAddPlate.Size = new Size(140, 24);
            txtAddPlate.TabIndex = 4;
            // 
            // numAddRate
            // 
            numAddRate.DecimalPlaces = 2;
            numAddRate.Font = new Font("Segoe UI", 9.5F);
            numAddRate.Location = new Point(636, 42);
            numAddRate.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            numAddRate.Name = "numAddRate";
            numAddRate.Size = new Size(95, 24);
            numAddRate.TabIndex = 5;
            numAddRate.Value = new decimal(new int[] { 60, 0, 0, 0 });
            // 
            // btnAddCar
            // 
            btnAddCar.BackColor = Color.FromArgb(22, 163, 74);
            btnAddCar.Cursor = Cursors.Hand;
            btnAddCar.FlatAppearance.BorderSize = 0;
            btnAddCar.FlatStyle = FlatStyle.Flat;
            btnAddCar.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnAddCar.ForeColor = Color.White;
            btnAddCar.Location = new Point(16, 80);
            btnAddCar.Name = "btnAddCar";
            btnAddCar.Size = new Size(160, 34);
            btnAddCar.TabIndex = 6;
            btnAddCar.Text = "Save Vehicle";
            btnAddCar.UseVisualStyleBackColor = false;
            btnAddCar.Click += btnAddCar_Click;
            // 
            // panelRentals
            // 
            panelRentals.Controls.Add(gridRentals);
            panelRentals.Controls.Add(rentalsHeaderPanel);
            panelRentals.Dock = DockStyle.Fill;
            panelRentals.Location = new Point(20, 20);
            panelRentals.Name = "panelRentals";
            panelRentals.Size = new Size(850, 585);
            panelRentals.TabIndex = 2;
            panelRentals.Visible = false;
            // 
            // rentalsHeaderPanel
            // 
            rentalsHeaderPanel.BackColor = Color.White;
            rentalsHeaderPanel.Controls.Add(btnReturnCar);
            rentalsHeaderPanel.Controls.Add(lblRentalsTitle);
            rentalsHeaderPanel.Dock = DockStyle.Top;
            rentalsHeaderPanel.Location = new Point(0, 0);
            rentalsHeaderPanel.Name = "rentalsHeaderPanel";
            rentalsHeaderPanel.Padding = new Padding(14);
            rentalsHeaderPanel.Size = new Size(850, 60);
            rentalsHeaderPanel.TabIndex = 0;
            // 
            // lblRentalsTitle
            // 
            lblRentalsTitle.AutoSize = true;
            lblRentalsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRentalsTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblRentalsTitle.Location = new Point(14, 18);
            lblRentalsTitle.Name = "lblRentalsTitle";
            lblRentalsTitle.Size = new Size(207, 21);
            lblRentalsTitle.TabIndex = 0;
            lblRentalsTitle.Text = "📋 Active & Recent Rentals";
            // 
            // btnReturnCar
            // 
            btnReturnCar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReturnCar.BackColor = Color.FromArgb(234, 88, 12);
            btnReturnCar.Cursor = Cursors.Hand;
            btnReturnCar.FlatAppearance.BorderSize = 0;
            btnReturnCar.FlatStyle = FlatStyle.Flat;
            btnReturnCar.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnReturnCar.ForeColor = Color.White;
            btnReturnCar.Location = new Point(660, 12);
            btnReturnCar.Name = "btnReturnCar";
            btnReturnCar.Size = new Size(170, 36);
            btnReturnCar.TabIndex = 1;
            btnReturnCar.Text = "🔑 Mark as Returned";
            btnReturnCar.UseVisualStyleBackColor = false;
            btnReturnCar.Click += btnReturnCar_Click;
            // 
            // gridRentals
            // 
            gridRentals.AllowUserToAddRows = false;
            gridRentals.AllowUserToDeleteRows = false;
            gridRentals.AllowUserToResizeRows = false;
            gridRentals.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridRentals.BackgroundColor = Color.White;
            gridRentals.BorderStyle = BorderStyle.None;
            gridRentals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridRentals.Location = new Point(0, 72);
            gridRentals.Name = "gridRentals";
            gridRentals.ReadOnly = true;
            gridRentals.RowHeadersVisible = false;
            gridRentals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridRentals.Size = new Size(850, 513);
            gridRentals.TabIndex = 1;
            // 
            // panelDatabase
            // 
            panelDatabase.Controls.Add(dbCard);
            panelDatabase.Dock = DockStyle.Fill;
            panelDatabase.Location = new Point(20, 20);
            panelDatabase.Name = "panelDatabase";
            panelDatabase.Size = new Size(850, 585);
            panelDatabase.TabIndex = 3;
            panelDatabase.Visible = false;
            // 
            // dbCard
            // 
            dbCard.BackColor = Color.White;
            dbCard.Controls.Add(txtDbLog);
            dbCard.Controls.Add(btnGenerateSql);
            dbCard.Controls.Add(btnTestDbInDash);
            dbCard.Controls.Add(txtConnString);
            dbCard.Controls.Add(lblDbSub);
            dbCard.Controls.Add(lblDbTitle);
            dbCard.Dock = DockStyle.Fill;
            dbCard.Location = new Point(0, 0);
            dbCard.Name = "dbCard";
            dbCard.Padding = new Padding(24);
            dbCard.Size = new Size(850, 585);
            dbCard.TabIndex = 0;
            // 
            // lblDbTitle
            // 
            lblDbTitle.AutoSize = true;
            lblDbTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblDbTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblDbTitle.Location = new Point(20, 18);
            lblDbTitle.Name = "lblDbTitle";
            lblDbTitle.Size = new Size(295, 25);
            lblDbTitle.TabIndex = 0;
            lblDbTitle.Text = "⚙️ SQL Server Database Settings";
            // 
            // lblDbSub
            // 
            lblDbSub.AutoSize = true;
            lblDbSub.Font = new Font("Segoe UI", 9F);
            lblDbSub.ForeColor = Color.FromArgb(100, 116, 139);
            lblDbSub.Location = new Point(22, 46);
            lblDbSub.Name = "lblDbSub";
            lblDbSub.Size = new Size(420, 15);
            lblDbSub.TabIndex = 1;
            lblDbSub.Text = "Configure connection to your SQL Server (e.g. RIAMU\\SQLEXPRESS - CarRentalDB)";
            // 
            // txtConnString
            // 
            txtConnString.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtConnString.Font = new Font("Consolas", 9.5F);
            txtConnString.Location = new Point(24, 76);
            txtConnString.Name = "txtConnString";
            txtConnString.Size = new Size(800, 22);
            txtConnString.TabIndex = 2;
            // 
            // btnTestDbInDash
            // 
            btnTestDbInDash.BackColor = Color.FromArgb(37, 99, 235);
            btnTestDbInDash.Cursor = Cursors.Hand;
            btnTestDbInDash.FlatAppearance.BorderSize = 0;
            btnTestDbInDash.FlatStyle = FlatStyle.Flat;
            btnTestDbInDash.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnTestDbInDash.ForeColor = Color.White;
            btnTestDbInDash.Location = new Point(24, 112);
            btnTestDbInDash.Name = "btnTestDbInDash";
            btnTestDbInDash.Size = new Size(180, 36);
            btnTestDbInDash.TabIndex = 3;
            btnTestDbInDash.Text = "🔌 Test Connection";
            btnTestDbInDash.UseVisualStyleBackColor = false;
            btnTestDbInDash.Click += btnTestDbInDash_Click;
            // 
            // btnGenerateSql
            // 
            btnGenerateSql.BackColor = Color.FromArgb(15, 23, 42);
            btnGenerateSql.Cursor = Cursors.Hand;
            btnGenerateSql.FlatAppearance.BorderSize = 0;
            btnGenerateSql.FlatStyle = FlatStyle.Flat;
            btnGenerateSql.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnGenerateSql.ForeColor = Color.White;
            btnGenerateSql.Location = new Point(216, 112);
            btnGenerateSql.Name = "btnGenerateSql";
            btnGenerateSql.Size = new Size(210, 36);
            btnGenerateSql.TabIndex = 4;
            btnGenerateSql.Text = "📋 Show Recommended SQL Script";
            btnGenerateSql.UseVisualStyleBackColor = false;
            btnGenerateSql.Click += btnGenerateSql_Click;
            // 
            // txtDbLog
            // 
            txtDbLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDbLog.BackColor = Color.FromArgb(15, 23, 42);
            txtDbLog.Font = new Font("Consolas", 9.5F);
            txtDbLog.ForeColor = Color.FromArgb(226, 232, 240);
            txtDbLog.Location = new Point(24, 160);
            txtDbLog.Multiline = true;
            txtDbLog.Name = "txtDbLog";
            txtDbLog.ReadOnly = true;
            txtDbLog.ScrollBars = ScrollBars.Vertical;
            txtDbLog.Size = new Size(800, 390);
            txtDbLog.TabIndex = 5;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 700);
            Controls.Add(mainContainerPanel);
            Controls.Add(topBarPanel);
            Controls.Add(sidebarPanel);
            MinimumSize = new Size(1000, 650);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DriveHub - Car Rental Dashboard";
            sidebarPanel.ResumeLayout(false);
            brandPanel.ResumeLayout(false);
            brandPanel.PerformLayout();
            topBarPanel.ResumeLayout(false);
            topBarPanel.PerformLayout();
            mainContainerPanel.ResumeLayout(false);
            panelOverview.ResumeLayout(false);
            overviewStatsLayout.ResumeLayout(false);
            cardTotalCars.ResumeLayout(false);
            cardTotalCars.PerformLayout();
            cardAvailCars.ResumeLayout(false);
            cardAvailCars.PerformLayout();
            cardRentedCars.ResumeLayout(false);
            cardRentedCars.PerformLayout();
            cardRevenue.ResumeLayout(false);
            cardRevenue.PerformLayout();
            overviewSplit.ResumeLayout(false);
            bookingBoxPanel.ResumeLayout(false);
            bookingBoxPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDays).EndInit();
            costSummaryPanel.ResumeLayout(false);
            costSummaryPanel.PerformLayout();
            overviewFleetCard.ResumeLayout(false);
            overviewFleetCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridOverviewFleet).EndInit();
            panelFleet.ResumeLayout(false);
            fleetHeaderPanel.ResumeLayout(false);
            fleetHeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridFleet).EndInit();
            addCarBox.ResumeLayout(false);
            addCarBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAddRate).EndInit();
            panelRentals.ResumeLayout(false);
            rentalsHeaderPanel.ResumeLayout(false);
            rentalsHeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridRentals).EndInit();
            panelDatabase.ResumeLayout(false);
            dbCard.ResumeLayout(false);
            dbCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidebarPanel;
        private Panel brandPanel;
        private Label lblLogo;
        private Label lblBrandSub;
        private Button btnNavOverview;
        private Button btnNavBooking;
        private Button btnNavFleet;
        private Button btnNavRentals;
        private Button btnNavDatabase;
        private Button btnBack;
        private Panel topBarPanel;
        private Label lblPageTitle;
        private Label lblPageSubtitle;
        private Label lblLiveClock;
        private Label lblStatusBadge;
        private Panel mainContainerPanel;
        private Panel panelOverview;
        private TableLayoutPanel overviewStatsLayout;
        private Panel cardTotalCars;
        private Label lblStatTotalTitle;
        private Label lblStatTotalVal;
        private Panel cardAvailCars;
        private Label lblStatAvailTitle;
        private Label lblStatAvailVal;
        private Panel cardRentedCars;
        private Label lblStatRentedTitle;
        private Label lblStatRentedVal;
        private Panel cardRevenue;
        private Label lblStatRevenueTitle;
        private Label lblStatRevenueVal;
        private TableLayoutPanel overviewSplit;
        private Panel bookingBoxPanel;
        private Label lblBookingTitle;
        private Label lblBookingSub;
        private Label lblCustName;
        private TextBox txtCustName;
        private Label lblCustPhone;
        private TextBox txtCustPhone;
        private Label lblSelectCar;
        private ComboBox cmbCars;
        private Label lblDays;
        private NumericUpDown numDays;
        private Panel costSummaryPanel;
        private Label lblDailyRateNote;
        private Label lblTotalCalculated;
        private Button btnConfirmBooking;
        private Label lblBookingFeedback;
        private Panel overviewFleetCard;
        private Label lblOverviewFleetTitle;
        private DataGridView gridOverviewFleet;
        private Panel panelFleet;
        private Panel fleetHeaderPanel;
        private Label lblFleetTitle;
        private TextBox txtFleetSearch;
        private ComboBox cmbFleetFilter;
        private DataGridView gridFleet;
        private Panel addCarBox;
        private Label lblAddCarTitle;
        private TextBox txtAddBrand;
        private TextBox txtAddModel;
        private ComboBox cmbAddCategory;
        private TextBox txtAddPlate;
        private NumericUpDown numAddRate;
        private Button btnAddCar;
        private Panel panelRentals;
        private Panel rentalsHeaderPanel;
        private Label lblRentalsTitle;
        private Button btnReturnCar;
        private DataGridView gridRentals;
        private Panel panelDatabase;
        private Panel dbCard;
        private Label lblDbTitle;
        private Label lblDbSub;
        private TextBox txtConnString;
        private Button btnTestDbInDash;
        private Button btnGenerateSql;
        private TextBox txtDbLog;
    }
}
