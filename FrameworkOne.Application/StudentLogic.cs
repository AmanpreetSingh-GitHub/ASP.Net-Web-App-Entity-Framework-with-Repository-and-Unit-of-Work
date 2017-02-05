using FrameworkOne.Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrameworkOne.Model;
using FrameworkOne.Repository.Interface;
using FrameworkOne.Domain;

namespace FrameworkOne.Application
{
    public class StudentLogic : IStudentLogic
    {
        private IUnitOfWork unitOfWork;
        private IGenericRepository<Student> studentRepository;

        public StudentLogic(IUnitOfWork unitOfWork, IGenericRepository<Student> studentRepository)
        {
            this.unitOfWork = unitOfWork;
            this.studentRepository = studentRepository;
        }

        public List<StudentModel> GetData()
        {
            List<Student> students = studentRepository.GetAll().ToList();

            List<StudentModel> studentModels = new List<StudentModel>();
            foreach (Student student in students)
            {
                StudentModel studentModel = new StudentModel()
                {
                    StudentId = student.StudentId,
                    Name = student.Name
                };

                studentModels.Add(studentModel);
            }

            return studentModels;
        }

        public void SaveData(StudentModel studentModel)
        {
            Student student = new Student() { StudentId = studentModel.StudentId, Name = studentModel.Name };
            studentRepository.Insert(student);

            this.unitOfWork.Save();
        }

        public void Dispose()
        {
            this.unitOfWork.Dispose();
        }
    }
}