using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStudy.Shop.DataAccess.Entities.Base;
using NHibernate;

namespace MyStudy.Shop.DataAccess.DAO.Base {
    public abstract class BaseDao<TModel> : BaseDao, IBaseDao<TModel>
    where TModel : class, IEntity {
        protected BaseDao(ISession nhSession)
            : base(nhSession) {
        }

        public TModel GetById(long id) {
            return this.nHibernateSession.Get(typeof(TModel), id) as TModel;
        }

        public void Delete(TModel item) {
            this.nHibernateSession.Delete(item);
            nHibernateSession.Flush();
        }

        public void DeleteList(IList<TModel> items) {
            foreach (var item in items) {
                this.Delete(item);
            }
        }

        public void Write(TModel item) {
            this.WriteItem(item);
            nHibernateSession.Flush();
        }


        public void WriteList(IList<TModel> items) {
            foreach (var item in items) {
                this.WriteItem(item);
            }
            nHibernateSession.Flush();
        }

        private void WriteItem(TModel item) {
            if (item.Id > 0) {
                this.nHibernateSession.Update(item, item.Id);
            } else {
                this.nHibernateSession.Save(item, item.Id);
            }
        }
    }
}
