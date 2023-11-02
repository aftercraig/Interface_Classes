using System;

public class Telephone :IComparable<Telephone> 
{
    public string brend;
    public int price;
    public int memory;
    public string color;

    public Telephone (string brend, int price, int memory, string color) 
    {
        this.brend = brend;
        this.price = price;
        this.memory = memory;
        this.color = color;
    }

    public int CompareTo(Telephone? o)
    {
       if(o is Telephone telephone)
       {
        return price.CompareTo(telephone.price);
       } else {
        throw new ArgumentException("Неправильные данные");
       }
    }
}

public class Program 
{
    public static void Main()
    {
        Telephone nothing = new Telephone("Nithing Phone 2", 60000, 16, "black");
        Telephone poco = new Telephone("Poco x3", 999999, 32, "blue");
        Telephone sony_ericsson = new Telephone("Sony Ericsson", 5000, 256, "grey");
        Telephone[] phone = {nothing, poco, sony_ericsson};
        Array.Sort(phone);
        foreach(Telephone Telephone in phone)
        {
            Console.WriteLine($"{Telephone.brend} - {Telephone.price}, {Telephone.memory}, {Telephone.color}");
        }
    }
}