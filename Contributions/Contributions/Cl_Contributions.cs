using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contributions
{
    public class Cl_Contributions
    {
        public double balance; // баланс
        public byte DateOpenDay; // Дата открытия
        public byte DateOpenMonth;
        public byte DateOpenYear;
        public void OpenContr()
        {
            Console.Write("Введие баланс счёта: ");
            balance = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите  дату открытия счёта:");
            Console.WriteLine("Введите день:");
            DateOpenDay = Convert.ToByte( Console.ReadLine());
            DateOpenMonth = Convert.ToByte(Console.ReadLine());
            DateOpenYear = Convert.ToByte(Console.ReadLine());
        }
        public void CloseContr()
        {
            balance = 0;
            DateOpenDay = 0;
            DateOpenMonth= 0;
            DateOpenYear = 0;
        }
        public void ShowBalance()
        {
            Console.WriteLine("Ваш баланс: "+balance);
        }
    }
}
