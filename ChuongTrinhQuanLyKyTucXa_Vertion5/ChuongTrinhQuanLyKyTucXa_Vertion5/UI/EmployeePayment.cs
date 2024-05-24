using ChuongTrinhQuanLyKyTucXa_Version5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ChuongTrinhQuanLyKyTucXa_Version2
{
    public partial class EmployeePayment : Form
    {
        function fn = new function();
        String query;
        public EmployeePayment()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmployeePayment_Load(object sender, EventArgs e)
        {
            this.Location = new Point(545, 105);
            monthDateTime.Format = DateTimePickerFormat.Custom;
            monthDateTime.CustomFormat = "MMMM yyyy";
        }
        public void setDataGrid(Int64 mobile)
        {
            query = "SELECT*FROM employeeSalary WHERE mobileNo = " + mobile + "";
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtMobile.Text != "")
            {
                query = "select ename, eemail, edesignation from newEmployee where emobile = " + txtMobile.Text + "";
                DataSet ds = fn.GetData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtName.Text = ds.Tables[0].Rows[0][0].ToString();
                    txtEmail.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtDesignation.Text = ds.Tables[0].Rows[0][2].ToString();

                    setDataGrid(Int64.Parse(txtMobile.Text));
                }
                else
                {
                    MessageBox.Show("Hồ sơ không hợp lệ", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearAll();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số điện thoại", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnSalary_Click(object sender, EventArgs e)
        {

        }

        private void txtPayAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void monthDateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtDesignation_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalary_Click_1(object sender, EventArgs e)
        {
            if (txtMobile.Text != "" && txtPayAmount.Text != "")
            {
                query = "SELECT * FROM employeeSalary WHERE mobileNo = " + txtMobile.Text + " AND fmonth = '" + monthDateTime.Text + "'";
                DataSet ds = fn.GetData(query);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    Int64 mobile = Int64.Parse(txtMobile.Text);
                    string month = monthDateTime.Text;
                    Int64 amount = Int64.Parse(txtPayAmount.Text);
                    query = "INSERT INTO employeeSalary (mobileNo, fmonth, amount) VALUES ('" + mobile + "', '" + month + "', " + amount + ")";
                    fn.SetData(query, "Lương tháng " + monthDateTime.Text + " Đã trả là " + amount);
                    setDataGrid(mobile);
                } else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            clearAll();
        }
        public void clearAll()
        {
            txtMobile.Clear();
            txtName.Clear();
            txtPayAmount.Clear();
            txtDesignation.Clear();
            txtEmail.Clear();
            guna2DataGridView1.DataSource = 0;
            monthDateTime.ResetText();
        }
    }
}