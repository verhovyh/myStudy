using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;

namespace MyStudy.Shop.DataAccess.Services.Base {
    public abstract class BaseService
    {
        protected ISession nHibernateSession;

        protected BaseService(ISession nhSession)
        {
            this.nHibernateSession = nhSession;
        }
    }
}
