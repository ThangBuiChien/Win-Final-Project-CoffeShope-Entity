using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using Coffee_management_store.BL;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Coffee_management_store
{
    public partial class MainForm : Form
    {   
        bool Add;
        string err;
        public MainForm()
        {
            InitializeComponent();
           managementToolStripMenuItem.Enabled = false;
        }
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        #region Cao
        BLEmployee dbEmp = new BLEmployee();
        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeForm frmEmployee = new EmployeeForm();
            frmEmployee.ShowDialog();
           
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult answear;
            answear = MessageBox.Show("are you sure?", "Trả lời",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (answear == DialogResult.OK)
                Close();
        }
        #endregion
        #region dong 
        #region Customer
        BLCustomer dbCustomer = new BLCustomer();
        DataTable tbCustomer = null;
        void LoadDataCustomer()
        {
            try
            {
               /* tbCustomer = new DataTable();
                tbCustomer.Clear();
                DataSet dataSet = dbCustomer.GetCustomer();
                tbCustomer = dataSet.Tables[0];*/
                // push on data GRV
                dataGridViewCustomer.DataSource = dbCustomer.GetCustomer();
                // chang size table
                dataGridViewCustomer.AutoResizeColumns();
                //
                dataGridViewCustomer_CellContentClick(null, null);
            }
            catch
            {
                MessageBox.Show("Dose not take Data. Eror!!!");
            }
        }
        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeForm frmEmployee = new EmployeeForm();
            frmEmployee.ShowDialog();
        }

        private void ptbAdd_Click(object sender, EventArgs e)
        {

            try
            {
                string cID = CIDtxt.Text;
                string cName = txtcName.Text;

                string errorMessage;
                bool isSuccess = this.dbCustomer.AddCustomer(cID, cName, ref err);

                if (isSuccess)
                {
                    MessageBox.Show("Customer added successfully.");
                    LoadDataCustomer();
                }
                else
                {
                    MessageBox.Show($"Error adding customer: {err}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding customer: {ex.Message}");
            }
        }
        private void btLoaddataCustomer_Click(object sender, EventArgs e)
        {
            LoadDataCustomer();
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult answear;
            answear = MessageBox.Show("are you sure?", "Trả lời",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (answear == DialogResult.OK)
                Close();
        }

        private void dataGridViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridViewCustomer.CurrentCell.RowIndex;
            CIDtxt.Text = dataGridViewCustomer.Rows[r].Cells[0].Value.ToString();
            txtcName.Text = dataGridViewCustomer.Rows[r].Cells[1].Value.ToString();
        }
        #endregion
        #region Inventory
        DataTable tbInventory = null;
        BLInventory dbInventory = new BLInventory();
        void LoadDataInventory()
        {
            try
            {
                tbInventory = new DataTable();
                tbInventory.Clear();
                DataSet dataSet = dbInventory.GetInventory();
                tbInventory = dataSet.Tables[0];
                // push on data GRV
                dataGridViewInventory.DataSource = tbInventory;
                // chang size table
                dataGridViewInventory.AutoResizeColumns();



                //
                dataGridViewInventory_CellContentClick(null, null);

            }
            catch
            {
                MessageBox.Show("Dose not take Data. Eror!!!");
            }
        }
        private void ptbUpdateIV_Click(object sender, EventArgs e)
        {
            DialogResult answer;
            answer = MessageBox.Show("Are you sure you want to update?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (answer == DialogResult.OK)
            {
                try
                {
                    int rowIndex = dataGridViewInventory.CurrentCell.RowIndex;
                    string @dID = dataGridViewInventory.Rows[rowIndex].Cells[2].Value.ToString();
                    int @amount = Convert.ToInt32(tbIVAmount.Text);
                    int @buying_price = Convert.ToInt32(tbIVP.Text);
                    bool isSuccess = this.dbInventory.UpdateInventory(@dID, @amount, @buying_price, ref err);

                    if (isSuccess)
                    {
                        MessageBox.Show("Inventory updated successfully.");
                        LoadDataInventory();
                    }
                    else
                    {
                        MessageBox.Show($"Error updating inventory: {err}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating inventory: {ex.Message}");
                }
            }
        }
        private void ptbAddIV_Click(object sender, EventArgs e)
        {
                DialogResult answer;
                answer = MessageBox.Show("Are you sure you want to Add?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (answer == DialogResult.OK)
                {
                    try
                    {
                        string @dID = tbIVID.Text;
                        string @supID = tbIVSupplierld.Text;
                        int @amount = Convert.ToInt32(tbIVAmount.Text);
                        int @buying_price = Convert.ToInt32(tbIVP.Text);
                        bool isSuccess = this.dbInventory.AddInventory(@dID,@supID, @amount, @buying_price, ref err);

                        if (isSuccess)
                        {
                            MessageBox.Show("Inventory updated successfully.");
                            LoadDataInventory();
                        }
                        else
                        {
                            MessageBox.Show($"Error updating inventory: {err}");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating inventory: {ex.Message}");
                    }
                }
        }
        private void ptbDeleteIV_Click(object sender, EventArgs e)
        {
            DialogResult answear;
            answear = MessageBox.Show(" Are you sure delete ?", "answear", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (answear == DialogResult.OK)
            {
                try
                {
                    int r = dataGridViewInventory.CurrentCell.RowIndex;
                    string strInventoryID = dataGridViewInventory.Rows[r].Cells[2].Value.ToString();
                    bool isSuccess = this.dbInventory.DeleteInventory(strInventoryID, ref err);
                    if (isSuccess)
                    {
                        MessageBox.Show("Inventory  deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show($"Error deleting inventory : {err}");
                    }
                    LoadDataInventory();
                }
                catch
                {
                    MessageBox.Show(" error delete ");
                }
                finally
                {

                }
            }
        }
        private void dataGridViewInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridViewInventory.CurrentCell.RowIndex;
           tbIVAmount.Text = dataGridViewInventory.Rows[r].Cells[0].Value.ToString();
           tbIVP.Text = dataGridViewInventory.Rows[r].Cells[1].Value.ToString();
            tbIVID.Text = dataGridViewInventory.Rows[r].Cells[2].Value.ToString();
           tbIVSupplierld.Text = dataGridViewInventory.Rows[r].Cells[3].Value.ToString();
        }
        private void btExitFormInventory_Click(object sender, EventArgs e)
        {
            DialogResult answear;
            answear = MessageBox.Show("are you sure?", "Trả lời",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (answear == DialogResult.OK)
                Close();
        }
        private void btLoaddataIV_Click(object sender, EventArgs e)
        {
            LoadDataInventory();
        }
        #endregion

        #endregion

        #region Tien
        bool addmenu;
        BLMenu menu = new BLMenu();
        DataSet dsmenu = null;
        int m;
        DataSet dsivd = null;
        DataSet dsIv = null;
        DataSet dsSp = null;
        Invoice_DtBL ivd = new Invoice_DtBL();
        InvoiceBL iv = new InvoiceBL();
        SupplyBL sp = new SupplyBL();
        public void LoadInvoice_detail(string Iid)
        {
            try
            {
                /*DataTable dtivd = new DataTable();
                dtivd = new DataTable();
                dsivd = ivd.Loadinvoicedetail(Iid);
                dtivd = dsivd.Tables[0];*/
                DGVDetailOder.DataSource = ivd.Loadinvoicedetail(Iid);
                dataGridViewDetailInvoiceView.DataSource = ivd.Loadinvoicedetail(Iid);
            }
            catch (SqlException)
            {
                MessageBox.Show("Cant connect to Invoice detail");
            }
        }
        public void LoadSupply()
        {
            DataTable dtsp = new DataTable();
            dsSp = sp.LoadSupply();
            dtsp = dsSp.Tables[0];
            Supplygridview.DataSource = dtsp;
        }
        public void LoadInvoice()
        {
            try
            {
             /*   DataTable dtIv = new DataTable();
                dtIv = new DataTable();
                dsIv = iv.Loadinvoice();
                dtIv = dsIv.Tables[0];*/
                receiptgridview.DataSource = iv.Loadinvoice() ;

            }
            catch (SqlException)
            {
                MessageBox.Show("Cant connect to invoice");
            }
        }
        private void btDeleteINV_Click(object sender, EventArgs e)
        {

            DialogResult answear;
            answear = MessageBox.Show(" Are you sure delete ?", "answear", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (answear == DialogResult.OK)
            {
                try
                {
                    int r = receiptgridview.CurrentCell.RowIndex;
                    string strInvoiceID = receiptgridview.Rows[r].Cells[0].Value.ToString();
                    bool isSuccess = this.iv.DeleteInvoice(strInvoiceID, ref err);
                    if (isSuccess)
                    {
                        MessageBox.Show("Invoice  deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show($"Error deleting invvoice : {err}");
                    }
                    LoadInvoice();
                }
                catch
                {
                    MessageBox.Show(" error delete ");
                }
                finally
                {

                }
            }
        }
        public void LoadMenu()
        {
            try
            {
                /*DataTable dtmenu = new DataTable();
                dtmenu = new DataTable();
                dsmenu = menu.Loadmenu();
                dtmenu = dsmenu.Tables[0];*/
                menugridview.DataSource = menu.Loadmenu();
                menugridview.AutoResizeColumns();
                menugridview_CellClick(null, null);
                addmenu = false;
               
            }
            catch (SqlException)
            {
                MessageBox.Show("Cant connect to menu");
            }
        }
        private void menugridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            m = menugridview.CurrentCell.RowIndex;
            tbIDMenu.Text = menugridview.Rows[m].Cells[0].Value.ToString();
            tbNameMenu.Text = menugridview.Rows[m].Cells[1].Value.ToString();
            tbDesMenu.Text = menugridview.Rows[m].Cells[2].Value.ToString();
            tbIMGMenu.Text = menugridview.Rows[m].Cells[3].Value.ToString();
            tbPriceMenu.Text = menugridview.Rows[m].Cells[4].Value.ToString();
        }
        private void menugridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            m = menugridview.CurrentCell.RowIndex;
            tbIDMenu.Text = menugridview.Rows[m].Cells[0].Value.ToString();
            tbNameMenu.Text = menugridview.Rows[m].Cells[1].Value.ToString();
            tbDesMenu.Text = menugridview.Rows[m].Cells[2].Value.ToString();
            tbIMGMenu.Text = menugridview.Rows[m].Cells[3].Value.ToString();
            tbPriceMenu.Text = menugridview.Rows[m].Cells[4].Value.ToString();
        }
        private void btLoadMenu_Click(object sender, EventArgs e)
        {
            LoadMenu();
            menugridview.RowHeadersVisible = false;
            menugridview.AllowUserToResizeColumns = false;
            menugridview.AllowUserToResizeRows = false;

        }
        private void btUpdateMenu_Click(object sender, EventArgs e)
        {
            DialogResult answer;
            answer = MessageBox.Show("Are you sure you want to Update?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (answer == DialogResult.OK)
            {
                try
                {
                    string MenuID = tbIDMenu.Text;
                    string MenudrinkName = tbNameMenu.Text;
                    string MenuDes = tbDesMenu.Text;
                    string MenuImg = tbIMGMenu.Text;
                    int MenuPrice = Convert.ToInt32(tbPriceMenu.Text);

                    bool isSuccess = this.menu.updatemenu(MenuID, MenudrinkName, MenuDes, MenuImg, MenuPrice, ref err);

                    if (isSuccess)
                    {
                        MessageBox.Show("Inventory updated successfully.");
                        LoadMenu();
                    }
                    else
                    {
                        MessageBox.Show($"Error updating inventory: {err}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating inventory: {ex.Message}");
                }
            }
        }

        private void btAddMenu_Click(object sender, EventArgs e)
        {

            DialogResult answer;
            answer = MessageBox.Show("Are you sure you want to Add?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (answer == DialogResult.OK)
            {
                try
                {
                    string MenuID = tbIDMenu.Text;
                    string MenudrinkName = tbNameMenu.Text;
                    string MenuDes = tbDesMenu.Text;
                    string MenuImg = tbIMGMenu.Text;
                    int MenuPrice = Convert.ToInt32(tbPriceMenu.Text);

                    bool isSuccess = this.menu.addmenu(MenuID, MenudrinkName, MenuDes, MenuImg, MenuPrice, ref err);

                    if (isSuccess)
                    {
                        MessageBox.Show("Inventory updated successfully.");
                        LoadMenu();
                    }
                    else
                    {
                        MessageBox.Show($"Error updating inventory: {err}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating inventory: {ex.Message}");
                }
            }
        }
        private void btBackMenu_Click(object sender, EventArgs e)
        {
            LoadMenu();
        }

        private void btDeleteMenu_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Are you sure to delete this?", "Answer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    menu.deletemenu(this.tbIDMenu.Text, ref err);
                    LoadMenu();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Can't delete data! Error");
                return;
            }
        }

        private void btSaveMenu_Click(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(tbPriceMenu.Text);
            try
            {
                if (addmenu)
                {
                    menu.addmenu(this.tbIDMenu.Text, this.tbNameMenu.Text, this.tbDesMenu.Text, this.tbIMGMenu.Text, price, ref err);
                    MessageBox.Show("Done adding menu");
                }
                else
                {
                    menu.updatemenu(this.tbIDMenu.Text, this.tbNameMenu.Text, this.tbDesMenu.Text, this.tbIMGMenu.Text, price, ref err);
                    MessageBox.Show("Done updating menu");

                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Cant add or update menu to database");
            }
            LoadMenu();
        }
        #region Tien 2
        private void MainForm_Load_1(object sender, EventArgs e)
        {
            LoadInvoice();
            invoicegridview.RowHeadersVisible = false;
            receiptgridview.RowHeadersVisible = false;
            btnAdddrink.Enabled = false;
            btnDeleteInv.Enabled = false;
           /* DataTable dtmenu = new DataTable();
            dsmenu = menu.Loadmenu();
            dtmenu = dsmenu.Tables[0];*/
            invoicegridview.DataSource = menu.Loadmenu();
            /*DataTable tbE = new DataTable();
            tbE.Clear();
            DataSet dataSet = dbEmp.GetID_C_E();
            tbE = dataSet.Tables[0];*/
            dataGridViewID_C_E_order.DataSource = dbEmp.GetID_C_E();

        }
       
        private void dataGridViewInventory_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridViewInventory.CurrentCell.RowIndex;
            tbIVAmount.Text = dataGridViewInventory.Rows[r].Cells[0].Value.ToString();
            tbIVP.Text = dataGridViewInventory.Rows[r].Cells[1].Value.ToString();
            tbIVID.Text = dataGridViewInventory.Rows[r].Cells[2].Value.ToString();
            tbIVSupplierld.Text = dataGridViewInventory.Rows[r].Cells[3].Value.ToString();
        }

       
        private void invoicegridview_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int r = invoicegridview.CurrentCell.RowIndex;
            tbDrinkId.Text = invoicegridview.Rows[r].Cells[0].Value.ToString();
            tbDrinkN.Text = invoicegridview.Rows[r].Cells[1].Value.ToString();
            tbDrinkPrice.Text = invoicegridview.Rows[r].Cells[4].Value.ToString();
        }
        private void btAddInvoice_Click(object sender, EventArgs e)
        {
            txtIDorder.Enabled = false;
            ivd.AddIn(txtIDorder.Text, ref err);
            btnAdddrink.Enabled = true;
            btnDeleteInv.Enabled = true;
            btnaddInv.Enabled = false;
            LoadInvoice_detail(txtIDorder.Text);
            tbDrinkAmount.Text = "1";
            tbcp.Text = "0";
            
        }

        private void btnAdddrink_Click(object sender, EventArgs e)
        {
            int amount = Int32.Parse(tbDrinkAmount.Text);
            ivd.AddInDt(txtIDorder.Text, tbDrinkId.Text, amount, ref err);
            LoadInvoice_detail(txtIDorder.Text);
            tbDrinkAmount.Text = "1";
        }

        private void btnDeleteInv_Click_1(object sender, EventArgs e)
        {
            ivd.DelInDt(tbDrinkId.Text, ref err);
            LoadInvoice_detail(txtIDorder.Text);
        }

        private void btnFinishInv_Click_1(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtIDorder.Text) + 1;
            string delivery = "no";
            float cp = float.Parse(tbcp.Text);
            if (cbdelivery.Checked)
                delivery = "yes";
            ivd.UpCus(txtIDorder.Text, tbIDCustomer.Text, ref err);
            ivd.UpEmp(txtIDorder.Text, tbIDEmp.Text, ref err);
            ivd.UpCP(txtIDorder.Text, cp, ref err);
            ivd.FiInv(txtIDorder.Text, ref err);
            ivd.UpDeli(txtIDorder.Text, delivery, ref err);
            DGVDetailOder.DataSource = null;
            DGVDetailOder.Rows.Clear();
            btnaddInv.Enabled = true;
            txtIDorder.Enabled = true;
            btnAdddrink.Enabled = false;
            btnDeleteInv.Enabled = false;
            txtIDorder.Text = id.ToString();
            LoadInvoice();
        }

        private void btnCancelInv_Click_1(object sender, EventArgs e)
        {
            ivd.DelIn(txtIDorder.Text, ref err);
            DGVDetailOder.DataSource = null;
            DGVDetailOder.Rows.Clear();
            btnaddInv.Enabled = true;
            txtIDorder.Enabled = true;
            btnAdddrink.Enabled = false;
            btnDeleteInv.Enabled = false;
        }
        private void btnSp_Click_1(object sender, EventArgs e)
        {
            try {
                LoadSupply();
            } 
            catch
            {

            }
           

        }
        #endregion
        #endregion

        #region Thang
        #region monthlyPay

        BLMonthlyPay monthlyPay = new BLMonthlyPay();
        DataTable dtKhachHang = null;
        bool Them;
        void LoadDataMonthlyPay()
        {
            try
            {
                dtKhachHang = new DataTable();
                dtKhachHang.Clear();
                DataSet ds = monthlyPay.GetMonthlyPay();
                dtKhachHang = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dataGridViewMoneyPay.DataSource = dtKhachHang;
                // Thay đổi độ rộng cột
                dataGridViewMoneyPay.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                this.txtEID.ResetText();
                this.txtMonth.ResetText();
                this.txtPenalty.ResetText();
                this.txtDayAbsent.ResetText();
                this.txtTotalSalary.ResetText();
                //
                this.btDeleteMoneypay.Enabled = true;
                this.btChangeMoneypay.Enabled = true;
                this.btSaveMoneyPay.Enabled = false;
                this.btAddMoneypay.Enabled = true;
            }
            catch (SqlException)
            {
                MessageBox.Show("Can not take data!!!");
            }
        }
        private void btLoadDataMoneypay_Click_1(object sender, EventArgs e)
        {
            LoadDataMonthlyPay();
        }
        private void btAddMoneypay_Click(object sender, EventArgs e)
        {
            LoadDataMonthlyPay();
            this.txtEID.ResetText();
            this.txtMonth.ResetText();
            Them = true;
            this.btChangeMoneypay.Enabled = false;
            this.btDeleteMoneypay.Enabled = false;
            this.btAddMoneypay.Enabled = true;
            this.btSaveMoneyPay.Enabled = true;

        }

        private void btChangeMoneypay_Click(object sender, EventArgs e)
        {
           
            this.btSaveMoneyPay.Enabled = true;
            this.btDeleteMoneypay.Enabled = false;
            this.btAddMoneypay.Enabled = false;
            if (Add)
            {
                try
                {
                    // Thực hiện lệnh 
                    BLMonthlyPay blTp = new BLMonthlyPay();
                    blTp.updateMonlyPay(txtEID.Text, DateTime.Parse(txtMonth.Text), Int32.Parse(txtDayAbsent.Text),
                                    Int32.Parse(txtPenalty.Text), Int32.Parse(txtTotalSalary.Text), ref err);                    // Load lại dữ liệu trên DataGridView 
                    LoadDataMonthlyPay();
                    // Thông báo 
                    MessageBox.Show("Update Successfully!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Error!");
                }
            }
            else
            {
                // Thực hiện lệnh 
                BLMonthlyPay blTp = new BLMonthlyPay();
                blTp.updateMonlyPay(this.txtEID.Text, DateTime.Parse(this.txtMonth.Text), Int32.Parse(txtDayAbsent.Text),
                Int32.Parse(txtPenalty.Text), Int32.Parse(txtTotalSalary.Text), ref err);
            }
            // Load lại dữ liệu trên DataGridView 
            LoadDataMonthlyPay();
         
        }

        private void btDeleteMoneypay_Click(object sender, EventArgs e)
        {

            try
            {
                // Viết câu lệnh SQL 
                // Hiện thông báo xác nhận việc xóa mẫu tin 
                // Khai báo biến traloi 
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp 
                traloi = MessageBox.Show("Are you sure delete?", "Answear",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không? 
                if (traloi == DialogResult.Yes)
                {
                    monthlyPay.DeleteMonthlyPay(ref err, txtEID.Text, DateTime.Parse(txtMonth.Text));                    // Cập nhật lại DataGridView 
                    LoadDataMonthlyPay();
                    // Thông báo 
                    MessageBox.Show("Delete successfully!");
                }
                else
                {
                    // Thông báo 
                    MessageBox.Show("error delete!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show(" ERROR!");
            }
        }

        private void btSaveMoneyPay_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    // Thực hiện lệnh 
                    BLMonthlyPay blTp = new BLMonthlyPay();
                    blTp.addMonthlyPay(txtEID.Text, DateTime.Parse(txtMonth.Text), Int32.Parse(txtDayAbsent.Text),
                                    Int32.Parse(txtPenalty.Text), Int32.Parse(txtTotalSalary.Text), ref err);                    // Load lại dữ liệu trên DataGridView 
                    LoadDataMonthlyPay();
                    // Thông báo 
                    MessageBox.Show("Finsh!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                // Thực hiện lệnh 
                BLMonthlyPay blTp = new BLMonthlyPay();
                blTp.updateMonlyPay(this.txtEID.Text, DateTime.Parse(this.txtMonth.Text), Int32.Parse(txtDayAbsent.Text),
                Int32.Parse(txtPenalty.Text), Int32.Parse(txtTotalSalary.Text), ref err);
            }
            // Load lại dữ liệu trên DataGridView 
            LoadDataMonthlyPay();
           
        }

        private void btCancelMoneypay_Click(object sender, EventArgs e)
        {
            this.txtEID.ResetText();
            this.txtMonth.ResetText();
            this.txtPenalty.ResetText();
            this.txtDayAbsent.ResetText();
            this.txtTotalSalary.ResetText();

            this.btSaveMoneyPay.Enabled = false;
            this.btAddMoneypay.Enabled = true;
            this.btChangeMoneypay.Enabled = true;
            this.btDeleteMoneypay.Enabled = true;
        }

        private void dataGridViewMoneyPay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dataGridViewMoneyPay.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.txtEID.Text = dataGridViewMoneyPay.Rows[r].Cells[0].Value.ToString();
            this.txtMonth.Text = dataGridViewMoneyPay.Rows[r].Cells[1].Value.ToString();
            this.txtDayAbsent.Text = dataGridViewMoneyPay.Rows[r].Cells[2].Value.ToString();
            this.txtPenalty.Text = dataGridViewMoneyPay.Rows[r].Cells[3].Value.ToString();
            this.txtTotalSalary.Text = dataGridViewMoneyPay.Rows[r].Cells[4].Value.ToString();
        }
        //private void dataGridViewMoneyPay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    // Thứ tự dòng hiện hành 
        //    int r = dataGridViewMoneyPay.CurrentCell.RowIndex;
        //    // Chuyển thông tin lên panel 
        //    this.txtEID.Text =dataGridViewMoneyPay.Rows[r].Cells[0].Value.ToString();
        //    this.txtMonth.Text =dataGridViewMoneyPay.Rows[r].Cells[1].Value.ToString();
        //    this.txtDayAbsent.Text = dataGridViewMoneyPay.Rows[r].Cells[2].Value.ToString();
        //    this.txtPenalty.Text = dataGridViewMoneyPay.Rows[r].Cells[3].Value.ToString();
        //    this.txtTotalSalary.Text = dataGridViewMoneyPay.Rows[r].Cells[4].Value.ToString();
        //}
        #endregion

        #endregion

        private void Money_PayTab_Click_1(object sender, EventArgs e)
        {

        }
        private void label17_Click(object sender, EventArgs e)
        {

        }
        private void MenuTab_Click(object sender, EventArgs e)
        {

        }
        #region Cao function and Analist
        #region Account
        DataTable tbAccount = null;
        BLAccount dbAccount = new BLAccount();
        
        void LoadDataAccount()
        {
            try
            {
                /*tbAccount = new DataTable();
                tbAccount.Clear();
                DataSet dataSet = dbAccount.GetAccount();
                tbAccount = dataSet.Tables[0];*/
                // push on data GRV
                dataGridViewAccount.DataSource = dbAccount.GetAccount();
                // chang size table
                dataGridViewAccount.AutoResizeColumns();
                //
                dataGridViewAccount_CellContentClick(null, null);
                Add = true;
            }
            catch
            {
                MessageBox.Show("Dose not take Data. Eror!!!");
            }
        }
        private void dataGridViewAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridViewAccount.CurrentCell.RowIndex;
            tbEIDAccount.Text = dataGridViewAccount.Rows[r].Cells[0].Value.ToString();
            tbUserAccount.Text = dataGridViewAccount.Rows[r].Cells[1].Value.ToString();
            tbPassAccount.Text = dataGridViewAccount.Rows[r].Cells[2].Value.ToString();
            tbSTFAccount.Text = dataGridViewAccount.Rows[r].Cells[3].Value.ToString();
            tbEIDAccount.Text = dataGridViewAccount.Rows[r].Cells[0].Value.ToString();
            if(dataGridViewAccount.Rows[r].Cells[0].Value.ToString() == "1")
            {
                cbActiveAccount.Checked = true;
            }
            else { cbActiveAccount.Checked = false; }
        }
        private void btloadAccount_Click(object sender, EventArgs e)
        {
            LoadDataAccount();
        }
        private void btAddAccount_Click(object sender, EventArgs e)
        {
            DialogResult answear;
            answear = MessageBox.Show(" Are you sure Add ?", "answear", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (answear == DialogResult.OK)
            {
                try
                {

                    int active = 0;
                    bool isSuccess = this.dbAccount.AddAccount(tbEIDAccount.Text,tbUserAccount.Text,tbPassAccount.Text,tbSTFAccount.Text,active,ref err); ;
                    if (isSuccess)
                    {
                        MessageBox.Show("Add successfully.");
                    }
                    else
                    {
                        MessageBox.Show($"Error Add: {err}");
                    }
                    LoadDataAccount();

                }
                catch
                {
                    MessageBox.Show(" error Add ");
                }
                finally
                {

                }
            }
        }
        private void btUpdateAccount_Click(object sender, EventArgs e)
        {
            DialogResult answear;
            answear = MessageBox.Show(" Are you sure Add ?", "answear", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (answear == DialogResult.OK)
            {
                try
                {

                    int active = 0;
                    bool isSuccess = this.dbAccount.UpdateAccount(tbEIDAccount.Text, tbUserAccount.Text, tbPassAccount.Text, tbSTFAccount.Text, Convert.ToBoolean(active), ref err); ;
                    if (isSuccess)
                    {
                        MessageBox.Show("Add successfully.");
                    }
                    else
                    {
                        MessageBox.Show($"Error Add: {err}");
                    }
                    LoadDataAccount();

                }
                catch
                {
                    MessageBox.Show(" error Add ");
                }
                finally
                {

                }
            }
        }

        private void lbSearchDinkName_Click(object sender, EventArgs e)
        {
            try
            {
                string strDrinkName = tbFindNameDirnk.Text; ;
                invoicegridview.DataSource = this.dbAnalysis.SearchNameDirnk(strDrinkName, ref err);
            }
            catch
            {
                MessageBox.Show($"Error Find: {err}");
            }
            finally
            {
            }
        }
        #endregion

        #region Analysis
        BLAnalysis dbAnalysis = new BLAnalysis();
        private void dataGridViewID_C_E_order_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewID_C_E_order.CurrentRow != null && dataGridViewID_C_E_order.Rows.Count > 0)
                {
                    int r = dataGridViewID_C_E_order.CurrentCell.RowIndex;
                    if (dataGridViewID_C_E_order.Rows[r].Cells[1].Value != null)
                    {
                        if (dataGridViewID_C_E_order.Rows[r].Cells[1].Value.ToString() == "Customer")
                        {
                            tbIDCustomer.Text = dataGridViewID_C_E_order.Rows[r].Cells[0].Value?.ToString();
                        }
                        else if (dataGridViewID_C_E_order.Rows[r].Cells[1].Value.ToString() == "Employee")
                        {
                            tbIDEmp.Text = dataGridViewID_C_E_order.Rows[r].Cells[0].Value?.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }

        private void dataGridViewID_C_E_order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btEMPMSales_Click(object sender, EventArgs e)
        {
            dataGridViewAnalysis.DataSource = dbAnalysis.EmpMostSales(ref err);
        }
        private void btTopSalesIteam_Click(object sender, EventArgs e)
        {
            dataGridViewAnalysis.DataSource = dbAnalysis.TopSalesIteam(ref err);
        }
        private void btEMPCalculatePr_Click(object sender, EventArgs e)
        {
            dataGridViewAnalysis.DataSource = dbAnalysis.EMPCalculatePR(ref err);
        }
        private void btShopPR_Click(object sender, EventArgs e)
        {
            dataGridViewAnalysis.DataSource = dbAnalysis.ShopPR(ref err);
        }
        #endregion
        #endregion

        private void invoicegridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #region print Invoice
        private void receiptgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = receiptgridview.CurrentCell.RowIndex;
            tbIDI.Text = receiptgridview.Rows[r].Cells[0].Value.ToString();
           tbDateI.Text = receiptgridview.Rows[r].Cells[1].Value.ToString();
            tbNameCI.Text = receiptgridview.Rows[r].Cells[2].Value.ToString();
            tbCouponI.Text = receiptgridview.Rows[r].Cells[4].Value.ToString();
            tbDiscountI.Text = receiptgridview.Rows[r].Cells[6].Value.ToString();
            tbDelyveryI.Text = receiptgridview.Rows[r].Cells[7].Value.ToString();
            tbEIDI.Text = receiptgridview.Rows[r].Cells[8].Value.ToString();
           tbFinaltotalI.Text = receiptgridview.Rows[r].Cells[9].Value.ToString();
            LoadInvoice_detail(tbIDI.Text);
        }









        #endregion

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
           // LoginForm login = new LoginForm();
           // login.ShowDialog();
        }

        private void OrderTab_Click(object sender, EventArgs e)
        {

        }
    }
}
