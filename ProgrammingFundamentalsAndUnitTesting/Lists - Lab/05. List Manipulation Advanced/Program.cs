﻿var numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

while (true)
{
    string command = Console.ReadLine();

    if (command == "end")
    {
        break;
    }

    var tokens = command.Split();

    switch (tokens[0])
    {
        case "Contains":
            var number = int.Parse(tokens[1]);
            Console.WriteLine(numbers.Contains(number) ? "Yes" : "No such number");
            break;

        case "PrintEven":
            Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 == 0)));
            break;

        case "PrintOdd":
            Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 != 0)));
            break;

        case "GetSum":
            Console.WriteLine(numbers.Sum());
            break;

        case "Filter":
            var condition = tokens[1];
            number = int.Parse(tokens[2]);

            switch (condition)
            {
                case "<":
                    Console.WriteLine(string.Join(" ", numbers.Where(n => n < number)));
                    break;

                case ">":
                    Console.WriteLine(string.Join(" ", numbers.Where(n => n > number)));
                    break;

                case "<=":
                    Console.WriteLine(string.Join(" ", numbers.Where(n => n <= number)));
                    break;

                case ">=":
                    Console.WriteLine(string.Join(" ", numbers.Where(n => n >= number)));
                    break;
            }
            break;
    }
}