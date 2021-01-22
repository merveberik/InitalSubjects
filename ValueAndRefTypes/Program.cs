using System;

namespace ValueAndRefTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;  //stack içindedir bunlar
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ?? 30 

            //pointer olayıdır
            int[] sayilar1 = new int[] { 10, 20, 30 };  //new diyince bellekte yer açtık heap içinde
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;   //ref numarası denir  //gereksiz sayıları da çöp toplayıcı(destructor) toplar.
            sayilar2[0] = 999;
            //sayilar1[0] ?? 999 olur

            //int, double, float, double, bool = değer tip
            //array, class, interface = referans tip

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Derin";

            person2 = person1;
            person1.FirstName = "Merve";
            Console.WriteLine(person2.FirstName); //classlarda da en son atanan değeri alır referans değerdir.

            Customer customer = new Customer();
            customer.FirstName = "Name";
            customer.CreditNumber = "1234567890";

            Employee employee = new Employee();
            employee.FirstName = "Ayşe";

            Person person3 = customer; //customer geçişi yapıyoruz
            Console.WriteLine(person3.FirstName);

            Console.WriteLine(((Customer)person3).CreditNumber); //customer burada int gibi bir tip görevi gördü.

            //aynı kodu farklı nesnelerle kullanabiliriz. customer ve employee nın veri tabanı nesneleri oluşturduk kendimizi tekrar etmemizi engelleyecek.
            PersonManager personManager = new PersonManager();
            personManager.Add(customer);
            personManager.Add(employee);
            personManager.Add(person1);



        }

        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
        //base class : Person
        class Customer : Person
        {
            public string CreditNumber { get; set; }
        }
        class Employee: Person
        {
            public int EmployeeNumber { get; set; }
        }

        class PersonManager
        {
            //customer ve employee nin base ini aldık(person)
            public void Add(Person person) //employee ya da customer gönderseydik sadece onlarla çalışıdık ama şimdi hepsini alabiliriz
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}
