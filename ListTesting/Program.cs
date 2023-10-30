List<int> numbers = new List<int>();

numbers.Add(3);
numbers.Add(4);
numbers.Add(5);
numbers.Add(6);
numbers.Add(7);
numbers.Add(8);    
numbers.Add(9);
numbers.Add(10);

Console.WriteLine(numbers.Count);

numbers.RemoveAll(number => number < 0);