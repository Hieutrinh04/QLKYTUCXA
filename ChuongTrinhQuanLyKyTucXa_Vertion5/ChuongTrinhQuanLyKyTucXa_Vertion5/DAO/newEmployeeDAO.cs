using ChuongTrinhQuanLyKyTucXa_Vertion5.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuongTrinhQuanLyKyTucXa_Vertion5.DAO
{
    public class newEmployeeDAO
    {
        private readonly appCONTEXT appContext;
        public newEmployeeDAO()
        {
            appContext = appCONTEXT.GetInstance();
        }
        
        public void insert(newEmployee employee)
        {
            appContext.newEmployees.InsertOnSubmit(employee);
            appContext.SubmitChanges();
        }

        public List<newEmployee> getEmployees() 
        {
            var list = appContext.newEmployees.ToList();
            return list;
        }

        public newEmployee GetEmployee(int id)
        {
            var employee = appContext.newEmployees.FirstOrDefault(e => e.id == id);
            return employee;
        }

        public List<newEmployee> getByWorking(string working) 
        {
            var list = (from e in appContext.newEmployees
                        where e.working == working
                        select e).ToList();
            return list;
        }

        public newEmployee findByMobile(long mobile)
        {
            var employee = appContext.newEmployees.FirstOrDefault(e => e.emobile == mobile);
            return employee;
        }

        public void update(newEmployee employee)
        {
            var passEmployee = GetEmployee(employee.id);
            if(passEmployee == null)
            {
                MessageBox.Show("Nhân viên không tòn tại");
            }
            else
            {
                passEmployee.ename = employee.ename;
                passEmployee.emobile = employee.emobile;
                passEmployee.epaddress = employee.epaddress;
                passEmployee.eidproof = employee.eidproof;
                passEmployee.efname = employee.efname;
                passEmployee.emname = employee.emname;
                passEmployee.edesignation = employee.edesignation;
                passEmployee.eemail = employee.eemail;
                passEmployee.working = employee.working;
                appContext.SubmitChanges();
            }

        }

        public void delete(int id)
        {
            var passEmployee = GetEmployee(id);
            if (passEmployee == null)
            {
                MessageBox.Show("Nhân viên không tòn tại");
            }
            else
            {
                appContext.newEmployees.DeleteOnSubmit(passEmployee);
                appContext.SubmitChanges();
            }
        }

    }
}
