﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStudy.Shop.DataAccess.DAO.Base;
using MyStudy.Shop.DataAccess.Entities;

namespace MyStudy.Shop.DataAccess.DAO.Interfaces {
    interface IEmployeeDao : IBaseDao<Employee>
    {
        IList<Employee> GetEmployees();
        Employee GetEmployeeById(long id);
    }
}
