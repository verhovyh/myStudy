using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStudy.Shop.DataAccess.Entities.Base {
    public interface IEntity {
        long Id { get; set; }
        bool IsNew { get; set; }
    }
}
