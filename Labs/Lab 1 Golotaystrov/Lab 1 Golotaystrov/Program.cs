namespace Lab_1_Golotaystrov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intVariable;
            float floatVariable = 5.75f;

            // Явне приведення типу float до int 
            intVariable = (int)floatVariable;

            Console.WriteLine($"Значення float: {floatVariable}");
            Console.WriteLine($"Значення int пiсля приведення: {intVariable}\n");

            int anotherIntVariable = 10;
            float anotherFloatVariable;

            // Неявне приведення типу int до float
            anotherFloatVariable = anotherIntVariable;

            Console.WriteLine($"Значення int: {anotherIntVariable}");
            Console.WriteLine($"Значення float пiсля приведення: {anotherFloatVariable}");
        }
    }
}
