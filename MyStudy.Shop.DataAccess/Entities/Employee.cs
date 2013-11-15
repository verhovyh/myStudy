using MyStudy.Shop.DataAccess.Entities.Base;

namespace MyStudy.Shop.DataAccess.Entities {
    class Employee : BaseEntity
    {
        public int Id;
        public string Name;
        public Employee Manager;
        
        public string SayHello()
        {
            return string.Format("'Hello World!', said {0}", Name);
        }


    }
}
