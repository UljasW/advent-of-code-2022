// See https://aka.ms/new-console-template for more information
string[] lines = System.IO.File.ReadAllLines(@"C:\Programmering\Projekt\AOC\day1pt1\input.txt");
List<ElfInventory> Inventory = new List<ElfInventory>();
int highestValue = 0;
List<int> elfInventory = new List<int>();

foreach (var item in lines)
{
    if (item == "")
    {
        Inventory.Add(new ElfInventory
        {
            Inventory = elfInventory
        });
        elfInventory = new List<int>();
    }
    else
    {
        elfInventory.Add(int.Parse(item));
    }
}

foreach (var item in Inventory)
{
    var temp = item.Inventory.Sum();
    if(temp > highestValue)
    {
        highestValue = temp;
    }
}

System.Console.WriteLine($"highestValue: {highestValue}");


public class ElfInventory
{
    public List<int> Inventory { get; set; }
}