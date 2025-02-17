// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Part 6");

string name = "Tom";
string name2 = "Cherry";

string friends = $"Hello, {name} and {name2}";
Console.WriteLine(friends);

friends = friends.Replace("Tom", "Daisy");
Console.WriteLine($"friends Upper case: {friends.ToUpper()}");
Console.WriteLine($"friends string length: {friends.Length}");

Console.WriteLine($"Contains Daisy: {friends.Contains("Daisy")}");
Console.WriteLine($"Contains Jimmy: {friends.Contains("Jimmy")}");

Console.WriteLine($"Starts with Hello: {friends.StartsWith("Hello")}");
Console.WriteLine($"Ends with Cherry: {friends.EndsWith("Cherry")}");
