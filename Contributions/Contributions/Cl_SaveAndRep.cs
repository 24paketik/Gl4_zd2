using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contributions
{
    public class Cl_SaveAndRep: Cl_SaveContr
    {
        public int minput=3000;

        public void PutContr()
        {
            double put = Convert.ToDouble(Console.ReadLine());
            if (minput < put)
            {
                balance += put;
                Console.WriteLine("Вы пополнили баланс.");
            }
            else
            {
                Console.WriteLine("Вы ввели слишном маленькое число");
            }
        }
    }
}
