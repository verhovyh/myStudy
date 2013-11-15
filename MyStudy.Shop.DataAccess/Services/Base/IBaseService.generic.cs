using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStudy.Shop.DataAccess.Services.Base {
    interface IBaseService<TModel>
    {
        bool Delete(TModel item);
        bool DeleteList(List<TModel> items);

        bool Write(TModel item);
        bool WriteList(List<TModel> items);
    }
}
