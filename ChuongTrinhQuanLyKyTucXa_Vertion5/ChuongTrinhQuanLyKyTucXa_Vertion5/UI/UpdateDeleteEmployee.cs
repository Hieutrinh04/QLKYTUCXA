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

namespace ChuongTrinhQuanLyKyTucXa_Version5

{
    public partial class UpdateDeleteEmployee : Form
    {

        private newEmployeeBUS employeeBUS;

        public UpdateDeleteEmployee()
        {
            InitializeComponent();
            employeeBUS = new newEmployeeBUS();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1()
        {
            txtWorking.Items.Add("Yes");
            txtWorking.Items.Add("No");
        }

        private void UpdateDeleteEmployee_Load(object sender, EventArgs e)
        {
            this.Location = new Point(545, 105);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMobile.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            newEmployee employee = employeeBUS.FindByMobile(int.Parse(txtMobile.Text));


            if (employee != null)
            {
                txtName.Text = employee.ename;
                txtFather.Text = employee.efname;
                txtMother.Text = employee.emname;
                txtEmail.Text = employee.eemail;
                txtPermaner.Text = employee.epaddress;
                txtIdProof.Text = employee.eidproof;
                txtDesignation.Text = employee.edesignation;
                if(employee.working != null){
                    if (employee.working.Equals("Yes", StringComparison.InvariantCultureIgnoreCase))
                    {
                        txtWorking.SelectedIndex = 0;
                    }
                    else txtWorking.SelectedIndex = 1;
                }
            }
            else
            {
                MessageBox.Show("Số điện thoại này không tồn tại!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearAll();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            Int64 mobile = Int64.Parse(txtMobile.Text); String name = txtName.Text;
            String fname = txtFather.Text;
            String mname = txtMother.Text;
            String id = txtIdProof.Text;
            String email = txtEmail.Text;
            String paddress = txtPermaner.Text;
            String designation= txtDesignation.Text;
            String working = txtWorking.SelectedIndex.ToString();

            newEmployee employee = employeeBUS.FindByMobile(Int64.Parse(txtMobile.Text));

            newEmployee updateEmployee = new newEmployee() { id = employee.id, working = working, emobile = mobile, eidproof = id, edesignation = designation, eemail = email, efname = fname, ename = name, emname = mname, epaddress = paddress };

            employeeBUS.update(updateEmployee);
            MessageBox.Show("Cập nhật thành công!");
            
        }
        private void clearAll()
        {

            txtMobile.Clear();
            txtName.Clear();
            txtFather.Clear();
            txtMother.Clear();
            txtEmail.Clear();
            txtPermaner.Clear();
            txtIdProof.Clear();
            txtDesignation.SelectedIndex = -1;
            txtWorking.SelectedIndex = -1;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning ) == DialogResult.Yes)
                {
                newEmployee employee = employeeBUS.FindByMobile(long.Parse(txtMobile.Text));
                employeeBUS.delete(employee.id);
                MessageBox.Show("Đã xóa hồ sơ");
                clearAll();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

    }
}