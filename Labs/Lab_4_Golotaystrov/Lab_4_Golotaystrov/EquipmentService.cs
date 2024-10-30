using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Golotaystrov
{
    public static class EquipmentService
    {
        // 1. Вибрати всі обладнання зі статусом "Архівний"
        public static void DisplayArchivedEquipments(List<Equipment> equipments)
        {
            var archivedEquipments = equipments.Where(e => e.Status == "Архівний").ToList();
            Console.WriteLine("1.Archived Equipment:");
            foreach (var equipment in archivedEquipments)
                Console.WriteLine($"Id: {equipment.Id}, Name: {equipment.Name}, Price: {equipment.Price}");
        }

        // 2. Знайти обладнання з найбільшою ціною
        public static void DisplayMostExpensiveEquipment(List<Equipment> equipments)
        {
            var mostExpensiveEquipment = equipments.OrderByDescending(e => e.Price).FirstOrDefault();
            Console.WriteLine("\n2.Most Expensive Equipment:");
            if (mostExpensiveEquipment != null)
                Console.WriteLine($"Id: {mostExpensiveEquipment.Id}, Name: {mostExpensiveEquipment.Name}, Price: {mostExpensiveEquipment.Price}");
        }

        // 3. Підрахувати загальну кількість обладнання в системі
        public static void DisplayTotalEquipmentCount(List<Equipment> equipments)
        {
            var totalEquipmentCount = equipments.Count;
            Console.WriteLine($"\n3.Total Equipment Count: {totalEquipmentCount}");
        }

        // 4. Відсортувати обладнання за ціною у порядку спадання
        public static void DisplaySortedByPriceDescending(List<Equipment> equipments)
        {
            var sortedByPriceDescending = equipments.OrderByDescending(e => e.Price).ToList();
            Console.WriteLine("\n4.Equipment Sorted by Price (Descending):");
            foreach (var equipment in sortedByPriceDescending)
                Console.WriteLine($"Id: {equipment.Id}, Name: {equipment.Name}, Price: {equipment.Price}");
        }

        // 5. Вибрати унікальні статуси обладнання
        public static void DisplayUniqueStatuses(List<Equipment> equipments)
        {
            var uniqueStatuses = equipments.Select(e => e.Status).Distinct().ToList();
            Console.WriteLine("\n5.Unique Statuses:");
            foreach (var status in uniqueStatuses)
                Console.WriteLine(status);
        }

        // 6. Порахувати кількість обладнання для кожного статусу (Активний, Архівний)
        public static void DisplayEquipmentCountByStatus(List<Equipment> equipments)
        {
            var equipmentCountByStatus = equipments.GroupBy(e => e.Status)
                                                   .Select(g => new { Status = g.Key, Count = g.Count() })
                                                   .ToList();
            Console.WriteLine("\n6.Equipment Count by Status:");
            foreach (var statusGroup in equipmentCountByStatus)
                Console.WriteLine($"Status: {statusGroup.Status}, Count: {statusGroup.Count}");
        }

        // 7. Вибрати всі обладнання, назви яких починаються на букву "Т"
        public static void DisplayEquipmentStartingWithT(List<Equipment> equipments)
        {
            var equipmentStartingWithT = equipments.Where(e => e.Name.StartsWith("Т")).ToList();
            Console.WriteLine("\n7.Equipment Starting with 'Т':");
            foreach (var equipment in equipmentStartingWithT)
                Console.WriteLine($"Id: {equipment.Id}, Name: {equipment.Name}, Price: {equipment.Price}");
        }

        // 8. Знайти середню ціну всіх обладнання
        public static void DisplayAveragePrice(List<Equipment> equipments)
        {
            var averagePrice = equipments.Average(e => e.Price);
            Console.WriteLine($"\n8.Average Price: {averagePrice}");
        }

        // 9. Вибрати всі обладнання, ціна яких нижча за 100
        public static void DisplayEquipmentPriceBelow100(List<Equipment> equipments)
        {
            var equipmentPriceBelow100 = equipments.Where(e => e.Price < 100).ToList();
            Console.WriteLine("\n9.Equipment with Price Below 100:");
            foreach (var equipment in equipmentPriceBelow100)
                Console.WriteLine($"Id: {equipment.Id}, Name: {equipment.Name}, Price: {equipment.Price}");
        }

        // 10. Порахувати кількість обладнання, ціна яких перевищує 500
        public static void DisplayEquipmentCountAbove500(List<Equipment> equipments)
        {
            var equipmentCountAbove500 = equipments.Count(e => e.Price > 500);
            Console.WriteLine($"\n10.Count of Equipment with Price Above 500: {equipmentCountAbove500}");
        }
    }
}
