using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        public void MakeApplication(ICrediManager crediManager, List<ILOggerService> loggerServices) //which one credit depend on for selecting
        {
            //avaluating application informations  like this things is realised
            crediManager.Calculate(); //credit independent. you can sent each credit type

            //MortgageCreditManager mortgageCreditManager = new MortgageCreditManager(); //bütün başvruları buna bağımlı hale getirir.
            //mortgageCreditManager.Calculate();

            //loggerService.Log();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }
        public void CreditFirstInforming(List<ICrediManager> credits) //more than one credits, type is IcreditManager
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }

    }
}
