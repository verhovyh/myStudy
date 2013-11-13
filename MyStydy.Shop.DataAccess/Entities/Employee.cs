namespace MyStudy.Shop.DataAccess.Entities {
    class Employee
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
