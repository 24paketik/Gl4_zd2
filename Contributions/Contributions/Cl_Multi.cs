using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contributions
{
    internal class Cl_Multi:Cl_Contributionscs
    {
        public void takeContr()
        {
            Console.Write("ВВедите сумму для снятия со счёта:");
            balance -= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Деньги успешно сняты");
        }
        public void putContr()
        {
            Console.Write("ВВедите сумму для внесение на счёт:");
            balance += Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Деньги успешно внесены");
        }
    }
}
