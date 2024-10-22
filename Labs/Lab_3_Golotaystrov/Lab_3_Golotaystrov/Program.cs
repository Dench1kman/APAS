using Lab_3_Golotaystrov.Systems;

namespace Lab_3_Golotaystrov
{
    internal class Program
    {
        public class Building
        {
            private HVACSystem hvacSystem;
            private LightingSystem lightingSystem;
            private SecuritySystem securitySystem;
            private AirQualitySystem airQualitySystem;

            public Building()
            {
                hvacSystem = new HVACSystem();
                lightingSystem = new LightingSystem();
                securitySystem = new SecuritySystem();
                airQualitySystem = new AirQualitySystem();
            }

            public void ControlBuilding()
            {
                hvacSystem.ControlTemperature(22.0);
                hvacSystem.ControlHumidity(50.0);

                lightingSystem.AdjustLighting(80);
                lightingSystem.ToggleAutomaticMode(true);

                securitySystem.ArmSystem();

                airQualitySystem.ControlAirQuality(0.04);
                airQualitySystem.AdjustAirFlow(0.5);
            }

            public static void Main(string[] args)
            {
                Building building = new Building();
                building.ControlBuilding();
            }
        }

    }
}
