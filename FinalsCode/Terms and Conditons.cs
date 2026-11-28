using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalsCode
{
    public partial class Terms_and_Conditons : Form
    {
        public Terms_and_Conditons()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e){
        }
    }
}
