using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStudy.Shop.DataAccess.DAO.Base;
using MyStudy.Shop.DataAccess.DAO.Interfaces;
using MyStudy.Shop.DataAccess.Entities;
using NHibernate;
using NHibernate.Criterion;

namespace MyStudy.Shop.DataAccess.DAO.Impl {
    class EmployeeDao : BaseDao<Employee>, IEmployeeDao {
        
        public EmployeeDao(ISession nhSession) : base(nhSession){}

        public IList<Employee> GetEmployees()
        {
            var employees = nHibernateSession.QueryOver<Employee>();
            employees.Cacheable();
            employees.OrderBy(e => e.Name).Asc();
            return employees.List<Employee>();
        }

        public Employee GetEmployeeById(long id)
        {
            var session = nHibernateSession;
            var query = session.QueryOver<Employee>();
            query.Cacheable();
            query.Take(1);
            query.Where(e => e.Id == id);
            return query.SingleOrDefault();
        }
    }
}
