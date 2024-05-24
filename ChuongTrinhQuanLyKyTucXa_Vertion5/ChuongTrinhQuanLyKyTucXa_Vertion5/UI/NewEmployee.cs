using ChuongTrinhQuanLyKyTucXa_Version5;
using ChuongTrinhQuanLyKyTucXa_Vertion5.BUS;
using ChuongTrinhQuanLyKyTucXa_Vertion5.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuongTrinhQuanLyKyTucXa_Vertion5
{
    public partial class NewEmployee : Form
    {
        function fn = new function();
        private newEmployeeBUS employeeBUS;
        public NewEmployee()
        {
            InitializeComponent();
            employeeBUS = new newEmployeeBUS();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewEmployee_Load(object sender, EventArgs e)
        {
            this.Location = new Point(545, 105);
        }
        private void ClearFields()
        {
            txtMobile.Text = "";
            txtName.Text = "";
            txtFather.Text = "";
            txtMother.Text = "";
            txtEmail.Text = "";
            txtPermaner.Text = "";
            txtIdProof.Text = "";
            txtDesignation.SelectedIndex = -1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMobile.Text != "" && txtName.Text != "" && txtFather.Text != "" && txtMother.Text != "" && txtEmail.Text != "" && txtPermaner.Text != "" && txtIdProof.Text != "" && txtDesignation.SelectedIndex != -1)
            {
                try
                {
                    newEmployee employee = new newEmployee() { emobile = Int64.Parse(txtMobile.Text), efname = txtFather.Text, emname = txtMother.Text, eemail = txtEmail.Text, epaddress = txtPermaner.Text, eidproof = txtIdProof.Text, edesignation = txtDesignation.Text,ename = txtName.Text, working = "Yes" };
                    
                    employeeBUS.insert(employee);

                    MessageBox.Show("Thêm nhân viên thành công!");

                    ClearFields(); // Hàm này bạn tự định nghĩa để làm sạch các ô văn bản sau khi lưu thành công.
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin của nhân viên", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    
}
