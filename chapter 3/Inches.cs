// Вычислить расстояние от Земли до Солнца в дюймах

using System;

class Inches {
    static void Main() {
        long inches;
        long miles;

        miles = 93000000; // 93 000 000 миль до Солнца

        // 5 280 футов в миле, 12 дюймов в футе
        inches = miles * 5280 * 12;

        Console.WriteLine("Расстояние до Солнца: " + inches + " дюймов.");
    }
}