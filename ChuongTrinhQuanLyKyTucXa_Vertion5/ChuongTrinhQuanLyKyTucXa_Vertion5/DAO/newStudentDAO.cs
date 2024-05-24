using ChuongTrinhQuanLyKyTucXa_Vertion5.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuongTrinhQuanLyKyTucXa_Vertion5.DAO
{
    public class newStudentDAO
    {
        private readonly appCONTEXT appContext;
        public newStudentDAO()
        {
            appContext = appCONTEXT.GetInstance();
        }
        
        public List<newStudent> GetStudents()
        {
            var students = appContext.newStudents.ToList();

            return students;
        }

        public newStudent GetStudent(int id)
        {
            var student = appContext.newStudents.FirstOrDefault(s => s.id == id);
            return student;
        }

        public List<newStudent> GetByLiving(string living) 
        {
            var list = (from student in appContext.newStudents
                        where student.living == living select student).ToList();
            return list;
        }

        public void insert(newStudent student)
        {
            appContext.newStudents.InsertOnSubmit(student);
            appContext.SubmitChanges();
        }
        public void update(newStudent student)
        {
            var passStudent = GetStudent(student.id);
            if (passStudent == null) 
            {
                MessageBox.Show("Sinh viên không tồn tại!");
            }
            else
            {
                passStudent.email = student.email;
                passStudent.paddress    = student.paddress;
                passStudent.mobile = student.mobile;
                passStudent.roomNo = student.roomNo;
                passStudent.college = student.college;
                passStudent.fname = student.fname;
                passStudent.name = student.name;
                passStudent.mname = student.mname;
                passStudent.idproof = student.idproof;
                passStudent.living = student.living;
                appContext.SubmitChanges();
            }
        }

        public void delete(newStudent student)
        {
            appContext.newStudents.DeleteOnSubmit(student);
            appContext.SubmitChanges();
        }

    }
}
