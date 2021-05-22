using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager tasitKredisiManager = new TasitKredisiManager();
            IKrediManager ihtiyacKredisiManager = new IhtiyacKredisiManager();
            IKrediManager konutKredisiManager = new KonutKredisiManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();

            basvuruManager.BasvuruYap(new EsnafKredisiManager(),new SmsLoggerService());

            List<IKrediManager> krediler = new List<IKrediManager>() { tasitKredisiManager, ihtiyacKredisiManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
