using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStudy.Shop.DataAccess.Entities;


namespace MyStydy.Shop.DataAccess.Services.Interfaces {
    interface IEmployeeService {
        Employee GetEmployeeById(int id);
        IList<Employee> GetEmployees();
    }
}
