using System.Collections.Generic;
using System.Reflection;

namespace MyStudy.Shop.Console {
    class Program {
        static void Main(string[] args) {
            log4net.Config.XmlConfigurator.Configure();
            CreateEmployeeAndSaveToDb();
            UpdateTobin();
            LoadEmployeesFromDatabase();
            System.Console.ReadLine();
        }
        static void CreateEmployeeAndSaveToDb() {
            Employee tobin = new Employee { Name = "Tobin Harris" };
            using (ISession session = MySessionFactory.OpenSession()) {
                using (ITransaction trans = session.BeginTransaction()) {
                    session.Save(tobin);
                    trans.Commit();
                }
                System.Console.WriteLine("Tobin is saved to DB");

            }
        }
        static void LoadEmployeesFromDatabase() {
            using (ISession session = MySessionFactory.OpenSession()) {
                IQuery query = session.CreateQuery("from Employee as emp order by emp.Name asc");
                IList<Employee> foundEmployees = query.List<Employee>();
                System.Console.WriteLine("\n{0} employees found:", foundEmployees.Count);
                foreach (var foundEmployee in foundEmployees) {
                    System.Console.WriteLine(foundEmployee.SayHello());
                }
            }

        }
        static void UpdateTobin() {
            using (ISession session = MySessionFactory.OpenSession()) {
                using (ITransaction trans = session.BeginTransaction()) {
                    var piere = new Employee { Name = "Piere" };
                    IQuery query = session.CreateQuery("from Employee where name = 'Tobin Harris'");
                    var tobin = query.List<Employee>()[0];
                    tobin.Name = "Tobin David Harris";
                    tobin.Manager = piere;
                    session.Save(tobin);
                    trans.Commit();
                }
            }
        }

        private static ISessionFactory sessionFactory = null;
        public static ISessionFactory MySessionFactory {
            get {
                if (sessionFactory == null) {
                    var c = new Configuration().Configure("hibernate.cfg.xml").AddAssembly(Assembly.GetCallingAssembly());
                    sessionFactory = c.BuildSessionFactory();
                }
                return sessionFactory;
            }
        }
    }
}
