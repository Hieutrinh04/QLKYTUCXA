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
    public partial class AllEmployeeWorking : Form
    {
        string query;
        private newEmployeeBUS employeeBUS;
        public AllEmployeeWorking()
        {
            InitializeComponent();
            employeeBUS = new newEmployeeBUS();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AllEmployeeWorking_Load(object sender, EventArgs e)
        {
            List<newEmployee> list = employeeBUS.GetEmployees();
            guna2DataGridView1.DataSource = list;
            this.Location = new Point(545, 105);
        }
    }
}
