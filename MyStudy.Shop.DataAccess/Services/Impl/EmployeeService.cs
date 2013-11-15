using System.Collections.Generic;
using MyStudy.Shop.DataAccess.DAO.Interfaces;
using MyStudy.Shop.DataAccess.Entities;
using MyStudy.Shop.DataAccess.Services.Base;
using MyStydy.Shop.DataAccess.Services.Interfaces;
using NHibernate;

namespace MyStudy.Shop.DataAccess.Services.Impl {
    class EmployeeService : BaseService<Employee> ,IEmployeeService
    {

        private IEmployeeDao employeeDao; 

        public EmployeeService(ISession nhSession, IEmployeeDao employeeDao) : base(nhSession, employeeDao)
        {
            this.employeeDao = employeeDao;
        }

        public Employee GetEmployeeById(long id)
        {
            return this.employeeDao.GetEmployeeById(id);
        }

        public IList<Employee> GetEmployees()
        {
            return this.employeeDao.GetEmployees();
        }
    }
}
