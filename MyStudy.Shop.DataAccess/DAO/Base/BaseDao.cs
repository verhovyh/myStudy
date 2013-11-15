using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Criterion;

namespace MyStudy.Shop.DataAccess.DAO.Base {
    public class BaseDao {

        protected ISession nHibernateSession;

        protected BaseDao(ISession nhSession)
        {
            this.nHibernateSession = nhSession;
        }

        //protected IProjection CreateCoalesceNullToZeroProjection<T>(IProjection aggregateProjection)
        //    where T : class, ISaleStats {
        //    return Projections.SqlFunction("COALESCE", NHibernateUtil.Int64, aggregateProjection, Projections.Constant(0));
        //}

    }
}
