// Продемонстрировать применение условного оператора if

using System;

class IfDemo {
    static void Main() {
        int a, b, c;

        a = 2;
        b = 3;
        if(a == b) Console.WriteLine("этого никто не увидит");

        Console.WriteLine();

        c = a - b; // c содержит -1

        Console.WriteLine("c содержит -1");
        if(c >= 0) Console.WriteLine("значение c неотрицательно");
        if(c < 0) Console.WriteLine("значение c отрицательно");

        Console.WriteLine();

        c = b - a; // теперь c содержит 1
        Console.WriteLine("c содержит 1");
        if(c >= 0) Console.WriteLine("значение c неотрицательно");
        if(c < 0) Console.WriteLine("значение c отрицательно");
    }
}