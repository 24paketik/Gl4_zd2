using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contributions
{
    public class Cl_SaveConf:Cl_Contributions
    {
        public double procence;
        public byte CloseDateDay;
        public byte CloseDateMonth;
        public byte CloseDateYear;

        public void AccurePr()
        {
            balance += Math.Round(procence * balance / 1000,2);
            Console.WriteLine("Проценты начислены. Баланс: "+balance);
        }
        public void CheckDate()
        {
            if (CloseDateYear < DateOpenYear)
            {
                if (CloseDateMonth < DateOpenMonth)
                {
                    if (CloseDateDay < DateOpenDay)
                    {
                        Console.WriteLine("Истёк срок вклада");
                    }
                    else
                    {
                        Console.WriteLine("Вклад ещё активен");
                    }
                }
                else
                {
                    Console.WriteLine("Вклад ещё активен");
                }
            }
            else
            {
                Console.WriteLine("Вклад ещё активен");
            }
        }
    }
}
