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
    public partial class LeavedEmployee : Form
    {
        function fn = new function();
            string query;
        private newEmployeeBUS employeeBUS;
        public LeavedEmployee()
        {
            InitializeComponent();
            employeeBUS = new newEmployeeBUS();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LeavedEmployee_Load(object sender, EventArgs e)
        {
            this.Location = new Point(545, 105);
            List<newEmployee> list = employeeBUS.getByWorking("No");
            guna2DataGridView1.DataSource = list;

        }
    }
}
