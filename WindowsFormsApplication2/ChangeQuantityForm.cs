using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class ChangeQuantityForm : Form
    {
        public ChangeQuantityForm()
        {
            InitializeComponent();
        }
        public int CurrentQuantity { get; set; }
        public int NewQuantity { get; set; }
        public bool HasValidationFailed { get; set; }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.Show();
            
        }

        private void ChangeQuantityForm_Load(object sender, EventArgs e)
        {
            QuantityTextBox.Text = CurrentQuantity.ToString();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (isValidated())
            {
                NewQuantity = Convert.ToInt16(QuantityTextBox.Text);
                HasValidationFailed = false;
            }
        }

        private bool isValidated()
        {
            if (QuantityTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Add New Quantity First.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                QuantityTextBox.Clear();
                QuantityTextBox.Focus();
                HasValidationFailed = true;
                return false;
            }

            int result = 0;
            bool isNumeric = int.TryParse(QuantityTextBox.Text.Trim(), out result);
            if (!isNumeric)
            {
                MessageBox.Show("Quantity should be integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                QuantityTextBox.Clear();
                QuantityTextBox.Focus();
                HasValidationFailed = true;
                return false;
            } 

            return true;
        }

        private void ChangeQuantityForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = HasValidationFailed;
        }
    }
}
