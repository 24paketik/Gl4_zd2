using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contributions
{
    public class Cl_Contributionscs
    {
        public int balance; // баланс
        public string DateOpen; // Дата открытия

        public void OpenContr()
        {
            Console.Write("Введие баланс счёта: ");
            balance = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите  дату открытия счёта:");
            DateOpen = Console.ReadLine();
        }
        public void CloseContr()
        {
            balance = 0;
            DateOpen = "";
        }
        public void ShowBalance()
        {
            Console.WriteLine("Ваш баланс: "+balance);
        }
    }
}
