using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== ЕТАП 1: Створення списку ===");
        MyList<string> heroes = new MyList<string>();
        PrintStatus(heroes, "Створили порожній список");
        // Очікуємо: Count = 0, Capacity = 4

        Console.WriteLine("\n=== ЕТАП 2: Заповнюємо базову місткість (4 елементи) ===");
        heroes.Add("Batman");
        heroes.Add("Superman");
        heroes.Add("Flash");
        heroes.Add("Aquaman");
        PrintStatus(heroes, "Додали 4 героїв");
        heroes.ShowAll();
        // Очікуємо: Count = 4, Capacity = 4

        Console.WriteLine("\n=== ЕТАП 3: RESIZE (Додаємо 5-й елемент) ===");
        heroes.Add("Wonder Woman"); // Коробка переповнена! Має спрацювати Resize()
        PrintStatus(heroes, "Додали Wonder Woman");
        heroes.ShowAll();
        // Очікуємо: Count = 5, Capacity = 8 (Місткість подвоїлась!)

        Console.WriteLine("\n=== ЕТАП 4: Видалення за значенням (Remove) ===");
        bool isRemoved = heroes.Remove("Flash");
        Console.WriteLine($"Чи вдалося видалити Flash? {isRemoved}");
        PrintStatus(heroes, "Після видалення Flash");
        heroes.ShowAll();
        // Очікуємо: Count = 4, Capacity = 8 (Пам'ять не зменшується автоматично, це нормально!)

        Console.WriteLine("\n=== ЕТАП 5: Видалення за індексом (RemoveAtIndex) ===");
        heroes.RemoveAtIndex(0); // Видаляємо першого (Batman)
        PrintStatus(heroes, "Після видалення елемента з індексом 0");
        heroes.ShowAll();
        // Очікуємо: Count = 3, Capacity = 8
    }

    // Допоміжний метод, щоб красиво виводити стан списку
    static void PrintStatus(MyList<string> list, string action)
    {
        Console.WriteLine($"[{action}] -> Count: {list.Count} | Capacity: {list.Capacity}");
    }
}