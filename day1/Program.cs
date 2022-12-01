// See https://aka.ms/new-console-template for more information
string[] lines = System.IO.File.ReadAllLines(@"C:\Programmering\Projekt\AOC\day1pt1\input.txt");
int highestValue = 0;
List<int> elfInventory = new List<int>();

List<ElfInventory> Inventory = new List<ElfInventory>();
List<int> SortedInventorySum = new List<int>();
List<int> InventorySum = new List<int>();





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


foreach (var item in Inventory)
{
    InventorySum.Add(item.Inventory.Sum());
}

InventorySum.Sort();
int count = InventorySum.Count() -1;
int sum = 0;
System.Console.WriteLine(count);
for (int i = count ; i > count -3 ; i--)
{
    sum += InventorySum[i];
}
System.Console.WriteLine($"sum{sum}");

public class ElfInventory
{
    public List<int> Inventory { get; set; }
}