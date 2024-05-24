using ChuongTrinhQuanLyKyTucXa_Vertion5.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuongTrinhQuanLyKyTucXa_Vertion5.BUS
{
    public class employeeSalaryBUS
    {
        private employeeSalaryDAO salaryDAO;

        public employeeSalaryBUS()
        {
            salaryDAO = new employeeSalaryDAO();
        }
    }
}
