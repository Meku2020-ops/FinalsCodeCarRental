namespace FinalsCode
{
    partial class Terms_and_Conditons
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Terms_and_Conditons));
            btnConfirm = new Button();
            btnCancel = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(301, 470);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(139, 38);
            btnConfirm.TabIndex = 0;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(145, 470);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(139, 38);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold);
            richTextBox1.Location = new Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(602, 452);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // Terms_and_Conditons
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(626, 549);
            Controls.Add(richTextBox1);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Name = "Terms_and_Conditons";
            Text = "Terms_and_Conditons";
            ResumeLayout(false);
        }

        #endregion

        private Button btnConfirm;
        private Button btnCancel;
        private RichTextBox richTextBox1;
    }
}