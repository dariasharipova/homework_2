StreamReader read_random_numbers = new StreamReader("random_numbers.txt");
var line = read_random_numbers.ReadLine();
List<string> numbers = new List<string>();
Console.WriteLine("Обрабатываю данные");
while(line != null)
{
    var splitLine = line.Split(" ");
    if(numbers.Count == 0)
    {
        numbers.Add(splitLine[0]);
        Console.Write(".");
    }
    else if(numbers.Count !=0)
    {
        for(int i =0; i< splitLine.Length; i++)
        {
            var number = splitLine[i];
            if(number != " ")
            {
                if(!numbers.Contains(number))
                {
                    numbers.Add(number);
                    Console.Write(".");
                }
            }
            
        }
    }
    line = read_random_numbers.ReadLine();
}
read_random_numbers.Close();
List<int> intNumbers = new List<int>();
for(int i =0; i< numbers.Count; i++)
{
    intNumbers.Add(int.Parse(numbers[i]));
}
intNumbers.Sort(); 
Console.WriteLine("\nОбработка данных завершена");
Console.WriteLine($"Всего вариант: {numbers.Count}");
Console.Write($"Варианты: ");
for(int i = 0; i< intNumbers.Count; i++)
{
    Console.Write(intNumbers[i] + " ");
}
Console.WriteLine();