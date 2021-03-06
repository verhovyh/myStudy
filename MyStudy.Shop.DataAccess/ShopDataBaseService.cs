﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStudy.Shop.DataAccess.DAO.Impl;
using MyStudy.Shop.DataAccess.DAO.Interfaces;
using MyStudy.Shop.DataAccess.Entities;
using MyStudy.Shop.DataAccess.Services.Impl;
using MyStydy.Shop.DataAccess.Services.Interfaces;
using NHibernate;

namespace MyStudy.Shop.DataAccess {
    
    class ShopDataBaseService : IShopDatabaseService
    {
        private IEmployeeService employeeService;

        private IEmployeeDao employeeDao;

        public ShopDataBaseService(ISession nhSession)
        {
            this.employeeDao = new EmployeeDao(nhSession);
            this.employeeService = new EmployeeService(nhSession, employeeDao);
        }

        public Employee GetEmployeeById(long id)
        {
            return this.employeeService.GetEmployeeById(id);
        }

        public IList<Employee> GetEmployees()
        {
            return this.employeeService.GetEmployees();
        }
    }
}
