using NewClassPractice05._03._2024.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewClassPractice05._03._2024.Services.Interfaces
{
    internal interface IEmployeeService
    {
        public Employee[] GetAll();
        public Employee GetById(int? id);
       
   
    }
}
