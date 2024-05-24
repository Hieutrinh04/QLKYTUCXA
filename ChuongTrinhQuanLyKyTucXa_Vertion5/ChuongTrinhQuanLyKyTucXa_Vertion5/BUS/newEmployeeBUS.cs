using ChuongTrinhQuanLyKyTucXa_Vertion5.DAO;
using ChuongTrinhQuanLyKyTucXa_Vertion5.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuongTrinhQuanLyKyTucXa_Vertion5.BUS
{
    public class newEmployeeBUS
    {
        private readonly newEmployeeDAO employeeDAO;
        public newEmployeeBUS()
        {
            this.employeeDAO = new newEmployeeDAO();
        }   

        public void insert(newEmployee newEmployee)
        {
            employeeDAO.insert(newEmployee);
        }

        public List<newEmployee> GetEmployees() 
        {
            return employeeDAO.getEmployees();
        }

        public List<newEmployee> getByWorking(string working)
        {
            return employeeDAO.getByWorking(working);
        }

        public newEmployee FindByMobile(long mobile)
        {
            return employeeDAO.findByMobile(mobile);
        }

        public void update(newEmployee newEmployee)
        {
            employeeDAO.update(newEmployee);
        }

        public void delete(int id)
        {
            employeeDAO.delete(id);
        }
    }
}
