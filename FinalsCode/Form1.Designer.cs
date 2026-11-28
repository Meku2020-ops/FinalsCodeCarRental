namespace FinalsCode
{
    partial class Form1
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
            mainPanel = new Panel();
            splitTable = new TableLayoutPanel();
            leftHeroPanel = new Panel();
            badgeLabel = new Label();
            titleLabel = new Label();
            subtitleLabel = new Label();
            featureListPanel = new Panel();
            feature1 = new Label();
            feature2 = new Label();
            feature3 = new Label();
            actionButtonPanel = new FlowLayoutPanel();
            btnGetStarted = new Button();
            btnTestConnection = new Button();
            lblStatus = new Label();
            rightPreviewPanel = new Panel();
            cardContainer = new Panel();
            cardTitle = new Label();
            cardSubtitle = new Label();
            fleetPreviewGrid = new DataGridView();
            statsPillPanel = new FlowLayoutPanel();
            pillTotal = new Label();
            pillAvailable = new Label();
            pillSupport = new Label();
            footerPanel = new Panel();
            footerLabel = new Label();
            mainPanel.SuspendLayout();
            splitTable.SuspendLayout();
            leftHeroPanel.SuspendLayout();
            featureListPanel.SuspendLayout();
            actionButtonPanel.SuspendLayout();
            rightPreviewPanel.SuspendLayout();
            cardContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fleetPreviewGrid).BeginInit();
            statsPillPanel.SuspendLayout();
            footerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(18, 22, 28);
            mainPanel.Controls.Add(splitTable);
            mainPanel.Controls.Add(footerPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(960, 580);
            mainPanel.TabIndex = 0;
            // 
            // splitTable
            // 
            splitTable.ColumnCount = 2;
            splitTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48F));
            splitTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52F));
            splitTable.Controls.Add(rightPreviewPanel, 0, 0);
            splitTable.Controls.Add(leftHeroPanel, 1, 0);
            splitTable.Dock = DockStyle.Fill;
            splitTable.Location = new Point(0, 0);
            splitTable.Name = "splitTable";
            splitTable.RowCount = 1;
            splitTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            splitTable.Size = new Size(960, 540);
            splitTable.TabIndex = 1;
            // 
            // leftHeroPanel
            // 
            leftHeroPanel.Controls.Add(badgeLabel);
            leftHeroPanel.Controls.Add(titleLabel);
            leftHeroPanel.Controls.Add(subtitleLabel);
            leftHeroPanel.Controls.Add(featureListPanel);
            leftHeroPanel.Controls.Add(actionButtonPanel);
            leftHeroPanel.Controls.Add(lblStatus);
            leftHeroPanel.Dock = DockStyle.Fill;
            leftHeroPanel.Location = new Point(464, 3);
            leftHeroPanel.Name = "leftHeroPanel";
            leftHeroPanel.Padding = new Padding(24, 40, 36, 20);
            leftHeroPanel.Size = new Size(493, 534);
            leftHeroPanel.TabIndex = 0;
            // 
            // badgeLabel
            // 
            badgeLabel.AutoSize = true;
            badgeLabel.BackColor = Color.FromArgb(6, 78, 59);
            badgeLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            badgeLabel.ForeColor = Color.FromArgb(110, 231, 183);
            badgeLabel.Location = new Point(48, 36);
            badgeLabel.Name = "badgeLabel";
            badgeLabel.Padding = new Padding(8, 4, 8, 4);
            badgeLabel.Size = new Size(205, 23);
            badgeLabel.TabIndex = 0;
            badgeLabel.Text = "⚡ APEX MOTORS LEASING & FLEET";
            // 
            // titleLabel
            // 
            titleLabel.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(44, 70);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(440, 95);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Next-Generation Mobility & Fleet Intelligence.";
            // 
            // subtitleLabel
            // 
            subtitleLabel.Font = new Font("Segoe UI", 10.5F);
            subtitleLabel.ForeColor = Color.FromArgb(160, 174, 192);
            subtitleLabel.Location = new Point(46, 172);
            subtitleLabel.Name = "subtitleLabel";
            subtitleLabel.Size = new Size(430, 52);
            subtitleLabel.TabIndex = 2;
            subtitleLabel.Text = "Streamlined reservations, automated rate calculations, and real-time fleet analytics unified in one enterprise console.";
            // 
            // featureListPanel
            // 
            featureListPanel.Controls.Add(feature1);
            featureListPanel.Controls.Add(feature2);
            featureListPanel.Controls.Add(feature3);
            featureListPanel.Location = new Point(46, 235);
            featureListPanel.Name = "featureListPanel";
            featureListPanel.Size = new Size(430, 96);
            featureListPanel.TabIndex = 3;
            // 
            // feature1
            // 
            feature1.Font = new Font("Segoe UI", 9.5F);
            feature1.ForeColor = Color.FromArgb(226, 232, 240);
            feature1.Location = new Point(0, 4);
            feature1.Name = "feature1";
            feature1.Size = new Size(420, 24);
            feature1.TabIndex = 0;
            feature1.Text = "✦  Instant Reservation Engine & Dynamic Daily Pricing";
            // 
            // feature2
            // 
            feature2.Font = new Font("Segoe UI", 9.5F);
            feature2.ForeColor = Color.FromArgb(226, 232, 240);
            feature2.Location = new Point(0, 32);
            feature2.Name = "feature2";
            feature2.Size = new Size(420, 24);
            feature2.TabIndex = 1;
            feature2.Text = "✦  Multi-Category Inventory & Seater Specification Control";
            // 
            // feature3
            // 
            feature3.Font = new Font("Segoe UI", 9.5F);
            feature3.ForeColor = Color.FromArgb(226, 232, 240);
            feature3.Location = new Point(0, 60);
            feature3.Name = "feature3";
            feature3.Size = new Size(420, 24);
            feature3.TabIndex = 2;
            feature3.Text = "✦  Direct SQL Server Database Architecture (CarRentalDB)";
            // 
            // actionButtonPanel
            // 
            actionButtonPanel.Controls.Add(btnGetStarted);
            actionButtonPanel.Controls.Add(btnTestConnection);
            actionButtonPanel.Location = new Point(46, 350);
            actionButtonPanel.Name = "actionButtonPanel";
            actionButtonPanel.Size = new Size(430, 60);
            actionButtonPanel.TabIndex = 4;
            // 
            // btnGetStarted
            // 
            btnGetStarted.BackColor = Color.FromArgb(5, 150, 105);
            btnGetStarted.Cursor = Cursors.Hand;
            btnGetStarted.FlatAppearance.BorderSize = 0;
            btnGetStarted.FlatStyle = FlatStyle.Flat;
            btnGetStarted.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnGetStarted.ForeColor = Color.White;
            btnGetStarted.Location = new Point(0, 0);
            btnGetStarted.Margin = new Padding(0, 0, 14, 0);
            btnGetStarted.Name = "btnGetStarted";
            btnGetStarted.Size = new Size(190, 48);
            btnGetStarted.TabIndex = 0;
            btnGetStarted.Text = "Launch Console  ➜";
            btnGetStarted.UseVisualStyleBackColor = false;
            btnGetStarted.Click += btnGetStarted_Click;
            // 
            // btnTestConnection
            // 
            btnTestConnection.BackColor = Color.FromArgb(28, 35, 46);
            btnTestConnection.Cursor = Cursors.Hand;
            btnTestConnection.FlatAppearance.BorderColor = Color.FromArgb(52, 64, 82);
            btnTestConnection.FlatStyle = FlatStyle.Flat;
            btnTestConnection.Font = new Font("Segoe UI", 9.5F);
            btnTestConnection.ForeColor = Color.FromArgb(226, 232, 240);
            btnTestConnection.Location = new Point(204, 0);
            btnTestConnection.Margin = new Padding(0);
            btnTestConnection.Name = "btnTestConnection";
            btnTestConnection.Size = new Size(180, 48);
            btnTestConnection.TabIndex = 1;
            btnTestConnection.Text = "⚡ Check Database";
            btnTestConnection.UseVisualStyleBackColor = false;
            btnTestConnection.Click += btnTestConnection_Click;
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Segoe UI", 9F);
            lblStatus.ForeColor = Color.FromArgb(160, 174, 192);
            lblStatus.Location = new Point(48, 420);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(428, 40);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Click 'Launch Console' to enter the fleet management dashboard.";
            // 
            // rightPreviewPanel
            // 
            rightPreviewPanel.Controls.Add(cardContainer);
            rightPreviewPanel.Dock = DockStyle.Fill;
            rightPreviewPanel.Location = new Point(3, 3);
            rightPreviewPanel.Name = "rightPreviewPanel";
            rightPreviewPanel.Padding = new Padding(36, 36, 16, 20);
            rightPreviewPanel.Size = new Size(455, 534);
            rightPreviewPanel.TabIndex = 1;
            // 
            // cardContainer
            // 
            cardContainer.BackColor = Color.FromArgb(26, 32, 42);
            cardContainer.Controls.Add(cardTitle);
            cardContainer.Controls.Add(cardSubtitle);
            cardContainer.Controls.Add(fleetPreviewGrid);
            cardContainer.Controls.Add(statsPillPanel);
            cardContainer.Dock = DockStyle.Fill;
            cardContainer.Location = new Point(16, 36);
            cardContainer.Name = "cardContainer";
            cardContainer.Padding = new Padding(20);
            cardContainer.Size = new Size(390, 478);
            cardContainer.TabIndex = 0;
            // 
            // cardTitle
            // 
            cardTitle.AutoSize = true;
            cardTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            cardTitle.ForeColor = Color.White;
            cardTitle.Location = new Point(18, 16);
            cardTitle.Name = "cardTitle";
            cardTitle.Size = new Size(177, 25);
            cardTitle.TabIndex = 0;
            cardTitle.Text = "🚘 Showroom Fleet";
            // 
            // cardSubtitle
            // 
            cardSubtitle.AutoSize = true;
            cardSubtitle.Font = new Font("Segoe UI", 9F);
            cardSubtitle.ForeColor = Color.FromArgb(148, 163, 184);
            cardSubtitle.Location = new Point(20, 44);
            cardSubtitle.Name = "cardSubtitle";
            cardSubtitle.Size = new Size(230, 15);
            cardSubtitle.TabIndex = 1;
            cardSubtitle.Text = "Real-time readiness and live fleet telemetry";
            // 
            // fleetPreviewGrid
            // 
            fleetPreviewGrid.AllowUserToAddRows = false;
            fleetPreviewGrid.AllowUserToDeleteRows = false;
            fleetPreviewGrid.AllowUserToResizeRows = false;
            fleetPreviewGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            fleetPreviewGrid.BackgroundColor = Color.FromArgb(18, 22, 28);
            fleetPreviewGrid.BorderStyle = BorderStyle.None;
            fleetPreviewGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            fleetPreviewGrid.Location = new Point(18, 72);
            fleetPreviewGrid.Name = "fleetPreviewGrid";
            fleetPreviewGrid.ReadOnly = true;
            fleetPreviewGrid.RowHeadersVisible = false;
            fleetPreviewGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            fleetPreviewGrid.Size = new Size(354, 310);
            fleetPreviewGrid.TabIndex = 2;
            fleetPreviewGrid.CellContentClick += fleetPreviewGrid_CellContentClick;
            // 
            // statsPillPanel
            // 
            statsPillPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            statsPillPanel.Controls.Add(pillTotal);
            statsPillPanel.Controls.Add(pillAvailable);
            statsPillPanel.Controls.Add(pillSupport);
            statsPillPanel.Location = new Point(18, 395);
            statsPillPanel.Name = "statsPillPanel";
            statsPillPanel.Size = new Size(354, 60);
            statsPillPanel.TabIndex = 3;
            statsPillPanel.Paint += statsPillPanel_Paint;
            // 
            // pillTotal
            // 
            pillTotal.AutoSize = true;
            pillTotal.BackColor = Color.FromArgb(20, 26, 34);
            pillTotal.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            pillTotal.ForeColor = Color.FromArgb(203, 213, 225);
            pillTotal.Location = new Point(3, 3);
            pillTotal.Margin = new Padding(3);
            pillTotal.Name = "pillTotal";
            pillTotal.Padding = new Padding(6, 4, 6, 4);
            pillTotal.Size = new Size(70, 23);
            pillTotal.TabIndex = 0;
            pillTotal.Text = "🚘 8 Fleet";
            // 
            // pillAvailable
            // 
            pillAvailable.AutoSize = true;
            pillAvailable.BackColor = Color.FromArgb(6, 78, 59);
            pillAvailable.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            pillAvailable.ForeColor = Color.FromArgb(167, 243, 208);
            pillAvailable.Location = new Point(79, 3);
            pillAvailable.Margin = new Padding(3);
            pillAvailable.Name = "pillAvailable";
            pillAvailable.Padding = new Padding(6, 4, 6, 4);
            pillAvailable.Size = new Size(93, 23);
            pillAvailable.TabIndex = 1;
            pillAvailable.Text = "\U0001f7e2 6 Available";
            pillAvailable.Click += pillAvailable_Click;
            // 
            // pillSupport
            // 
            pillSupport.AutoSize = true;
            pillSupport.BackColor = Color.FromArgb(45, 30, 10);
            pillSupport.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            pillSupport.ForeColor = Color.FromArgb(251, 191, 36);
            pillSupport.Location = new Point(178, 3);
            pillSupport.Margin = new Padding(3);
            pillSupport.Name = "pillSupport";
            pillSupport.Padding = new Padding(6, 4, 6, 4);
            pillSupport.Size = new Size(99, 23);
            pillSupport.TabIndex = 2;
            pillSupport.Text = "⚡ Instant Lease";
            // 
            // footerPanel
            // 
            footerPanel.BackColor = Color.FromArgb(12, 15, 20);
            footerPanel.Controls.Add(footerLabel);
            footerPanel.Dock = DockStyle.Bottom;
            footerPanel.Location = new Point(0, 540);
            footerPanel.Name = "footerPanel";
            footerPanel.Size = new Size(960, 40);
            footerPanel.TabIndex = 2;
            // 
            // footerLabel
            // 
            footerLabel.Dock = DockStyle.Fill;
            footerLabel.Font = new Font("Segoe UI", 8.5F);
            footerLabel.ForeColor = Color.FromArgb(110, 125, 145);
            footerLabel.Location = new Point(0, 0);
            footerLabel.Name = "footerLabel";
            footerLabel.Padding = new Padding(24, 0, 0, 0);
            footerLabel.Size = new Size(960, 40);
            footerLabel.TabIndex = 0;
            footerLabel.Text = "Apex Motors Enterprise Mobility Platform  |  Event-Driven Architecture  |  CarRentalDB Active";
            footerLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 580);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "APEX MOTORS — Enterprise Fleet & Rental Management";
            mainPanel.ResumeLayout(false);
            splitTable.ResumeLayout(false);
            leftHeroPanel.ResumeLayout(false);
            leftHeroPanel.PerformLayout();
            featureListPanel.ResumeLayout(false);
            actionButtonPanel.ResumeLayout(false);
            rightPreviewPanel.ResumeLayout(false);
            cardContainer.ResumeLayout(false);
            cardContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fleetPreviewGrid).EndInit();
            statsPillPanel.ResumeLayout(false);
            statsPillPanel.PerformLayout();
            footerPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private TableLayoutPanel splitTable;
        private Panel leftHeroPanel;
        private Label badgeLabel;
        private Label titleLabel;
        private Label subtitleLabel;
        private Panel featureListPanel;
        private Label feature1;
        private Label feature2;
        private Label feature3;
        private FlowLayoutPanel actionButtonPanel;
        private Button btnGetStarted;
        private Button btnTestConnection;
        private Label lblStatus;
        private Panel rightPreviewPanel;
        private Panel cardContainer;
        private Label cardTitle;
        private Label cardSubtitle;
        private DataGridView fleetPreviewGrid;
        private FlowLayoutPanel statsPillPanel;
        private Label pillTotal;
        private Label pillAvailable;
        private Label pillSupport;
        private Panel footerPanel;
        private Label footerLabel;
    }
}
