using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Golotaystrov.Systems
{
    public class LightingSystem
    {
        private int brightnessLevel;
        private bool isAutomatic;

        public void AdjustLighting(int desiredBrightness)
        {
            brightnessLevel = desiredBrightness;
            Console.WriteLine("Рівень освітлення встановлено на: " + brightnessLevel + "%");
        }

        public void ToggleAutomaticMode(bool enable)
        {
            isAutomatic = enable;
            if (isAutomatic)
            {
                Console.WriteLine("Автоматичний режим освітлення увімкнено.");
            }
            else
            {
                Console.WriteLine("Автоматичний режим освітлення вимкнено.");
            }
        }
    }
}
