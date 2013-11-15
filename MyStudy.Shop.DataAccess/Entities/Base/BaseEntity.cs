using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStudy.Shop.DataAccess.Entities.Base {
    public class BaseEntity : IEntity {
        public long Id { get; set; }
        public bool IsNew
        {
            get { return Id == 0; }
            set { }
        }
    }
}
