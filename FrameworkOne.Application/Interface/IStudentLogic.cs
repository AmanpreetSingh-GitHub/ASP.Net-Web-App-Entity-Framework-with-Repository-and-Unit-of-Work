using FrameworkOne.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkOne.Application.Interface
{
    public interface IStudentLogic
    {
        List<StudentModel> GetData();

        void SaveData(StudentModel studentModel);

        void Dispose();
    }
}