using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Golotaystrov.Systems
{
    public class AirQualitySystem
    {
        private double co2Level;
        private double airFlow;

        public void ControlAirQuality(double desiredCO2Level)
        {
            co2Level = desiredCO2Level;
            Console.WriteLine("Рівень CO2 встановлений на: " + co2Level + "%");
        }

        public void AdjustAirFlow(double desiredAirFlow)
        {
            airFlow = desiredAirFlow;
            Console.WriteLine("Потік повітря встановлено на: " + airFlow + " м³/с");
        }
    }
}
