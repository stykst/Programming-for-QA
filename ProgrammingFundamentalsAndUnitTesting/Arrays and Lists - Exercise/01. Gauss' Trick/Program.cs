var numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

var n = numbers.Count;
var first = 0;
var last = n - 1;
var newNumbers = new List<int>();

for (int i = 0; i < n / 2; i++)
{
    int sum = numbers[first] + numbers[last];
    newNumbers.Add(sum);

    first++;
    last--;

    if (first == last) newNumbers.Add(numbers[first]);
}

Console.WriteLine(string.Join(" ", newNumbers));