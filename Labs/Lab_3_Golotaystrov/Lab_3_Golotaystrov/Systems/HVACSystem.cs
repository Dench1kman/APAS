using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Golotaystrov.Systems
{
    public class HVACSystem
    {
        private double temperature;
        private double humidity;

        public void ControlTemperature(double desiredTemperature)
        {
            temperature = desiredTemperature;
            Console.WriteLine("Температура встановлена на: " + temperature + " °C");
        }

        public void ControlHumidity(double desiredHumidity)
        {
            humidity = desiredHumidity;
            Console.WriteLine("Вологість встановлена на: " + humidity + "%");
        }
    }

}
