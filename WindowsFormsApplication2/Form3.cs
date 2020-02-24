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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
            panel2.Visible = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToShortTimeString();
            date.Text = DateTime.Now.ToShortDateString();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'loginNew1DataSet2.Drugs' table. You can move, or remove it, as needed.
            this.drugsTableAdapter.Fill(this.appData.Drugs);
            drugsBindingSource.DataSource = this.appData.Drugs;

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.BackColor = Color.Red;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
        }

        

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)13)
            {
                if (string.IsNullOrEmpty(txtSearch.Text))
                {
                    this.drugsTableAdapter.Fill(this.appData.Drugs);
                    drugsBindingSource.DataSource = this.appData.Drugs;
                    //dataGridView1.DataSource = drugsBindingSource;
                }
                   
                else
                {
                    var query = from o in this.appData.Drugs
                                where o.BrandName.Contains(txtSearch.Text)||o.Format == txtSearch.Text||o.Amount == txtSearch.Text||o.Category == (txtSearch.Text)
                                select o;
                    drugsBindingSource.DataSource = query.ToList();
                }
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    drugsBindingSource.RemoveCurrent();
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {                       
            
                try
                {
                    btnAdd.Enabled = false;
                    panel2.Visible = true;
                    panel2.Enabled = true;
                    btnDelete.Enabled = true;
                    btnSave.Enabled = true;

                    txtBrandName.Focus();
                    
                    this.appData.Drugs.AddDrugsRow(this.appData.Drugs.NewDrugsRow());
                    drugsBindingSource.MoveLast();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    drugsBindingSource.ResetBindings(false);
                }           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            panel2.Visible = true;
            panel2.Enabled = true;
            btnSave.Enabled = true;
            txtBrandName.Focus();
            this.Validate();
            drugsTableAdapter.Update(this.appData.Drugs);
            
        }

                    
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text == "" || txtBrandName.Text == "" || txtCategory.Text == "" || txtFormat.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("A field is empty!");
            }
            else
            {
                try
                {
                    btnAdd.Enabled = true;
                    panel2.Visible = false;
                    this.Validate();
                    drugsBindingSource.EndEdit();
                    drugsTableAdapter.Update(this.appData.Drugs);
                    panel2.Enabled = false;
                    btnSave.Enabled = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    drugsBindingSource.ResetBindings(false);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            this.Hide();
            f5.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you want to cancel adding this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                drugsBindingSource.RemoveCurrent();
                panel2.Enabled = false;
                btnDelete.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            this.Hide();
            f6.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = sender as DateTimePicker;
            DateTime today = DateTime.Today.Date;
            if (dateTimePicker1.Value <= today)
            {
                MessageBox.Show("You are not allowed to select older day than today!");
                //unregister the handler first
                dtp.ValueChanged -= dateTimePicker1_ValueChanged;
                //set the value
                dateTimePicker1.Value = DateTime.Today.Date;
                //register handler again
                dtp.ValueChanged += dateTimePicker1_ValueChanged;
            }
            else
            {

            }
        }
    }
}
