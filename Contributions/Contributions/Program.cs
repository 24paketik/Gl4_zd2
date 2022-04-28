using System;

namespace Contributions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Проверка универсального вклада
            Console.WriteLine("универсальный вклад");
            Cl_Multi multi = new Cl_Multi();
            multi.OpenContr();
            multi.takeContr();
            multi.putContr();
            multi.CloseContr();

            // Проверка депозита сохраняй
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("дерозит сохраняй");
            Cl_SaveContr save = new Cl_SaveContr();
            save.OpenContr();
            save.procence = 30;
            save.DateOpenYear = 2022;
            save.CloseDateMonth = 5;
            save.CloseDateDay = 1;
            save.AccurePr();
            save.CheckDate();

            // Проверка   сохраняй и пополняй
            Cl_SaveAndRep saveAndRep = new Cl_SaveAndRep();
            saveAndRep.OpenContr();
            saveAndRep.PutContr();
        }
    }
}
