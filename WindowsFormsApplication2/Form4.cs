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
using WindowsFormsApplication2.Models;
using WindowsFormsApplication2.Properties;


namespace WindowsFormsApplication2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        // Order Number
        public string OrderNumber { get; set; }

        // Is Update
        public bool IsUpdate { get; set; }

        public enum PaymentTypes
        {
            Cash = 1,
            CreditCard = 2
        }
        private List<CartItem> shoppingCart = new List<CartItem>();
        private int numberOfItemsPerPage = 0;
        private int numberOfItemsPrintedSoFar = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time1.Text = DateTime.Now.ToShortTimeString();
            date2.Text = DateTime.Now.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginNew1DataSet2.Drugs' table. You can move, or remove it, as needed.
            this.drugsTableAdapter.Fill(this.appData.Drugs);
            drugsBindingSource.DataSource = this.appData.Drugs;

            txtBrandName.SelectedValueChanged -= txtBrandName_SelectedValueChanged;

            txtBrandName.DataSource = GetDrugsName();
            txtBrandName.DisplayMember = "BrandName";
            txtBrandName.ValueMember = "DrugID";

            txtBrandName.SelectedIndex = -1;

            txtBrandName.SelectedValueChanged += txtBrandName_SelectedValueChanged;



        }

        private DataTable GetDrugsName()
        {
            DataTable dtDrugs = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["WindowsFormsApplication2.Properties.Settings.LoginNew1ConnectionString"].ConnectionString;

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                using (OleDbCommand cmd = new OleDbCommand("SELECT DrugID, BrandName FROM Drugs", conn))
                {
                    conn.Open();

                    OleDbDataReader reader = cmd.ExecuteReader();

                    dtDrugs.Load(reader);
                }
            }


            return dtDrugs;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            this.Hide();
            f6.Show();
        }

        private void NewOrderbtn_Click(object sender, EventArgs e)
        {
            string orderNumber;
            bool isOrderNumAlreadyExist = true;

            while (isOrderNumAlreadyExist)
            {
                orderNumber = GenerateOrderNumber();

                isOrderNumAlreadyExist = CheckIfOrderNumberExists(orderNumber);

                txtOrderNumber.Text = orderNumber;
            }


            NewOrderbtn.Enabled = false;
            PrintOrderbtn.Enabled = true;
            PrintPreviewbtn.Enabled = true;
            CancelOrderbtn.Enabled = true;

            ItemGroupBox.Enabled = true;
            
        }

        private bool CheckIfOrderNumberExists(string orderNumber)
        {
            bool doesOrderNumberExist = false;

            string connstring = ConfigurationManager.ConnectionStrings["WindowsFormsApplication2.Properties.Settings.LoginNew1ConnectionString"].ConnectionString;

            using (OleDbConnection conn = new OleDbConnection(connstring))
            {
                using (OleDbCommand cmd = new OleDbCommand("SELECT * FROM Orders WHERE [OrderNumber]=@OrderNumber", conn))
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@OrderNumber", orderNumber);

                    DataTable dtAnyData = new DataTable();

                    OleDbDataReader reader = cmd.ExecuteReader();

                    dtAnyData.Load(reader);

                    if (dtAnyData.Rows.Count > 0)
                    {
                        doesOrderNumberExist = true;
                    }
                }
            }

            return doesOrderNumberExist;
        }

        private string GenerateOrderNumber()
        {
            string orderNumber;

            // JI-XXXXX-XXXX
            Random rnd = new Random();
            long orderpart1 = rnd.Next(100000, 999999);
            int orderpart2 = rnd.Next(1000, 9999);

            orderNumber = "JI-" + orderpart1 + "-" + orderpart2;

            return orderNumber;
        }

        private void CancelOrderbtn_Click(object sender, EventArgs e)
        {
            NewOrderbtn.Enabled = true;
            PrintOrderbtn.Enabled = false;
            PrintPreviewbtn.Enabled = false;
            CancelOrderbtn.Enabled = false;
            btnDiscount.Enabled = false;
            ItemGroupBox.Enabled = false;

           
            txtBrandName.SelectedIndex = -1;
            txtQuantity.Clear();
            txtUnitPrice.Clear();
            txtCurrentStock.Clear();
            txtOrderNumber.Clear();

            txtTotalAmount.Text = "0";
            txtSalesTax.Text = "0";
            txtTotalPay.Text = "0";
            txtTotalDiscount.Text = "0";

            // Update Stock Level

            UpdateStocks();

            CartGridView.DataSource = null;
            shoppingCart.Clear();

            //Disable Buttons
            btnCash.Enabled = false;
            btnDiscount.Enabled = false;
        }

        private void UpdateStocks()
        {
            foreach (DataGridViewRow row in CartGridView.Rows)
            {
                int DrugID = Convert.ToInt16(row.Cells["DrugID"].Value);
                int Quantity = Convert.ToInt16(row.Cells["Quantity"].Value) * -1;
                UpdateStockLevel(DrugID, Quantity);
            }
        }

        private void txtChange_TextChanged(object sender, EventArgs e)
        {

        }




        private void btnAddToCart_Click(object sender, EventArgs e)
        {


            if (IsValidated())
            {

                if (Convert.ToInt16(txtQuantity.Text.Trim()) > Convert.ToInt16(txtCurrentStock.Text))
                {
                    MessageBox.Show("Quantity can't be greater than current amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool hasSameProductSelectedAgain = false;

                foreach (DataGridViewRow row in CartGridView.Rows)
                {
                    if (Convert.ToInt16(row.Cells["DrugID"].Value) == Convert.ToInt16(txtBrandName.SelectedValue))
                    {
                        row.Cells["Quantity"].Value = Convert.ToInt16(row.Cells["Quantity"].Value) + Convert.ToInt16(txtQuantity.Text);
                        row.Cells["TotalPrice"].Value = Convert.ToInt16(row.Cells["Quantity"].Value) * Convert.ToDecimal(row.Cells["UnitPrice"].Value);
                        hasSameProductSelectedAgain = true;
                    }
                }

                if (hasSameProductSelectedAgain == false)
                {
                    CartItem item = new CartItem()
                    {
                        DrugID = Convert.ToInt16(txtBrandName.SelectedValue),
                        BrandName = txtBrandName.Text,
                        Quantity = Convert.ToInt16(txtQuantity.Text.Trim()),
                        UnitPrice = Convert.ToDecimal(txtUnitPrice.Text.Trim()),


                        TotalPrice = Convert.ToInt16(txtQuantity.Text.Trim()) * Convert.ToDecimal(txtUnitPrice.Text.Trim())

                    };

                    //Array, Collection, List, DataTable and DataSet
                    shoppingCart.Add(item);
                    CartGridView.DataSource = null;
                    CartGridView.DataSource = shoppingCart;

                }


                decimal totalAmount = shoppingCart.Sum(x => x.TotalPrice);
                txtTotalAmount.Text = totalAmount.ToString();

                decimal totalSalesTax = (16 * totalAmount) / 100;
                txtSalesTax.Text = totalSalesTax.ToString();

                decimal totalPay = totalAmount + totalSalesTax;
                txtTotalPay.Text = totalPay.ToString();





                // Update stock
                int DrugID = Convert.ToInt16(txtBrandName.SelectedValue);
                int Quantity = Convert.ToInt16(txtQuantity.Text);
                UpdateStockLevel(DrugID, Quantity);

                txtBrandName.SelectedIndex = -1;
                txtQuantity.Clear();
                txtUnitPrice.Clear();
                txtCurrentStock.Clear();

                // Enable buttons
                btnCash.Enabled = true;
                btnDiscount.Enabled = true;
            }

        }

        private void UpdateStockLevel(int DrugID, int Quantity)
        {
            string connstring = ConfigurationManager.ConnectionStrings["WindowsFormsApplication2.Properties.Settings.LoginNew1ConnectionString"].ConnectionString;

            using (OleDbConnection conn = new OleDbConnection(connstring))
            {
                using (OleDbCommand cmd = new OleDbCommand("UPDATE Drugs SET [Amount]=[Amount]-@Quantity WHERE DrugID=@ID", conn))
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@Quantity", Quantity);
                    cmd.Parameters.AddWithValue("@ID", DrugID);

                    cmd.ExecuteNonQuery();


                }

            }
        }

        private bool IsValidated()
        {
            

            if (txtBrandName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Brand Name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBrandName.Focus();
                return false;
            }
            if (txtQuantity.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Quantity is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
                return false;
            }
            else
            {
                int tempQuantity;
                bool isNumeric = int.TryParse(txtQuantity.Text.Trim(), out tempQuantity);

                if (!isNumeric)
                {
                    MessageBox.Show("Quantity should be integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQuantity.Clear();
                    txtQuantity.Focus();
                    return false;
                }
            }
            if (txtUnitPrice.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Unit Price is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUnitPrice.Focus();
                return false;
            }

            else
            {
                decimal n;
                bool isDecimal = decimal.TryParse(txtUnitPrice.Text.Trim(), out n);

                if (!isDecimal)
                {
                    MessageBox.Show("Unit Price should be decimal value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUnitPrice.Clear();
                    txtUnitPrice.Focus();
                    return false;
                }
            }


            return true;

        }




        private void CartGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                var hti = CartGridView.HitTest(e.X, e.Y);
                CartGridView.Rows[hti.RowIndex].Selected = true;

                contextMenuStrip1.Show(CartGridView, e.X, e.Y);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = CartGridView.CurrentCell.RowIndex;

            //Update Stock Level
            int DrugID = Convert.ToInt16(CartGridView.Rows[index].Cells["DrugID"].Value);
            int Quantity = Convert.ToInt16(CartGridView.Rows[index].Cells["Quantity"].Value) * -1;
            UpdateStockLevel(DrugID, Quantity);

            shoppingCart.RemoveAt(index);

            CartGridView.DataSource = null;
            CartGridView.DataSource = shoppingCart;

            decimal totalAmount = shoppingCart.Sum(x => x.TotalPrice);
            txtTotalAmount.Text = totalAmount.ToString();

            decimal totalSalesTax = (16 * totalAmount) / 100;
            txtSalesTax.Text = totalSalesTax.ToString();

            decimal totalPay = totalAmount + totalSalesTax;
            txtTotalPay.Text = totalPay.ToString();



            if (shoppingCart.Count <= 0)
            {
                btnCash.Enabled = false;
                btnDiscount.Enabled = false;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image image = Properties.Resources.Capture1;

            e.Graphics.DrawImage(image, 150, 0, image.Width, image.Height);

            e.Graphics.DrawString("Date:" + DateTime.Now.ToShortDateString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 110));

            

            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 190));

            e.Graphics.DrawString("Brand Name: " + txtBrandName.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 210));
            e.Graphics.DrawString("Quantity " + txtBrandName.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(320, 210));
            e.Graphics.DrawString("Unit Price " + txtBrandName.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(500, 210));
            e.Graphics.DrawString("Total Price " + txtBrandName.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(650, 210));

            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 220));

            int yPos = 240;

            for (int i = numberOfItemsPrintedSoFar; i < shoppingCart.Count; i++)
            {
                numberOfItemsPerPage++;

                if (numberOfItemsPerPage <= 25)
                {
                    numberOfItemsPrintedSoFar++;

                    if (numberOfItemsPrintedSoFar <= shoppingCart.Count)
                    {
                        e.Graphics.DrawString(shoppingCart[i].BrandName, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, yPos));

                        e.Graphics.DrawString(shoppingCart[i].Quantity.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(350, yPos));

                        e.Graphics.DrawString(shoppingCart[i].UnitPrice.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(525, yPos));

                        e.Graphics.DrawString(shoppingCart[i].TotalPrice.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(665, yPos));

                        yPos += 30;
                    }
                    else
                    {
                        e.HasMorePages = false;
                    }
                }
                else
                {
                    numberOfItemsPerPage = 0;
                    e.HasMorePages = true;
                    return;
                }


            }

            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, yPos));

            e.Graphics.DrawString("Total Amount:      ₱" + txtTotalAmount.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(590, yPos + 30));
            e.Graphics.DrawString("Sales Tax (16%): ₱" + txtSalesTax.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(590, yPos + 60));
            e.Graphics.DrawString("Total to Pay:        ₱" + txtTotalPay.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(590, yPos + 90));

            // reset the variables
            numberOfItemsPerPage = 0;
            numberOfItemsPrintedSoFar = 0;
        }

        private void PrintPreviewbtn_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void PrintOrderbtn_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void txtBrandName_SelectedValueChanged(object sender, EventArgs e)
        {
            if (txtBrandName.SelectedValue != null)
            {
                int DrugID = Convert.ToInt16(txtBrandName.SelectedValue);

                DataTable dtPrice = GetDrugDetails(DrugID);
                DataRow row = dtPrice.Rows[0];


                txtUnitPrice.Text = row["Price"].ToString();
                txtCurrentStock.Text = row["Amount"].ToString();
            }
        }

        private DataTable GetDrugDetails(int DrugID)
        {
            DataTable dtDrugDetails = new DataTable();
            string connstring = ConfigurationManager.ConnectionStrings["WindowsFormsApplication2.Properties.Settings.LoginNew1ConnectionString"].ConnectionString;

            using (OleDbConnection conn = new OleDbConnection(connstring))
            {
                using (OleDbCommand cmd = new OleDbCommand("SELECT Price, Amount FROM Drugs WHERE DrugID=@ID", conn))
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@ID", DrugID);

                    // ExecuteReader (Result), ExecuteNoQuery(Insert, Update, Delete) And ExecuteScalar
                    OleDbDataReader reader = cmd.ExecuteReader();

                    dtDrugDetails.Load(reader);
                }

            }
            return dtDrugDetails;
        }

        private void changeQuantityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = CartGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);


            using (ChangeQuantityForm cqf = new ChangeQuantityForm())
            {

                cqf.CurrentQuantity = Convert.ToInt16(CartGridView.Rows[index].Cells["Quantity"].Value);
                if (cqf.ShowDialog() == DialogResult.OK)
                {
                    CartGridView.Rows[index].Cells["Quantity"].Value = cqf.NewQuantity;
                    CartGridView.Rows[index].Cells["TotalPrice"].Value = cqf.NewQuantity * Convert.ToDecimal(CartGridView.Rows[index].Cells["UnitPrice"].Value);

                    UpdateStockLevel(Convert.ToInt16(CartGridView.Rows[index].Cells["DrugID"].Value), cqf.NewQuantity - cqf.CurrentQuantity);

                }
            }
            decimal totalAmount = shoppingCart.Sum(x => x.TotalPrice);
            txtTotalAmount.Text = totalAmount.ToString();

            decimal totalSalesTax = (16 * totalAmount) / 100;
            txtSalesTax.Text = totalSalesTax.ToString();

            decimal totalPay = totalAmount + totalSalesTax;
            txtTotalPay.Text = totalPay.ToString();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateStocks();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            SaveOrder((int)PaymentTypes.Cash);
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtTotalPay.Text) <= 0)
            {
                MessageBox.Show("Order first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int i = 4;
                
                decimal totalDiscount = Convert.ToDecimal(txtTotalPay.Text) - 5;
                txtTotalPay.Text = totalDiscount.ToString();
                i++;
                txtTotalDiscount.Text = i.ToString();
               
            }
        }

        private void SaveOrder(int paymentType)
        {
            OleDbTransaction trans = null;

            try
            {
                string connstring = ConfigurationManager.ConnectionStrings["WindowsFormsApplication2.Properties.Settings.LoginNew1ConnectionString"].ConnectionString;

                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    conn.Open();

                    trans = conn.BeginTransaction();

                    using (OleDbCommand cmd = new OleDbCommand("INSERT INTO [Orders](OrderNumber,TransactionDate,TotalAmount,SalesTax,TotalToPay,PaymentType,Discount) VALUES(@OrderNumber,@TransactionDate,@TotalAmount,@SalesTax,@TotalToPay,@PaymentType,@Discount)", conn))
                    {
                        cmd.Transaction = trans;

                        cmd.Parameters.AddWithValue("@OrderNumber", txtOrderNumber.Text);
                        cmd.Parameters.AddWithValue("@TransactionDate", TransactionDateDateTimePicker1.Value.Date);
                        
                        cmd.Parameters.AddWithValue("@TotalAmount", Convert.ToDecimal(txtTotalAmount.Text));
                        cmd.Parameters.AddWithValue("@SalesTax", Convert.ToDecimal(txtSalesTax.Text));
                        cmd.Parameters.AddWithValue("@TotalToPay", Convert.ToDecimal(txtTotalPay.Text));
                        cmd.Parameters.AddWithValue("@PaymentType", paymentType);
                        cmd.Parameters.AddWithValue("@Discount", Convert.ToDecimal(txtTotalDiscount.Text));
                        cmd.ExecuteNonQuery();
                    }


                    foreach (DataGridViewRow row in CartGridView.Rows)
                    {
                        using (OleDbCommand cmd = new OleDbCommand("INSERT INTO [OrdersItems](OrderNumber,DrugID,Quantity,UnitPrice,TotalPrice) VALUES(@OrderNumber,@DrugID,@Quantity,@UnitPrice,@TotalPrice)", conn))
                        {
                            cmd.Transaction = trans;

                            cmd.Parameters.AddWithValue("@OrderNumber", txtOrderNumber.Text);
                            cmd.Parameters.AddWithValue("@DrugID", Convert.ToInt16(row.Cells["DrugID"].Value));
                            cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt16(row.Cells["Quantity"].Value));
                            cmd.Parameters.AddWithValue("@UnitPrice", Convert.ToDecimal(row.Cells["UnitPrice"].Value));
                            cmd.Parameters.AddWithValue("@TotalPrice", Convert.ToDecimal(row.Cells["TotalPrice"].Value));

                            cmd.ExecuteNonQuery();
                        }
                    }

                    // commit the transaction
                    trans.Commit();

                    MessageBox.Show("Order is processed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear Screen for next order
                    ClearScreenForNextOrder();

                }
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        private void ClearScreenForNextOrder()
        {
            NewOrderbtn.Enabled = true;
            PrintOrderbtn.Enabled = false;
            PrintPreviewbtn.Enabled = false;
            CancelOrderbtn.Enabled = false;
            btnDiscount.Enabled = false;
            ItemGroupBox.Enabled = false;

           
            txtBrandName.SelectedIndex = -1;
            txtQuantity.Clear();
            txtUnitPrice.Clear();
            txtCurrentStock.Clear();
            txtOrderNumber.Clear();

            txtTotalAmount.Text = "0";
            txtSalesTax.Text = "0";
            txtTotalPay.Text = "0";
            txtTotalDiscount.Text = "0";



            CartGridView.DataSource = null;
            shoppingCart.Clear();

            //Disable Buttons
            btnCash.Enabled = false;
            btnDiscount.Enabled = false;
        }

        
    }
}


