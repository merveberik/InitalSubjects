using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICrediManager consumerCreditManager = new ConsumerCreditManager();
            ICrediManager vehicleCreditManager = new VehicleCreditManager();
            ICrediManager mortgageCreditManager = new MortgageCreditManager();

            ILOggerService databaseLoggerService = new DataBaseLoggerService();
            ILOggerService fileLoggerService = new FileLoggerService(); 

            ApplicationManager applicationManager = new ApplicationManager();
            //applicationManager.MakeApplication(consumerCreditManager, databaseLoggerService);

            applicationManager.MakeApplication(new CraftCreditManager(), 
                new List<ILOggerService> {new DataBaseLoggerService(), new SmsLoggerService() }); //we can do a list like down

            List<ICrediManager> credits = new List<ICrediManager>() {consumerCreditManager, vehicleCreditManager};

            //applicationManager.CreditFirstInforming(credits);
        }
    }
}
