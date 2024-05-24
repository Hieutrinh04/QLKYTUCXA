using ChuongTrinhQuanLyKyTucXa_Vertion5.DAO;
using ChuongTrinhQuanLyKyTucXa_Vertion5.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuongTrinhQuanLyKyTucXa_Vertion5.BUS
{
    public class newStudentBUS
    {
        private newStudentDAO studentDAO;

        public newStudentBUS()
        {
            studentDAO = new newStudentDAO();
        }

        public List<newStudent> GetStudents()
        {
            return studentDAO.GetStudents(); 
        }

        public List<newStudent> GetByLiving(string living) 
        {
            return studentDAO.GetByLiving(living);
        }

        public void AddStudent(newStudent student)
        {
            studentDAO.insert(student);
        }

        public void UpdateStudent(newStudent student)
        {
            studentDAO.update(student);
        }

        public void DeleteStudent(newStudent student)
        {
            studentDAO.delete(student);
        }

    }
}
