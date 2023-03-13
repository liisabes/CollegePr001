public class Adress
{
    public string Town { get; set; }
    public string Street { get; set; }
    public int NumberOfHouse { get; set; }
    public Adress() {}
    public Adress (string town, string street, int numberOfHouse)
    {
        Town = town;
        Street = street;
        NumberOfHouse = numberOfHouse;
    }
    public void Input()
    {
        Console.WriteLine("--------------------");
        Console.WriteLine("Input: ");

        Console.Write("Town: ");
        Town = Console.ReadLine();

        Console.WriteLine("Street: ");
        Street = Console.ReadLine();

        Console.WriteLine("Number Of House: ");
        NumberOfHouse = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("--------------------");
    }
    public void Output()
    {
        Console.WriteLine("==============================");
        Console.WriteLine("Output: ");
        Console.WriteLine($"Town: {Town}\nAnimal Street: {Street}\nNumber Of House: {NumberOfHouse}");
        Console.WriteLine("==============================");
    }
}