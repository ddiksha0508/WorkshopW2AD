List<string> fruits = new List<string> { "Apple", "Avocado", "Apricot" };

fruits.Add("Banana");
Console.WriteLine("Fruits list after adding :");
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}

fruits.Remove("Apricot");
Console.WriteLine("\n Fruits list after removing:");
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}
Console.WriteLine("\nFruits List:");
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}

Dictionary<int, string> fruitDict = new Dictionary<int, string>
{
    { 1, "Apple" },
    { 2, "Avocado" },
    { 3, "Banana" }
};
fruitDict.Add(4, "Kiwi");

Console.WriteLine("\nFruits Dictionary:");
foreach (KeyValuePair<int, string> entry in fruitDict)
{
    Console.WriteLine($"ID: {entry.Key}, Fruit: {entry.Value}");
}