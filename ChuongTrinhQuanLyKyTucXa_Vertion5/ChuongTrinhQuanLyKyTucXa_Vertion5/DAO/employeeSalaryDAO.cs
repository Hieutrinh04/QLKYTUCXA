using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuongTrinhQuanLyKyTucXa_Vertion5.DAO
{
    public class employeeSalaryDAO
    {
        private readonly appCONTEXT appContext;
        public employeeSalaryDAO()
        {
            appContext = appCONTEXT.GetInstance();
        }
    }
}
