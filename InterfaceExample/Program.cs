using System;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfaceIntro();
            //Demo();
            IcustomerDal[] customerDals = new IcustomerDal[2]
            {
                new SqlServerCustomerDal(),
                new OracleCsutomerDal()
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();

        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCsutomerDal());
        }

        private static void InterfaceIntro()
        {
            PersonManager personManager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                Firstname = "Merve",
                LastName = "Berik",
                Address = "Ankara"
            };
            Student student = new Student
            {
                Id = 2,
                Firstname = "Ayşe"
            };
            //personManager.Add(new Customer { Id = 1, Firstname = "Merve", LastName = "Berik", Address = "Ankara" });
            personManager.Add(customer);
            personManager.Add(student);
        }
    }
    interface IPerson //soyut nesne
    {
        int Id { get; set; }
        string Firstname { get; set; }
        string LastName { get; set; }

    }
    class Customer:IPerson
    {
        public int Id { get; set; } //bunları implement edeceğiz.
        public string Firstname { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
    }
    class Student:IPerson
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.Firstname);
        }
    }
}
