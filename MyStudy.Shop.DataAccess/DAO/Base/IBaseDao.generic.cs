using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStudy.Shop.DataAccess.Entities.Base;

namespace MyStudy.Shop.DataAccess.DAO.Base {
    public interface IBaseDao<TModel> : IBaseDao
        where TModel : IEntity

    {
        TModel GetById(long id);
        void Delete(TModel item);
        void DeleteList(IList<TModel> items);

        void Write(TModel item);
        void WriteList(IList<TModel> items);
        
    }
}
