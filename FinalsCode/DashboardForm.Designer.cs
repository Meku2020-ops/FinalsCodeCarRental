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
            btnBack = new Button();
            btnNavDatabase = new Button();
            btnNavRentals = new Button();
            btnNavFleet = new Button();
            btnNavBooking = new Button();
            btnNavOverview = new Button();
            brandPanel = new Panel();
            lblBrandSub = new Label();
            lblLogo = new Label();
            topBarPanel = new Panel();
            lblStatusBadge = new Label();
            lblLiveClock = new Label();
            lblPageSubtitle = new Label();
            lblPageTitle = new Label();
            mainContainerPanel = new Panel();
            panelOverview = new Panel();
            overviewFleetCard = new Panel();
            gridOverviewFleet = new DataGridView();
            lblOverviewFleetTitle = new Label();
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
            panelReservation = new Panel();
            resSplitLayout = new TableLayoutPanel();
            resSummaryCard = new Panel();
            resCostBox = new Panel();
            lblResTotalAmount = new Label();
            lblResScheduleSummary = new Label();
            lblResVehicleSummary = new Label();
            lblResSummaryTitle = new Label();
            resFormCard = new Panel();
            lblResFeedback = new Label();
            btnResClear = new Button();
            btnResSubmit = new Button();
            txtResNotes = new TextBox();
            lblResNotes = new Label();
            cmbResPaymentMethod = new ComboBox();
            lblResPaymentMethod = new Label();
            cmbResPickupLocation = new ComboBox();
            lblResPickupLocation = new Label();
            numResDays = new NumericUpDown();
            lblResDays = new Label();
            dtpResReturnDate = new DateTimePicker();
            lblResReturnDate = new Label();
            dtpResPickupDate = new DateTimePicker();
            lblResPickupDate = new Label();
            cmbResCar = new ComboBox();
            lblResCar = new Label();
            txtResAddress = new TextBox();
            lblResAddress = new Label();
            cmbResIdType = new ComboBox();
            lblResIdType = new Label();
            txtResEmail = new TextBox();
            lblResEmail = new Label();
            txtResPhone = new TextBox();
            lblResPhone = new Label();
            txtResCustName = new TextBox();
            lblResCustName = new Label();
            lblResFormSub = new Label();
            lblResFormTitle = new Label();
            panelFleet = new Panel();
            gridFleet = new DataGridView();
            fleetHeaderPanel = new Panel();
            cmbFleetFilter = new ComboBox();
            txtFleetSearch = new TextBox();
            lblFleetTitle = new Label();
            addCarBox = new Panel();
            btnAddCar = new Button();
            lblAddRate = new Label();
            numAddRate = new NumericUpDown();
            lblAddSeaters = new Label();
            numAddSeaters = new NumericUpDown();
            txtAddPlate = new TextBox();
            cmbAddCategory = new ComboBox();
            lblAddCustomCategory = new Label();
            txtAddCustomCategory = new TextBox();
            txtAddModel = new TextBox();
            txtAddBrand = new TextBox();
            lblAddCarTitle = new Label();
            panelRentals = new Panel();
            gridRentals = new DataGridView();
            rentalsActionPanel = new Panel();
            btnActivatePickup = new Button();
            btnReturnCar = new Button();
            lblRentalsNotice = new Label();
            rentalsHeaderPanel = new Panel();
            lblRentalsTitle = new Label();
            panelDatabase = new Panel();
            dbCard = new Panel();
            dbLogPanel = new Panel();
            txtDbLog = new TextBox();
            lblLogTitle = new Label();
            dbSettingsPanel = new Panel();
            btnGenerateSql = new Button();
            btnTestDbInDash = new Button();
            txtConnString = new TextBox();
            lblDbSub = new Label();
            lblDbTitle = new Label();
            sidebarPanel.SuspendLayout();
            brandPanel.SuspendLayout();
            topBarPanel.SuspendLayout();
            mainContainerPanel.SuspendLayout();
            panelOverview.SuspendLayout();
            overviewFleetCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridOverviewFleet).BeginInit();
            overviewStatsLayout.SuspendLayout();
            cardTotalCars.SuspendLayout();
            cardAvailCars.SuspendLayout();
            cardRentedCars.SuspendLayout();
            cardRevenue.SuspendLayout();
            panelReservation.SuspendLayout();
            resSplitLayout.SuspendLayout();
            resSummaryCard.SuspendLayout();
            resCostBox.SuspendLayout();
            resFormCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numResDays).BeginInit();
            panelFleet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridFleet).BeginInit();
            fleetHeaderPanel.SuspendLayout();
            addCarBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAddRate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAddSeaters).BeginInit();
            panelRentals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridRentals).BeginInit();
            rentalsActionPanel.SuspendLayout();
            rentalsHeaderPanel.SuspendLayout();
            panelDatabase.SuspendLayout();
            dbCard.SuspendLayout();
            dbLogPanel.SuspendLayout();
            dbSettingsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.FromArgb(18, 22, 28);
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
            sidebarPanel.Size = new Size(230, 749);
            sidebarPanel.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnBack.BackColor = Color.FromArgb(28, 35, 46);
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 9F);
            btnBack.ForeColor = Color.FromArgb(160, 174, 192);
            btnBack.Location = new Point(12, 691);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(206, 42);
            btnBack.TabIndex = 6;
            btnBack.Text = "⬅️  Exit to Gateway";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnNavDatabase
            // 
            btnNavDatabase.BackColor = Color.FromArgb(18, 22, 28);
            btnNavDatabase.Cursor = Cursors.Hand;
            btnNavDatabase.FlatAppearance.BorderSize = 0;
            btnNavDatabase.FlatStyle = FlatStyle.Flat;
            btnNavDatabase.Font = new Font("Segoe UI", 9.5F);
            btnNavDatabase.ForeColor = Color.FromArgb(175, 185, 200);
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
            // btnNavRentals
            // 
            btnNavRentals.BackColor = Color.FromArgb(18, 22, 28);
            btnNavRentals.Cursor = Cursors.Hand;
            btnNavRentals.FlatAppearance.BorderSize = 0;
            btnNavRentals.FlatStyle = FlatStyle.Flat;
            btnNavRentals.Font = new Font("Segoe UI", 9.5F);
            btnNavRentals.ForeColor = Color.FromArgb(175, 185, 200);
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
            // btnNavFleet
            // 
            btnNavFleet.BackColor = Color.FromArgb(18, 22, 28);
            btnNavFleet.Cursor = Cursors.Hand;
            btnNavFleet.FlatAppearance.BorderSize = 0;
            btnNavFleet.FlatStyle = FlatStyle.Flat;
            btnNavFleet.Font = new Font("Segoe UI", 9.5F);
            btnNavFleet.ForeColor = Color.FromArgb(175, 185, 200);
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
            // btnNavBooking
            // 
            btnNavBooking.BackColor = Color.FromArgb(18, 22, 28);
            btnNavBooking.Cursor = Cursors.Hand;
            btnNavBooking.FlatAppearance.BorderSize = 0;
            btnNavBooking.FlatStyle = FlatStyle.Flat;
            btnNavBooking.Font = new Font("Segoe UI", 9.5F);
            btnNavBooking.ForeColor = Color.FromArgb(175, 185, 200);
            btnNavBooking.Location = new Point(12, 145);
            btnNavBooking.Name = "btnNavBooking";
            btnNavBooking.Padding = new Padding(12, 0, 0, 0);
            btnNavBooking.Size = new Size(206, 44);
            btnNavBooking.TabIndex = 2;
            btnNavBooking.Text = "📝  Reservation Form";
            btnNavBooking.TextAlign = ContentAlignment.MiddleLeft;
            btnNavBooking.UseVisualStyleBackColor = true;
            btnNavBooking.Click += btnNavBooking_Click;
            // 
            // btnNavOverview
            // 
            btnNavOverview.BackColor = Color.FromArgb(5, 150, 105);
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
            // brandPanel
            // 
            brandPanel.BackColor = Color.FromArgb(12, 16, 20);
            brandPanel.Controls.Add(lblBrandSub);
            brandPanel.Controls.Add(lblLogo);
            brandPanel.Dock = DockStyle.Top;
            brandPanel.Location = new Point(0, 0);
            brandPanel.Name = "brandPanel";
            brandPanel.Padding = new Padding(18, 16, 18, 16);
            brandPanel.Size = new Size(230, 75);
            brandPanel.TabIndex = 0;
            // 
            // lblBrandSub
            // 
            lblBrandSub.AutoSize = true;
            lblBrandSub.Font = new Font("Segoe UI Semibold", 7.5F, FontStyle.Bold);
            lblBrandSub.ForeColor = Color.FromArgb(110, 231, 183);
            lblBrandSub.Location = new Point(18, 42);
            lblBrandSub.Name = "lblBrandSub";
            lblBrandSub.Size = new Size(141, 12);
            lblBrandSub.TabIndex = 1;
            lblBrandSub.Text = "ADVANCE BOOKING SYSTEM!";
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(14, 14);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(152, 25);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "⚡ CAR RENTAL";
            // 
            // topBarPanel
            // 
            topBarPanel.BackColor = Color.FromArgb(250, 250, 252);
            topBarPanel.Controls.Add(lblStatusBadge);
            topBarPanel.Controls.Add(lblLiveClock);
            topBarPanel.Controls.Add(lblPageSubtitle);
            topBarPanel.Controls.Add(lblPageTitle);
            topBarPanel.Dock = DockStyle.Top;
            topBarPanel.Location = new Point(230, 0);
            topBarPanel.Name = "topBarPanel";
            topBarPanel.Padding = new Padding(24, 12, 24, 12);
            topBarPanel.Size = new Size(897, 75);
            topBarPanel.TabIndex = 1;
            // 
            // lblStatusBadge
            // 
            lblStatusBadge.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStatusBadge.AutoSize = true;
            lblStatusBadge.BackColor = Color.FromArgb(236, 253, 245);
            lblStatusBadge.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            lblStatusBadge.ForeColor = Color.FromArgb(5, 150, 105);
            lblStatusBadge.Location = new Point(745, 42);
            lblStatusBadge.Name = "lblStatusBadge";
            lblStatusBadge.Padding = new Padding(6, 3, 6, 3);
            lblStatusBadge.Size = new Size(138, 21);
            lblStatusBadge.TabIndex = 3;
            lblStatusBadge.Text = "\U0001f7e2 Operational & Online";
            // 
            // lblLiveClock
            // 
            lblLiveClock.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLiveClock.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblLiveClock.ForeColor = Color.FromArgb(71, 85, 105);
            lblLiveClock.Location = new Point(627, 14);
            lblLiveClock.Name = "lblLiveClock";
            lblLiveClock.Size = new Size(246, 22);
            lblLiveClock.TabIndex = 2;
            lblLiveClock.Text = "Live System";
            lblLiveClock.TextAlign = ContentAlignment.MiddleRight;
            lblLiveClock.Click += lblLiveClock_Click;
            // 
            // lblPageSubtitle
            // 
            lblPageSubtitle.AutoSize = true;
            lblPageSubtitle.Font = new Font("Segoe UI", 9F);
            lblPageSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblPageSubtitle.Location = new Point(24, 42);
            lblPageSubtitle.Name = "lblPageSubtitle";
            lblPageSubtitle.Size = new Size(299, 15);
            lblPageSubtitle.TabIndex = 1;
            lblPageSubtitle.Text = "Real-time fleet statistics and currently available vehicles";
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblPageTitle.Location = new Point(22, 14);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(197, 25);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Dashboard Overview";
            // 
            // mainContainerPanel
            // 
            mainContainerPanel.AutoSize = true;
            mainContainerPanel.BackColor = Color.FromArgb(241, 245, 249);
            mainContainerPanel.Controls.Add(panelOverview);
            mainContainerPanel.Controls.Add(panelReservation);
            mainContainerPanel.Controls.Add(panelFleet);
            mainContainerPanel.Controls.Add(panelRentals);
            mainContainerPanel.Controls.Add(panelDatabase);
            mainContainerPanel.Dock = DockStyle.Fill;
            mainContainerPanel.Location = new Point(230, 75);
            mainContainerPanel.Name = "mainContainerPanel";
            mainContainerPanel.Padding = new Padding(20);
            mainContainerPanel.Size = new Size(897, 674);
            mainContainerPanel.TabIndex = 2;
            // 
            // panelOverview
            // 
            panelOverview.Controls.Add(overviewFleetCard);
            panelOverview.Controls.Add(overviewStatsLayout);
            panelOverview.Dock = DockStyle.Fill;
            panelOverview.Location = new Point(20, 20);
            panelOverview.Name = "panelOverview";
            panelOverview.Size = new Size(857, 634);
            panelOverview.TabIndex = 0;
            // 
            // overviewFleetCard
            // 
            overviewFleetCard.BackColor = Color.White;
            overviewFleetCard.Controls.Add(gridOverviewFleet);
            overviewFleetCard.Controls.Add(lblOverviewFleetTitle);
            overviewFleetCard.Dock = DockStyle.Fill;
            overviewFleetCard.Location = new Point(230, 0);
            overviewFleetCard.Margin = new Padding(14, 0, 0, 0);
            overviewFleetCard.Name = "overviewFleetCard";
            overviewFleetCard.Padding = new Padding(16);
            overviewFleetCard.Size = new Size(627, 634);
            overviewFleetCard.TabIndex = 1;
            // 
            // gridOverviewFleet
            // 
            gridOverviewFleet.AllowUserToAddRows = false;
            gridOverviewFleet.AllowUserToDeleteRows = false;
            gridOverviewFleet.AllowUserToResizeRows = false;
            gridOverviewFleet.BackgroundColor = Color.White;
            gridOverviewFleet.BorderStyle = BorderStyle.None;
            gridOverviewFleet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridOverviewFleet.Dock = DockStyle.Fill;
            gridOverviewFleet.Location = new Point(16, 56);
            gridOverviewFleet.Name = "gridOverviewFleet";
            gridOverviewFleet.ReadOnly = true;
            gridOverviewFleet.RowHeadersVisible = false;
            gridOverviewFleet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridOverviewFleet.Size = new Size(595, 562);
            gridOverviewFleet.TabIndex = 1;
            // 
            // lblOverviewFleetTitle
            // 
            lblOverviewFleetTitle.Dock = DockStyle.Top;
            lblOverviewFleetTitle.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            lblOverviewFleetTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblOverviewFleetTitle.Location = new Point(16, 16);
            lblOverviewFleetTitle.Name = "lblOverviewFleetTitle";
            lblOverviewFleetTitle.Size = new Size(595, 40);
            lblOverviewFleetTitle.TabIndex = 0;
            lblOverviewFleetTitle.Text = "🚘 Ready Available Fleet";
            // 
            // overviewStatsLayout
            // 
            overviewStatsLayout.ColumnCount = 1;
            overviewStatsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            overviewStatsLayout.Controls.Add(cardTotalCars, 0, 0);
            overviewStatsLayout.Controls.Add(cardAvailCars, 0, 1);
            overviewStatsLayout.Controls.Add(cardRentedCars, 0, 2);
            overviewStatsLayout.Controls.Add(cardRevenue, 0, 3);
            overviewStatsLayout.Dock = DockStyle.Left;
            overviewStatsLayout.Location = new Point(0, 0);
            overviewStatsLayout.Name = "overviewStatsLayout";
            overviewStatsLayout.RowCount = 4;
            overviewStatsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            overviewStatsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            overviewStatsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            overviewStatsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            overviewStatsLayout.Size = new Size(230, 634);
            overviewStatsLayout.TabIndex = 0;
            // 
            // cardTotalCars
            // 
            cardTotalCars.BackColor = Color.White;
            cardTotalCars.Controls.Add(lblStatTotalVal);
            cardTotalCars.Controls.Add(lblStatTotalTitle);
            cardTotalCars.Dock = DockStyle.Fill;
            cardTotalCars.Location = new Point(0, 0);
            cardTotalCars.Margin = new Padding(0, 0, 14, 12);
            cardTotalCars.Name = "cardTotalCars";
            cardTotalCars.Padding = new Padding(14);
            cardTotalCars.Size = new Size(216, 146);
            cardTotalCars.TabIndex = 0;
            // 
            // lblStatTotalVal
            // 
            lblStatTotalVal.AutoSize = true;
            lblStatTotalVal.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblStatTotalVal.ForeColor = Color.FromArgb(5, 150, 105);
            lblStatTotalVal.Location = new Point(10, 46);
            lblStatTotalVal.Name = "lblStatTotalVal";
            lblStatTotalVal.Size = new Size(84, 32);
            lblStatTotalVal.TabIndex = 1;
            lblStatTotalVal.Text = "8 Cars";
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
            // cardAvailCars
            // 
            cardAvailCars.BackColor = Color.White;
            cardAvailCars.Controls.Add(lblStatAvailVal);
            cardAvailCars.Controls.Add(lblStatAvailTitle);
            cardAvailCars.Dock = DockStyle.Fill;
            cardAvailCars.Location = new Point(0, 158);
            cardAvailCars.Margin = new Padding(0, 0, 14, 12);
            cardAvailCars.Name = "cardAvailCars";
            cardAvailCars.Padding = new Padding(14);
            cardAvailCars.Size = new Size(216, 146);
            cardAvailCars.TabIndex = 1;
            // 
            // lblStatAvailVal
            // 
            lblStatAvailVal.AutoSize = true;
            lblStatAvailVal.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblStatAvailVal.ForeColor = Color.FromArgb(22, 163, 74);
            lblStatAvailVal.Location = new Point(10, 46);
            lblStatAvailVal.Name = "lblStatAvailVal";
            lblStatAvailVal.Size = new Size(84, 32);
            lblStatAvailVal.TabIndex = 1;
            lblStatAvailVal.Text = "6 Cars";
            // 
            // lblStatAvailTitle
            // 
            lblStatAvailTitle.AutoSize = true;
            lblStatAvailTitle.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            lblStatAvailTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblStatAvailTitle.Location = new Point(12, 14);
            lblStatAvailTitle.Name = "lblStatAvailTitle";
            lblStatAvailTitle.Size = new Size(99, 15);
            lblStatAvailTitle.TabIndex = 0;
            lblStatAvailTitle.Text = "AVAILABLE NOW";
            // 
            // cardRentedCars
            // 
            cardRentedCars.BackColor = Color.White;
            cardRentedCars.Controls.Add(lblStatRentedVal);
            cardRentedCars.Controls.Add(lblStatRentedTitle);
            cardRentedCars.Dock = DockStyle.Fill;
            cardRentedCars.Location = new Point(0, 316);
            cardRentedCars.Margin = new Padding(0, 0, 14, 12);
            cardRentedCars.Name = "cardRentedCars";
            cardRentedCars.Padding = new Padding(14);
            cardRentedCars.Size = new Size(216, 146);
            cardRentedCars.TabIndex = 2;
            // 
            // lblStatRentedVal
            // 
            lblStatRentedVal.AutoSize = true;
            lblStatRentedVal.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblStatRentedVal.ForeColor = Color.FromArgb(234, 88, 12);
            lblStatRentedVal.Location = new Point(10, 46);
            lblStatRentedVal.Name = "lblStatRentedVal";
            lblStatRentedVal.Size = new Size(84, 32);
            lblStatRentedVal.TabIndex = 1;
            lblStatRentedVal.Text = "2 Cars";
            // 
            // lblStatRentedTitle
            // 
            lblStatRentedTitle.AutoSize = true;
            lblStatRentedTitle.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            lblStatRentedTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblStatRentedTitle.Location = new Point(12, 14);
            lblStatRentedTitle.Name = "lblStatRentedTitle";
            lblStatRentedTitle.Size = new Size(86, 15);
            lblStatRentedTitle.TabIndex = 0;
            lblStatRentedTitle.Text = "RENTED / OUT";
            // 
            // cardRevenue
            // 
            cardRevenue.BackColor = Color.White;
            cardRevenue.Controls.Add(lblStatRevenueVal);
            cardRevenue.Controls.Add(lblStatRevenueTitle);
            cardRevenue.Dock = DockStyle.Fill;
            cardRevenue.Location = new Point(0, 474);
            cardRevenue.Margin = new Padding(0, 0, 14, 0);
            cardRevenue.Name = "cardRevenue";
            cardRevenue.Padding = new Padding(14);
            cardRevenue.Size = new Size(216, 160);
            cardRevenue.TabIndex = 3;
            // 
            // lblStatRevenueVal
            // 
            lblStatRevenueVal.AutoSize = true;
            lblStatRevenueVal.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblStatRevenueVal.ForeColor = Color.FromArgb(124, 58, 237);
            lblStatRevenueVal.Location = new Point(10, 46);
            lblStatRevenueVal.Name = "lblStatRevenueVal";
            lblStatRevenueVal.Size = new Size(106, 32);
            lblStatRevenueVal.TabIndex = 1;
            lblStatRevenueVal.Text = "₱940.00";
            lblStatRevenueVal.Click += lblStatRevenueVal_Click;
            // 
            // lblStatRevenueTitle
            // 
            lblStatRevenueTitle.AutoSize = true;
            lblStatRevenueTitle.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            lblStatRevenueTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblStatRevenueTitle.Location = new Point(12, 14);
            lblStatRevenueTitle.Name = "lblStatRevenueTitle";
            lblStatRevenueTitle.Size = new Size(95, 15);
            lblStatRevenueTitle.TabIndex = 0;
            lblStatRevenueTitle.Text = "TOTAL REVENUE";
            // 
            // panelReservation
            // 
            panelReservation.Controls.Add(resSplitLayout);
            panelReservation.Dock = DockStyle.Fill;
            panelReservation.Location = new Point(20, 20);
            panelReservation.Name = "panelReservation";
            panelReservation.Size = new Size(857, 634);
            panelReservation.TabIndex = 4;
            panelReservation.Visible = false;
            // 
            // resSplitLayout
            // 
            resSplitLayout.ColumnCount = 2;
            resSplitLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36F));
            resSplitLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64F));
            resSplitLayout.Controls.Add(resSummaryCard, 0, 0);
            resSplitLayout.Controls.Add(resFormCard, 1, 0);
            resSplitLayout.Dock = DockStyle.Fill;
            resSplitLayout.Location = new Point(0, 0);
            resSplitLayout.Name = "resSplitLayout";
            resSplitLayout.RowCount = 1;
            resSplitLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            resSplitLayout.Size = new Size(857, 634);
            resSplitLayout.TabIndex = 0;
            // 
            // resSummaryCard
            // 
            resSummaryCard.BackColor = Color.White;
            resSummaryCard.Controls.Add(resCostBox);
            resSummaryCard.Controls.Add(lblResSummaryTitle);
            resSummaryCard.Dock = DockStyle.Fill;
            resSummaryCard.Location = new Point(0, 0);
            resSummaryCard.Margin = new Padding(0, 0, 14, 0);
            resSummaryCard.Name = "resSummaryCard";
            resSummaryCard.Padding = new Padding(18);
            resSummaryCard.Size = new Size(294, 634);
            resSummaryCard.TabIndex = 1;
            // 
            // resCostBox
            // 
            resCostBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            resCostBox.BackColor = Color.FromArgb(248, 250, 252);
            resCostBox.BorderStyle = BorderStyle.FixedSingle;
            resCostBox.Controls.Add(lblResTotalAmount);
            resCostBox.Controls.Add(lblResScheduleSummary);
            resCostBox.Controls.Add(lblResVehicleSummary);
            resCostBox.Location = new Point(18, 48);
            resCostBox.Name = "resCostBox";
            resCostBox.Padding = new Padding(12);
            resCostBox.Size = new Size(280, 128);
            resCostBox.TabIndex = 1;
            // 
            // lblResTotalAmount
            // 
            lblResTotalAmount.AutoSize = true;
            lblResTotalAmount.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblResTotalAmount.ForeColor = Color.FromArgb(22, 163, 74);
            lblResTotalAmount.Location = new Point(8, 76);
            lblResTotalAmount.Name = "lblResTotalAmount";
            lblResTotalAmount.Size = new Size(78, 32);
            lblResTotalAmount.TabIndex = 2;
            lblResTotalAmount.Text = "₱0.00";
            // 
            // lblResScheduleSummary
            // 
            lblResScheduleSummary.AutoSize = true;
            lblResScheduleSummary.Font = new Font("Segoe UI", 8.5F);
            lblResScheduleSummary.ForeColor = Color.FromArgb(100, 116, 139);
            lblResScheduleSummary.Location = new Point(10, 40);
            lblResScheduleSummary.Name = "lblResScheduleSummary";
            lblResScheduleSummary.Size = new Size(160, 15);
            lblResScheduleSummary.TabIndex = 1;
            lblResScheduleSummary.Text = "Select dates to calculate total";
            // 
            // lblResVehicleSummary
            // 
            lblResVehicleSummary.AutoSize = true;
            lblResVehicleSummary.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblResVehicleSummary.ForeColor = Color.FromArgb(30, 41, 59);
            lblResVehicleSummary.Location = new Point(10, 12);
            lblResVehicleSummary.Name = "lblResVehicleSummary";
            lblResVehicleSummary.Size = new Size(128, 15);
            lblResVehicleSummary.TabIndex = 0;
            lblResVehicleSummary.Text = "No vehicle selected yet";
            // 
            // lblResSummaryTitle
            // 
            lblResSummaryTitle.AutoSize = true;
            lblResSummaryTitle.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            lblResSummaryTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblResSummaryTitle.Location = new Point(16, 14);
            lblResSummaryTitle.Name = "lblResSummaryTitle";
            lblResSummaryTitle.Size = new Size(206, 21);
            lblResSummaryTitle.TabIndex = 0;
            lblResSummaryTitle.Text = "📋 Reservation Summary";
            // 
            // resFormCard
            // 
            resFormCard.AutoScroll = true;
            resFormCard.BackColor = Color.White;
            resFormCard.Controls.Add(lblResFeedback);
            resFormCard.Controls.Add(btnResClear);
            resFormCard.Controls.Add(btnResSubmit);
            resFormCard.Controls.Add(txtResNotes);
            resFormCard.Controls.Add(lblResNotes);
            resFormCard.Controls.Add(cmbResPaymentMethod);
            resFormCard.Controls.Add(lblResPaymentMethod);
            resFormCard.Controls.Add(cmbResPickupLocation);
            resFormCard.Controls.Add(lblResPickupLocation);
            resFormCard.Controls.Add(numResDays);
            resFormCard.Controls.Add(lblResDays);
            resFormCard.Controls.Add(dtpResReturnDate);
            resFormCard.Controls.Add(lblResReturnDate);
            resFormCard.Controls.Add(dtpResPickupDate);
            resFormCard.Controls.Add(lblResPickupDate);
            resFormCard.Controls.Add(cmbResCar);
            resFormCard.Controls.Add(lblResCar);
            resFormCard.Controls.Add(txtResAddress);
            resFormCard.Controls.Add(lblResAddress);
            resFormCard.Controls.Add(cmbResIdType);
            resFormCard.Controls.Add(lblResIdType);
            resFormCard.Controls.Add(txtResEmail);
            resFormCard.Controls.Add(lblResEmail);
            resFormCard.Controls.Add(txtResPhone);
            resFormCard.Controls.Add(lblResPhone);
            resFormCard.Controls.Add(txtResCustName);
            resFormCard.Controls.Add(lblResCustName);
            resFormCard.Controls.Add(lblResFormSub);
            resFormCard.Controls.Add(lblResFormTitle);
            resFormCard.Dock = DockStyle.Fill;
            resFormCard.Location = new Point(308, 0);
            resFormCard.Margin = new Padding(0);
            resFormCard.Name = "resFormCard";
            resFormCard.Padding = new Padding(18);
            resFormCard.Size = new Size(549, 634);
            resFormCard.TabIndex = 0;
            // 
            // lblResFeedback
            // 
            lblResFeedback.Font = new Font("Segoe UI", 8.5F);
            lblResFeedback.ForeColor = Color.FromArgb(100, 116, 139);
            lblResFeedback.Location = new Point(18, 514);
            lblResFeedback.Name = "lblResFeedback";
            lblResFeedback.Size = new Size(478, 36);
            lblResFeedback.TabIndex = 29;
            lblResFeedback.Text = "Complete the fill-up form and click Confirm & Save Reservation.";
            // 
            // btnResClear
            // 
            btnResClear.BackColor = Color.FromArgb(226, 232, 240);
            btnResClear.Cursor = Cursors.Hand;
            btnResClear.FlatAppearance.BorderSize = 0;
            btnResClear.FlatStyle = FlatStyle.Flat;
            btnResClear.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnResClear.ForeColor = Color.FromArgb(51, 65, 85);
            btnResClear.Location = new Point(350, 462);
            btnResClear.Name = "btnResClear";
            btnResClear.Size = new Size(146, 42);
            btnResClear.TabIndex = 28;
            btnResClear.Text = "Clear Form";
            btnResClear.UseVisualStyleBackColor = false;
            btnResClear.Click += btnResClear_Click;
            // 
            // btnResSubmit
            // 
            btnResSubmit.BackColor = Color.FromArgb(5, 150, 105);
            btnResSubmit.Cursor = Cursors.Hand;
            btnResSubmit.FlatAppearance.BorderSize = 0;
            btnResSubmit.FlatStyle = FlatStyle.Flat;
            btnResSubmit.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            btnResSubmit.ForeColor = Color.White;
            btnResSubmit.Location = new Point(18, 462);
            btnResSubmit.Name = "btnResSubmit";
            btnResSubmit.Size = new Size(320, 42);
            btnResSubmit.TabIndex = 27;
            btnResSubmit.Text = "✔ Confirm & Save Reservation";
            btnResSubmit.UseVisualStyleBackColor = false;
            btnResSubmit.Click += btnResSubmit_Click;
            // 
            // txtResNotes
            // 
            txtResNotes.Font = new Font("Segoe UI", 9.5F);
            txtResNotes.Location = new Point(18, 398);
            txtResNotes.Multiline = true;
            txtResNotes.Name = "txtResNotes";
            txtResNotes.PlaceholderText = "Optional: child seat, delivery instructions, preferred pick-up time...";
            txtResNotes.Size = new Size(478, 48);
            txtResNotes.TabIndex = 25;
            // 
            // lblResNotes
            // 
            lblResNotes.AutoSize = true;
            lblResNotes.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            lblResNotes.ForeColor = Color.FromArgb(51, 65, 85);
            lblResNotes.Location = new Point(18, 380);
            lblResNotes.Name = "lblResNotes";
            lblResNotes.Size = new Size(189, 15);
            lblResNotes.TabIndex = 24;
            lblResNotes.Text = "Special Request / Notes (Optional)";
            // 
            // cmbResPaymentMethod
            // 
            cmbResPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbResPaymentMethod.Font = new Font("Segoe UI", 9.5F);
            cmbResPaymentMethod.FormattingEnabled = true;
            cmbResPaymentMethod.Items.AddRange(new object[] { "Cash", "GCash", "Credit / Debit Card", "Bank Transfer" });
            cmbResPaymentMethod.Location = new Point(264, 345);
            cmbResPaymentMethod.Name = "cmbResPaymentMethod";
            cmbResPaymentMethod.Size = new Size(232, 25);
            cmbResPaymentMethod.TabIndex = 23;
            // 
            // lblResPaymentMethod
            // 
            lblResPaymentMethod.AutoSize = true;
            lblResPaymentMethod.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            lblResPaymentMethod.ForeColor = Color.FromArgb(51, 65, 85);
            lblResPaymentMethod.Location = new Point(264, 327);
            lblResPaymentMethod.Name = "lblResPaymentMethod";
            lblResPaymentMethod.Size = new Size(107, 15);
            lblResPaymentMethod.TabIndex = 22;
            lblResPaymentMethod.Text = "Payment Method *";
            // 
            // cmbResPickupLocation
            // 
            cmbResPickupLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbResPickupLocation.Font = new Font("Segoe UI", 9.5F);
            cmbResPickupLocation.FormattingEnabled = true;
            cmbResPickupLocation.Items.AddRange(new object[] { "Main Office (Showroom)", "Airport Terminal", "Downtown Branch", "Hotel / Home Delivery" });
            cmbResPickupLocation.Location = new Point(18, 345);
            cmbResPickupLocation.Name = "cmbResPickupLocation";
            cmbResPickupLocation.Size = new Size(232, 25);
            cmbResPickupLocation.TabIndex = 21;
            // 
            // lblResPickupLocation
            // 
            lblResPickupLocation.AutoSize = true;
            lblResPickupLocation.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            lblResPickupLocation.ForeColor = Color.FromArgb(51, 65, 85);
            lblResPickupLocation.Location = new Point(18, 327);
            lblResPickupLocation.Name = "lblResPickupLocation";
            lblResPickupLocation.Size = new Size(104, 15);
            lblResPickupLocation.TabIndex = 20;
            lblResPickupLocation.Text = "Pick-up Location *";
            // 
            // numResDays
            // 
            numResDays.Font = new Font("Segoe UI", 9.5F);
            numResDays.Location = new Point(390, 293);
            numResDays.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            numResDays.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numResDays.Name = "numResDays";
            numResDays.Size = new Size(106, 24);
            numResDays.TabIndex = 19;
            numResDays.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numResDays.ValueChanged += numResDays_ValueChanged;
            // 
            // lblResDays
            // 
            lblResDays.AutoSize = true;
            lblResDays.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            lblResDays.ForeColor = Color.FromArgb(51, 65, 85);
            lblResDays.Location = new Point(390, 275);
            lblResDays.Name = "lblResDays";
            lblResDays.Size = new Size(41, 15);
            lblResDays.TabIndex = 18;
            lblResDays.Text = "Days *";
            // 
            // dtpResReturnDate
            // 
            dtpResReturnDate.Font = new Font("Segoe UI", 9.5F);
            dtpResReturnDate.Format = DateTimePickerFormat.Short;
            dtpResReturnDate.Location = new Point(204, 293);
            dtpResReturnDate.Name = "dtpResReturnDate";
            dtpResReturnDate.Size = new Size(172, 24);
            dtpResReturnDate.TabIndex = 17;
            dtpResReturnDate.ValueChanged += dtpResReturnDate_ValueChanged;
            // 
            // lblResReturnDate
            // 
            lblResReturnDate.AutoSize = true;
            lblResReturnDate.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            lblResReturnDate.ForeColor = Color.FromArgb(51, 65, 85);
            lblResReturnDate.Location = new Point(204, 275);
            lblResReturnDate.Name = "lblResReturnDate";
            lblResReturnDate.Size = new Size(78, 15);
            lblResReturnDate.TabIndex = 16;
            lblResReturnDate.Text = "Return Date *";
            // 
            // dtpResPickupDate
            // 
            dtpResPickupDate.Font = new Font("Segoe UI", 9.5F);
            dtpResPickupDate.Format = DateTimePickerFormat.Short;
            dtpResPickupDate.Location = new Point(18, 293);
            dtpResPickupDate.Name = "dtpResPickupDate";
            dtpResPickupDate.Size = new Size(172, 24);
            dtpResPickupDate.TabIndex = 15;
            dtpResPickupDate.ValueChanged += dtpResPickupDate_ValueChanged;
            // 
            // lblResPickupDate
            // 
            lblResPickupDate.AutoSize = true;
            lblResPickupDate.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            lblResPickupDate.ForeColor = Color.FromArgb(51, 65, 85);
            lblResPickupDate.Location = new Point(18, 275);
            lblResPickupDate.Name = "lblResPickupDate";
            lblResPickupDate.Size = new Size(83, 15);
            lblResPickupDate.TabIndex = 14;
            lblResPickupDate.Text = "Pick-up Date *";
            // 
            // cmbResCar
            // 
            cmbResCar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbResCar.Font = new Font("Segoe UI", 9.5F);
            cmbResCar.FormattingEnabled = true;
            cmbResCar.Location = new Point(18, 240);
            cmbResCar.Name = "cmbResCar";
            cmbResCar.Size = new Size(478, 25);
            cmbResCar.TabIndex = 13;
            cmbResCar.SelectedIndexChanged += cmbResCar_SelectedIndexChanged;
            // 
            // lblResCar
            // 
            lblResCar.AutoSize = true;
            lblResCar.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            lblResCar.ForeColor = Color.FromArgb(51, 65, 85);
            lblResCar.Location = new Point(18, 222);
            lblResCar.Name = "lblResCar";
            lblResCar.Size = new Size(139, 15);
            lblResCar.TabIndex = 12;
            lblResCar.Text = "Select Available Vehicle *";
            // 
            // txtResAddress
            // 
            txtResAddress.Font = new Font("Segoe UI", 9.5F);
            txtResAddress.Location = new Point(18, 188);
            txtResAddress.Name = "txtResAddress";
            txtResAddress.PlaceholderText = "Street, Barangay, City / Province";
            txtResAddress.Size = new Size(478, 24);
            txtResAddress.TabIndex = 11;
            // 
            // lblResAddress
            // 
            lblResAddress.AutoSize = true;
            lblResAddress.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            lblResAddress.ForeColor = Color.FromArgb(51, 65, 85);
            lblResAddress.Location = new Point(18, 170);
            lblResAddress.Name = "lblResAddress";
            lblResAddress.Size = new Size(103, 15);
            lblResAddress.TabIndex = 10;
            lblResAddress.Text = "Complete Address";
            // 
            // cmbResIdType
            // 
            cmbResIdType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbResIdType.Font = new Font("Segoe UI", 9.5F);
            cmbResIdType.FormattingEnabled = true;
            cmbResIdType.Items.AddRange(new object[] { "Driver's License", "Passport", "National ID (PhilSys)", "UMID / SSS ID", "Postal ID", "Voter's ID", "PRC ID", "Senior Citizen / PWD ID" });
            cmbResIdType.Location = new Point(264, 136);
            cmbResIdType.Name = "cmbResIdType";
            cmbResIdType.Size = new Size(232, 25);
            cmbResIdType.TabIndex = 9;
            // 
            // lblResIdType
            // 
            lblResIdType.AutoSize = true;
            lblResIdType.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            lblResIdType.ForeColor = Color.FromArgb(51, 65, 85);
            lblResIdType.Location = new Point(264, 118);
            lblResIdType.Name = "lblResIdType";
            lblResIdType.Size = new Size(85, 15);
            lblResIdType.TabIndex = 8;
            lblResIdType.Text = "Valid ID Type *";
            // 
            // txtResEmail
            // 
            txtResEmail.Font = new Font("Segoe UI", 9.5F);
            txtResEmail.Location = new Point(18, 136);
            txtResEmail.Name = "txtResEmail";
            txtResEmail.PlaceholderText = "e.g. juan@email.com";
            txtResEmail.Size = new Size(232, 24);
            txtResEmail.TabIndex = 7;
            // 
            // lblResEmail
            // 
            lblResEmail.AutoSize = true;
            lblResEmail.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            lblResEmail.ForeColor = Color.FromArgb(51, 65, 85);
            lblResEmail.Location = new Point(18, 118);
            lblResEmail.Name = "lblResEmail";
            lblResEmail.Size = new Size(81, 15);
            lblResEmail.TabIndex = 6;
            lblResEmail.Text = "Email Address";
            // 
            // txtResPhone
            // 
            txtResPhone.Font = new Font("Segoe UI", 9.5F);
            txtResPhone.Location = new Point(264, 84);
            txtResPhone.Name = "txtResPhone";
            txtResPhone.PlaceholderText = "e.g. 0917-123-4567";
            txtResPhone.Size = new Size(232, 24);
            txtResPhone.TabIndex = 5;
            // 
            // lblResPhone
            // 
            lblResPhone.AutoSize = true;
            lblResPhone.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            lblResPhone.ForeColor = Color.FromArgb(51, 65, 85);
            lblResPhone.Location = new Point(264, 66);
            lblResPhone.Name = "lblResPhone";
            lblResPhone.Size = new Size(103, 15);
            lblResPhone.TabIndex = 4;
            lblResPhone.Text = "Contact Number *";
            // 
            // txtResCustName
            // 
            txtResCustName.Font = new Font("Segoe UI", 9.5F);
            txtResCustName.Location = new Point(18, 84);
            txtResCustName.Name = "txtResCustName";
            txtResCustName.PlaceholderText = "e.g. Juan Dela Cruz";
            txtResCustName.Size = new Size(232, 24);
            txtResCustName.TabIndex = 3;
            // 
            // lblResCustName
            // 
            lblResCustName.AutoSize = true;
            lblResCustName.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            lblResCustName.ForeColor = Color.FromArgb(51, 65, 85);
            lblResCustName.Location = new Point(18, 66);
            lblResCustName.Name = "lblResCustName";
            lblResCustName.Size = new Size(69, 15);
            lblResCustName.TabIndex = 2;
            lblResCustName.Text = "Full Name *";
            // 
            // lblResFormSub
            // 
            lblResFormSub.AutoSize = true;
            lblResFormSub.Font = new Font("Segoe UI", 8.5F);
            lblResFormSub.ForeColor = Color.FromArgb(100, 116, 139);
            lblResFormSub.Location = new Point(18, 39);
            lblResFormSub.Name = "lblResFormSub";
            lblResFormSub.Size = new Size(282, 15);
            lblResFormSub.TabIndex = 1;
            lblResFormSub.Text = "Fill in all required (*) fields to create a car reservation";
            // 
            // lblResFormTitle
            // 
            lblResFormTitle.AutoSize = true;
            lblResFormTitle.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            lblResFormTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblResFormTitle.Location = new Point(16, 14);
            lblResFormTitle.Name = "lblResFormTitle";
            lblResFormTitle.Size = new Size(321, 23);
            lblResFormTitle.TabIndex = 0;
            lblResFormTitle.Text = "📝 Customer Reservation Fill-Up Form";
            // 
            // panelFleet
            // 
            panelFleet.Controls.Add(gridFleet);
            panelFleet.Controls.Add(fleetHeaderPanel);
            panelFleet.Controls.Add(addCarBox);
            panelFleet.Dock = DockStyle.Fill;
            panelFleet.Location = new Point(20, 20);
            panelFleet.Name = "panelFleet";
            panelFleet.Size = new Size(857, 634);
            panelFleet.TabIndex = 1;
            panelFleet.Visible = false;
            // 
            // gridFleet
            // 
            gridFleet.AllowUserToAddRows = false;
            gridFleet.AllowUserToDeleteRows = false;
            gridFleet.AllowUserToResizeRows = false;
            gridFleet.BackgroundColor = Color.White;
            gridFleet.BorderStyle = BorderStyle.None;
            gridFleet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridFleet.Dock = DockStyle.Fill;
            gridFleet.Location = new Point(0, 60);
            gridFleet.Name = "gridFleet";
            gridFleet.ReadOnly = true;
            gridFleet.RowHeadersVisible = false;
            gridFleet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridFleet.Size = new Size(547, 574);
            gridFleet.TabIndex = 1;
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
            fleetHeaderPanel.Size = new Size(547, 60);
            fleetHeaderPanel.TabIndex = 0;
            // 
            // cmbFleetFilter
            // 
            cmbFleetFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbFleetFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFleetFilter.Font = new Font("Segoe UI", 9.5F);
            cmbFleetFilter.FormattingEnabled = true;
            cmbFleetFilter.Items.AddRange(new object[] { "All Categories", "Sedan", "SUV", "Luxury", "Sports", "Electric" });
            cmbFleetFilter.Location = new Point(377, 16);
            cmbFleetFilter.Name = "cmbFleetFilter";
            cmbFleetFilter.Size = new Size(150, 25);
            cmbFleetFilter.TabIndex = 2;
            cmbFleetFilter.SelectedIndexChanged += cmbFleetFilter_SelectedIndexChanged;
            // 
            // txtFleetSearch
            // 
            txtFleetSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFleetSearch.Font = new Font("Segoe UI", 9.5F);
            txtFleetSearch.Location = new Point(177, 16);
            txtFleetSearch.Name = "txtFleetSearch";
            txtFleetSearch.PlaceholderText = "🔍 Search brand or model...";
            txtFleetSearch.Size = new Size(190, 24);
            txtFleetSearch.TabIndex = 1;
            txtFleetSearch.TextChanged += txtFleetSearch_TextChanged;
            // 
            // lblFleetTitle
            // 
            lblFleetTitle.AutoSize = true;
            lblFleetTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFleetTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblFleetTitle.Location = new Point(14, 18);
            lblFleetTitle.Name = "lblFleetTitle";
            lblFleetTitle.Size = new Size(153, 21);
            lblFleetTitle.TabIndex = 0;
            lblFleetTitle.Text = "🚘 Fleet Inventory";
            // 
            // addCarBox
            // 
            addCarBox.BackColor = Color.White;
            addCarBox.Controls.Add(btnAddCar);
            addCarBox.Controls.Add(lblAddRate);
            addCarBox.Controls.Add(numAddRate);
            addCarBox.Controls.Add(lblAddSeaters);
            addCarBox.Controls.Add(numAddSeaters);
            addCarBox.Controls.Add(txtAddPlate);
            addCarBox.Controls.Add(cmbAddCategory);
            addCarBox.Controls.Add(lblAddCustomCategory);
            addCarBox.Controls.Add(txtAddCustomCategory);
            addCarBox.Controls.Add(txtAddModel);
            addCarBox.Controls.Add(txtAddBrand);
            addCarBox.Controls.Add(lblAddCarTitle);
            addCarBox.Dock = DockStyle.Right;
            addCarBox.Location = new Point(547, 0);
            addCarBox.Margin = new Padding(12, 0, 0, 0);
            addCarBox.Name = "addCarBox";
            addCarBox.Padding = new Padding(16);
            addCarBox.Size = new Size(310, 634);
            addCarBox.TabIndex = 2;
            // 
            // btnAddCar
            // 
            btnAddCar.BackColor = Color.FromArgb(5, 150, 105);
            btnAddCar.Cursor = Cursors.Hand;
            btnAddCar.FlatAppearance.BorderSize = 0;
            btnAddCar.FlatStyle = FlatStyle.Flat;
            btnAddCar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnAddCar.ForeColor = Color.White;
            btnAddCar.Location = new Point(16, 292);
            btnAddCar.Name = "btnAddCar";
            btnAddCar.Size = new Size(275, 42);
            btnAddCar.TabIndex = 7;
            btnAddCar.Text = "➕ Register Vehicle";
            btnAddCar.UseVisualStyleBackColor = false;
            btnAddCar.Click += btnAddCar_Click;
            // 
            // lblAddRate
            // 
            lblAddRate.AutoSize = true;
            lblAddRate.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            lblAddRate.ForeColor = Color.FromArgb(51, 65, 85);
            lblAddRate.Location = new Point(155, 196);
            lblAddRate.Name = "lblAddRate";
            lblAddRate.Size = new Size(62, 15);
            lblAddRate.TabIndex = 8;
            lblAddRate.Text = "Rate / Day";
            // 
            // numAddRate
            // 
            numAddRate.DecimalPlaces = 2;
            numAddRate.Font = new Font("Segoe UI", 9.5F);
            numAddRate.Location = new Point(155, 214);
            numAddRate.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            numAddRate.Name = "numAddRate";
            numAddRate.Size = new Size(136, 24);
            numAddRate.TabIndex = 6;
            numAddRate.Value = new decimal(new int[] { 60, 0, 0, 0 });
            // 
            // lblAddSeaters
            // 
            lblAddSeaters.AutoSize = true;
            lblAddSeaters.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            lblAddSeaters.ForeColor = Color.FromArgb(51, 65, 85);
            lblAddSeaters.Location = new Point(16, 196);
            lblAddSeaters.Name = "lblAddSeaters";
            lblAddSeaters.Size = new Size(45, 15);
            lblAddSeaters.TabIndex = 9;
            lblAddSeaters.Text = "Seaters";
            // 
            // numAddSeaters
            // 
            numAddSeaters.Font = new Font("Segoe UI", 9.5F);
            numAddSeaters.Location = new Point(16, 214);
            numAddSeaters.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numAddSeaters.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numAddSeaters.Name = "numAddSeaters";
            numAddSeaters.Size = new Size(125, 24);
            numAddSeaters.TabIndex = 5;
            numAddSeaters.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // txtAddPlate
            // 
            txtAddPlate.Font = new Font("Segoe UI", 9.5F);
            txtAddPlate.Location = new Point(16, 250);
            txtAddPlate.Name = "txtAddPlate";
            txtAddPlate.PlaceholderText = "Plate Number (e.g. XYZ-9988)";
            txtAddPlate.Size = new Size(275, 24);
            txtAddPlate.TabIndex = 4;
            // 
            // cmbAddCategory
            // 
            cmbAddCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAddCategory.Font = new Font("Segoe UI", 9.5F);
            cmbAddCategory.FormattingEnabled = true;
            cmbAddCategory.Items.AddRange(new object[] { "Sedan", "SUV", "Luxury", "Sports", "Electric", "Other" });
            cmbAddCategory.Location = new Point(16, 112);
            cmbAddCategory.Name = "cmbAddCategory";
            cmbAddCategory.Size = new Size(275, 25);
            cmbAddCategory.TabIndex = 3;
            cmbAddCategory.SelectedIndexChanged += cmbAddCategory_SelectedIndexChanged;
            // 
            // lblAddCustomCategory
            // 
            lblAddCustomCategory.AutoSize = true;
            lblAddCustomCategory.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            lblAddCustomCategory.ForeColor = Color.FromArgb(51, 65, 85);
            lblAddCustomCategory.Location = new Point(16, 144);
            lblAddCustomCategory.Name = "lblAddCustomCategory";
            lblAddCustomCategory.Size = new Size(106, 15);
            lblAddCustomCategory.TabIndex = 10;
            lblAddCustomCategory.Text = "Custom Category *";
            lblAddCustomCategory.Visible = false;
            // 
            // txtAddCustomCategory
            // 
            txtAddCustomCategory.Font = new Font("Segoe UI", 9.5F);
            txtAddCustomCategory.Location = new Point(16, 162);
            txtAddCustomCategory.Name = "txtAddCustomCategory";
            txtAddCustomCategory.PlaceholderText = "Enter new category...";
            txtAddCustomCategory.Size = new Size(275, 24);
            txtAddCustomCategory.TabIndex = 8;
            txtAddCustomCategory.Visible = false;
            // 
            // txtAddModel
            // 
            txtAddModel.Font = new Font("Segoe UI", 9.5F);
            txtAddModel.Location = new Point(16, 78);
            txtAddModel.Name = "txtAddModel";
            txtAddModel.PlaceholderText = "Model (e.g. RAV4)";
            txtAddModel.Size = new Size(275, 24);
            txtAddModel.TabIndex = 2;
            // 
            // txtAddBrand
            // 
            txtAddBrand.Font = new Font("Segoe UI", 9.5F);
            txtAddBrand.Location = new Point(16, 44);
            txtAddBrand.Name = "txtAddBrand";
            txtAddBrand.PlaceholderText = "Brand (e.g. Toyota)";
            txtAddBrand.Size = new Size(275, 24);
            txtAddBrand.TabIndex = 1;
            // 
            // lblAddCarTitle
            // 
            lblAddCarTitle.AutoSize = true;
            lblAddCarTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblAddCarTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblAddCarTitle.Location = new Point(14, 14);
            lblAddCarTitle.Name = "lblAddCarTitle";
            lblAddCarTitle.Size = new Size(182, 20);
            lblAddCarTitle.TabIndex = 0;
            lblAddCarTitle.Text = "➕ Register New Vehicle";
            // 
            // panelRentals
            // 
            panelRentals.Controls.Add(gridRentals);
            panelRentals.Controls.Add(rentalsActionPanel);
            panelRentals.Controls.Add(rentalsHeaderPanel);
            panelRentals.Dock = DockStyle.Fill;
            panelRentals.Location = new Point(20, 20);
            panelRentals.Name = "panelRentals";
            panelRentals.Size = new Size(857, 634);
            panelRentals.TabIndex = 2;
            panelRentals.Visible = false;
            // 
            // gridRentals
            // 
            gridRentals.AllowUserToAddRows = false;
            gridRentals.AllowUserToDeleteRows = false;
            gridRentals.AllowUserToResizeRows = false;
            gridRentals.BackgroundColor = Color.White;
            gridRentals.BorderStyle = BorderStyle.None;
            gridRentals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridRentals.Dock = DockStyle.Fill;
            gridRentals.Location = new Point(0, 56);
            gridRentals.Name = "gridRentals";
            gridRentals.ReadOnly = true;
            gridRentals.RowHeadersVisible = false;
            gridRentals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridRentals.Size = new Size(857, 514);
            gridRentals.TabIndex = 1;
            // 
            // rentalsActionPanel
            // 
            rentalsActionPanel.BackColor = Color.White;
            rentalsActionPanel.Controls.Add(btnActivatePickup);
            rentalsActionPanel.Controls.Add(btnReturnCar);
            rentalsActionPanel.Controls.Add(lblRentalsNotice);
            rentalsActionPanel.Dock = DockStyle.Bottom;
            rentalsActionPanel.Location = new Point(0, 570);
            rentalsActionPanel.Name = "rentalsActionPanel";
            rentalsActionPanel.Padding = new Padding(14);
            rentalsActionPanel.Size = new Size(857, 64);
            rentalsActionPanel.TabIndex = 2;
            // 
            // btnActivatePickup
            // 
            btnActivatePickup.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnActivatePickup.BackColor = Color.FromArgb(37, 99, 235);
            btnActivatePickup.Cursor = Cursors.Hand;
            btnActivatePickup.FlatAppearance.BorderSize = 0;
            btnActivatePickup.FlatStyle = FlatStyle.Flat;
            btnActivatePickup.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnActivatePickup.ForeColor = Color.White;
            btnActivatePickup.Location = new Point(394, 12);
            btnActivatePickup.Name = "btnActivatePickup";
            btnActivatePickup.Size = new Size(236, 40);
            btnActivatePickup.TabIndex = 2;
            btnActivatePickup.Text = "🚘 Assign to Next Reserved";
            btnActivatePickup.UseVisualStyleBackColor = false;
            btnActivatePickup.Click += btnActivatePickup_Click;
            // 
            // btnReturnCar
            // 
            btnReturnCar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReturnCar.BackColor = Color.FromArgb(217, 119, 6);
            btnReturnCar.Cursor = Cursors.Hand;
            btnReturnCar.FlatAppearance.BorderSize = 0;
            btnReturnCar.FlatStyle = FlatStyle.Flat;
            btnReturnCar.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnReturnCar.ForeColor = Color.White;
            btnReturnCar.Location = new Point(640, 12);
            btnReturnCar.Name = "btnReturnCar";
            btnReturnCar.Size = new Size(200, 40);
            btnReturnCar.TabIndex = 1;
            btnReturnCar.Text = "🔑 Process Return / Check-In";
            btnReturnCar.UseVisualStyleBackColor = false;
            btnReturnCar.Click += btnReturnCar_Click;
            // 
            // lblRentalsNotice
            // 
            lblRentalsNotice.AutoSize = true;
            lblRentalsNotice.Font = new Font("Segoe UI", 9F);
            lblRentalsNotice.ForeColor = Color.FromArgb(100, 116, 139);
            lblRentalsNotice.Location = new Point(14, 16);
            lblRentalsNotice.MaximumSize = new Size(370, 0);
            lblRentalsNotice.Name = "lblRentalsNotice";
            lblRentalsNotice.Size = new Size(370, 30);
            lblRentalsNotice.TabIndex = 0;
            lblRentalsNotice.Text = "💡 Return an Active rental, then assign the Available car to the next Reserved client.";
            // 
            // rentalsHeaderPanel
            // 
            rentalsHeaderPanel.BackColor = Color.White;
            rentalsHeaderPanel.Controls.Add(lblRentalsTitle);
            rentalsHeaderPanel.Dock = DockStyle.Top;
            rentalsHeaderPanel.Location = new Point(0, 0);
            rentalsHeaderPanel.Name = "rentalsHeaderPanel";
            rentalsHeaderPanel.Padding = new Padding(14);
            rentalsHeaderPanel.Size = new Size(857, 56);
            rentalsHeaderPanel.TabIndex = 0;
            // 
            // lblRentalsTitle
            // 
            lblRentalsTitle.AutoSize = true;
            lblRentalsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRentalsTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblRentalsTitle.Location = new Point(14, 16);
            lblRentalsTitle.Name = "lblRentalsTitle";
            lblRentalsTitle.Size = new Size(261, 21);
            lblRentalsTitle.TabIndex = 0;
            lblRentalsTitle.Text = "📋 Active & Recent Rentals Ledger";
            // 
            // panelDatabase
            // 
            panelDatabase.Controls.Add(dbCard);
            panelDatabase.Dock = DockStyle.Fill;
            panelDatabase.Location = new Point(20, 20);
            panelDatabase.Name = "panelDatabase";
            panelDatabase.Size = new Size(857, 634);
            panelDatabase.TabIndex = 3;
            panelDatabase.Visible = false;
            // 
            // dbCard
            // 
            dbCard.BackColor = Color.Transparent;
            dbCard.Controls.Add(dbLogPanel);
            dbCard.Controls.Add(dbSettingsPanel);
            dbCard.Dock = DockStyle.Fill;
            dbCard.Location = new Point(0, 0);
            dbCard.Name = "dbCard";
            dbCard.Size = new Size(857, 634);
            dbCard.TabIndex = 0;
            // 
            // dbLogPanel
            // 
            dbLogPanel.BackColor = Color.FromArgb(18, 22, 28);
            dbLogPanel.Controls.Add(txtDbLog);
            dbLogPanel.Controls.Add(lblLogTitle);
            dbLogPanel.Dock = DockStyle.Fill;
            dbLogPanel.Location = new Point(360, 0);
            dbLogPanel.Margin = new Padding(14, 0, 0, 0);
            dbLogPanel.Name = "dbLogPanel";
            dbLogPanel.Padding = new Padding(16);
            dbLogPanel.Size = new Size(497, 634);
            dbLogPanel.TabIndex = 1;
            // 
            // txtDbLog
            // 
            txtDbLog.BackColor = Color.FromArgb(14, 18, 24);
            txtDbLog.BorderStyle = BorderStyle.None;
            txtDbLog.Dock = DockStyle.Fill;
            txtDbLog.Font = new Font("Consolas", 9.5F);
            txtDbLog.ForeColor = Color.FromArgb(226, 232, 240);
            txtDbLog.Location = new Point(16, 48);
            txtDbLog.Multiline = true;
            txtDbLog.Name = "txtDbLog";
            txtDbLog.ReadOnly = true;
            txtDbLog.ScrollBars = ScrollBars.Vertical;
            txtDbLog.Size = new Size(465, 570);
            txtDbLog.TabIndex = 5;
            // 
            // lblLogTitle
            // 
            lblLogTitle.Dock = DockStyle.Top;
            lblLogTitle.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblLogTitle.ForeColor = Color.FromArgb(110, 231, 183);
            lblLogTitle.Location = new Point(16, 16);
            lblLogTitle.Name = "lblLogTitle";
            lblLogTitle.Size = new Size(465, 32);
            lblLogTitle.TabIndex = 0;
            lblLogTitle.Text = "🖥️ Live SQL Diagnostic Console & Output";
            // 
            // dbSettingsPanel
            // 
            dbSettingsPanel.BackColor = Color.White;
            dbSettingsPanel.Controls.Add(btnGenerateSql);
            dbSettingsPanel.Controls.Add(btnTestDbInDash);
            dbSettingsPanel.Controls.Add(txtConnString);
            dbSettingsPanel.Controls.Add(lblDbSub);
            dbSettingsPanel.Controls.Add(lblDbTitle);
            dbSettingsPanel.Dock = DockStyle.Left;
            dbSettingsPanel.Location = new Point(0, 0);
            dbSettingsPanel.Name = "dbSettingsPanel";
            dbSettingsPanel.Padding = new Padding(20);
            dbSettingsPanel.Size = new Size(360, 634);
            dbSettingsPanel.TabIndex = 0;
            // 
            // btnGenerateSql
            // 
            btnGenerateSql.BackColor = Color.FromArgb(28, 35, 46);
            btnGenerateSql.Cursor = Cursors.Hand;
            btnGenerateSql.FlatAppearance.BorderSize = 0;
            btnGenerateSql.FlatStyle = FlatStyle.Flat;
            btnGenerateSql.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnGenerateSql.ForeColor = Color.White;
            btnGenerateSql.Location = new Point(18, 176);
            btnGenerateSql.Name = "btnGenerateSql";
            btnGenerateSql.Size = new Size(320, 38);
            btnGenerateSql.TabIndex = 4;
            btnGenerateSql.Text = "📋 Recommended Setup Script";
            btnGenerateSql.UseVisualStyleBackColor = false;
            btnGenerateSql.Click += btnGenerateSql_Click;
            // 
            // btnTestDbInDash
            // 
            btnTestDbInDash.BackColor = Color.FromArgb(5, 150, 105);
            btnTestDbInDash.Cursor = Cursors.Hand;
            btnTestDbInDash.FlatAppearance.BorderSize = 0;
            btnTestDbInDash.FlatStyle = FlatStyle.Flat;
            btnTestDbInDash.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnTestDbInDash.ForeColor = Color.White;
            btnTestDbInDash.Location = new Point(18, 128);
            btnTestDbInDash.Name = "btnTestDbInDash";
            btnTestDbInDash.Size = new Size(320, 38);
            btnTestDbInDash.TabIndex = 3;
            btnTestDbInDash.Text = "🔌 Test SQL Connection";
            btnTestDbInDash.UseVisualStyleBackColor = false;
            btnTestDbInDash.Click += btnTestDbInDash_Click;
            // 
            // txtConnString
            // 
            txtConnString.Font = new Font("Consolas", 9.5F);
            txtConnString.Location = new Point(18, 92);
            txtConnString.Name = "txtConnString";
            txtConnString.Size = new Size(320, 22);
            txtConnString.TabIndex = 2;
            // 
            // lblDbSub
            // 
            lblDbSub.Font = new Font("Segoe UI", 9F);
            lblDbSub.ForeColor = Color.FromArgb(100, 116, 139);
            lblDbSub.Location = new Point(18, 48);
            lblDbSub.Name = "lblDbSub";
            lblDbSub.Size = new Size(320, 36);
            lblDbSub.TabIndex = 1;
            lblDbSub.Text = "Configure connection to your SQL Server instance (e.g. RIAMU\\SQLEXPRESS - CarRentalDB)";
            // 
            // lblDbTitle
            // 
            lblDbTitle.AutoSize = true;
            lblDbTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblDbTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblDbTitle.Location = new Point(16, 18);
            lblDbTitle.Name = "lblDbTitle";
            lblDbTitle.Size = new Size(294, 25);
            lblDbTitle.TabIndex = 0;
            lblDbTitle.Text = "⚙️ SQL Server Database Settings";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 749);
            Controls.Add(mainContainerPanel);
            Controls.Add(topBarPanel);
            Controls.Add(sidebarPanel);
            MinimumSize = new Size(1000, 650);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "APEX MOTORS — Enterprise Fleet & Rental Management";
            sidebarPanel.ResumeLayout(false);
            brandPanel.ResumeLayout(false);
            brandPanel.PerformLayout();
            topBarPanel.ResumeLayout(false);
            topBarPanel.PerformLayout();
            mainContainerPanel.ResumeLayout(false);
            panelOverview.ResumeLayout(false);
            overviewFleetCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridOverviewFleet).EndInit();
            overviewStatsLayout.ResumeLayout(false);
            cardTotalCars.ResumeLayout(false);
            cardTotalCars.PerformLayout();
            cardAvailCars.ResumeLayout(false);
            cardAvailCars.PerformLayout();
            cardRentedCars.ResumeLayout(false);
            cardRentedCars.PerformLayout();
            cardRevenue.ResumeLayout(false);
            cardRevenue.PerformLayout();
            panelReservation.ResumeLayout(false);
            resSplitLayout.ResumeLayout(false);
            resSummaryCard.ResumeLayout(false);
            resSummaryCard.PerformLayout();
            resCostBox.ResumeLayout(false);
            resCostBox.PerformLayout();
            resFormCard.ResumeLayout(false);
            resFormCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numResDays).EndInit();
            panelFleet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridFleet).EndInit();
            fleetHeaderPanel.ResumeLayout(false);
            fleetHeaderPanel.PerformLayout();
            addCarBox.ResumeLayout(false);
            addCarBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAddRate).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAddSeaters).EndInit();
            panelRentals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridRentals).EndInit();
            rentalsActionPanel.ResumeLayout(false);
            rentalsActionPanel.PerformLayout();
            rentalsHeaderPanel.ResumeLayout(false);
            rentalsHeaderPanel.PerformLayout();
            panelDatabase.ResumeLayout(false);
            dbCard.ResumeLayout(false);
            dbLogPanel.ResumeLayout(false);
            dbLogPanel.PerformLayout();
            dbSettingsPanel.ResumeLayout(false);
            dbSettingsPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Label lblAddCustomCategory;
        private TextBox txtAddCustomCategory;
        private TextBox txtAddPlate;
        private NumericUpDown numAddRate;
        private Label lblAddRate;
        private NumericUpDown numAddSeaters;
        private Label lblAddSeaters;
        private Button btnAddCar;
        private Panel panelRentals;
        private Panel rentalsHeaderPanel;
        private Label lblRentalsTitle;
        private Button btnActivatePickup;
        private Button btnReturnCar;
        private Panel rentalsActionPanel;
        private Label lblRentalsNotice;
        private DataGridView gridRentals;
        private Panel panelDatabase;
        private Panel dbCard;
        private Panel dbSettingsPanel;
        private Panel dbLogPanel;
        private Label lblLogTitle;
        private Label lblDbTitle;
        private Label lblDbSub;
        private TextBox txtConnString;
        private Button btnTestDbInDash;
        private Button btnGenerateSql;
        private TextBox txtDbLog;
        private Panel panelReservation;
        private TableLayoutPanel resSplitLayout;
        private Panel resFormCard;
        private Label lblResFormTitle;
        private Label lblResFormSub;
        private Label lblResCustName;
        private TextBox txtResCustName;
        private Label lblResPhone;
        private TextBox txtResPhone;
        private Label lblResEmail;
        private TextBox txtResEmail;
        private Label lblResIdType;
        private ComboBox cmbResIdType;
        private Label lblResAddress;
        private TextBox txtResAddress;
        private Label lblResCar;
        private ComboBox cmbResCar;
        private Label lblResPickupDate;
        private DateTimePicker dtpResPickupDate;
        private Label lblResReturnDate;
        private DateTimePicker dtpResReturnDate;
        private Label lblResDays;
        private NumericUpDown numResDays;
        private Label lblResPickupLocation;
        private ComboBox cmbResPickupLocation;
        private Label lblResPaymentMethod;
        private ComboBox cmbResPaymentMethod;
        private Label lblResNotes;
        private TextBox txtResNotes;
        private Button btnResSubmit;
        private Button btnResClear;
        private Label lblResFeedback;
        private Panel resSummaryCard;
        private Label lblResSummaryTitle;
        private Panel resCostBox;
        private Label lblResVehicleSummary;
        private Label lblResScheduleSummary;
        private Label lblResTotalAmount;
    }
}
