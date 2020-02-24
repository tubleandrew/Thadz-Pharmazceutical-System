using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToShortTimeString();
            date.Text = DateTime.Now.ToShortDateString();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            this.Hide();
            f5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            LoadAllOrdersIntoDataGridView();
        }

        private void LoadAllOrdersIntoDataGridView()
        {
            OrdersDataGridView.DataSource = GetAllOrders();
        }

        private DataTable GetAllOrders()
        {
            DataTable dtOrders = new DataTable();

            string connstring = ConfigurationManager.ConnectionStrings["WindowsFormsApplication2.Properties.Settings.LoginNew1ConnectionString"].ConnectionString;

            using (OleDbConnection conn = new OleDbConnection(connstring))
            {
                using (OleDbCommand cmd = new OleDbCommand("SELECT [OrderNumber], [TransactionDate], [TotalAmount], [SalesTax], [TotalToPay], [Discount] FROM [Orders] ", conn))
                {
                    conn.Open();

                    OleDbDataReader reader = cmd.ExecuteReader();

                    dtOrders.Load(reader);
                }
            }
            return dtOrders;
        }

        private void OrdersDataGridView_DoubleClick(object sender, EventArgs e)
        {
            int index = OrdersDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            // string orderNumber = OrdersDataGridView.Rows[index].Cells   
            string orderNumber = OrdersDataGridView.Rows[index].Cells["OrderNumber"].Value.ToString();
            ShowMainScreen(orderNumber, true);
        }

        private void ShowMainScreen(string orderNumber, bool isUpdate)
        {
            Form4 f4 = new Form4();
            f4.OrderNumber = orderNumber;
            f4.IsUpdate = isUpdate;
            f4.ShowDialog();

            LoadAllOrdersIntoDataGridView();
        }

        private void OrdersDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            int index = OrdersDataGridView.CurrentCell.RowIndex;
            if (e.KeyCode == Keys.Delete)
            {
                
            }
        }

        private void OrdersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
