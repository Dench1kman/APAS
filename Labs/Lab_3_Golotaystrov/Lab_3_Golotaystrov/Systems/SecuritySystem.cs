using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Golotaystrov.Systems
{
    public class SecuritySystem
    {
        private bool isArmed;

        public void ArmSystem()
        {
            isArmed = true;
            Console.WriteLine("Система безпеки активована.");
        }

        public void DisarmSystem()
        {
            isArmed = false;
            Console.WriteLine("Система безпеки деактивована.");
        }
    }
}
