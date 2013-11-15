using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStudy.Shop.DataAccess.DAO.Base;
using MyStudy.Shop.DataAccess.Entities.Base;
using NHibernate;

namespace MyStudy.Shop.DataAccess.Services.Base {
    public class BaseService<TModel> : BaseService, IBaseService<TModel>
        where TModel : IEntity {
        public BaseService(ISession nhSession, IBaseDao<TModel> dao)
            : base(nhSession) {
            this.Dao = dao;
        }

        protected IBaseDao<TModel> Dao { get; set; }
        public bool Delete(TModel item) {
            this.Dao.Delete(item);
            return true;
        }

        public bool DeleteList(List<TModel> items) {
            this.Dao.DeleteList(items);
            return true;
        }

        public bool Write(TModel item) {
            this.Dao.Write(item);
            return true;
        }

        public bool WriteList(List<TModel> items) {
            this.Dao.WriteList(items);
            return true;
        }
    }
}
