using NewClassPractice05._03._2024.Models;
using NewClassPractice05._03._2024.Services;
using NewClassPractice05._03._2024.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewClassPractice05._03._2024.Controllers
{
    internal class EmployeeController
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController()
        {
            _employeeService = new EmployeeService();
        }

        public void GetAll()
        {
            Employee [] employees= _employeeService.GetAll();
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Name}  {employee.Surname} {employee.Age} {employee.Birthday} {employee.Email} {employee.Address} ");
            }
        }
    
        public void GetById(int? id = null)
        {
                Employee employee = _employeeService.GetById(2);
            Console.WriteLine($"{employee.Name} {employee.Surname}");
        }
    
    }
}
