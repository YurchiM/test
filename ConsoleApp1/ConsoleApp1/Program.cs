public interface IDiscount
{
    double GetDiscount();
}

public class RegularCustomerDiscount : IDiscount
{
    public double GetDiscount() => 0.1;
}

public class PremiumCustomerDiscount : IDiscount
{
    public double GetDiscount() => 0.2;
}

public class DiscountCalculator
{
    public double CalculateDiscount(IDiscount discount)
    {
        return discount.GetDiscount();
    }
}

class Program
{
    static void Main(string[] args)
    {
        DiscountCalculator calculator = new DiscountCalculator();

// Для обычного клиента
        IDiscount regularDiscount = new RegularCustomerDiscount();
        double regularCustomerDiscount = calculator.CalculateDiscount(regularDiscount); // Вернет 0.1
        Console.WriteLine(regularCustomerDiscount);
        Console.WriteLine("Для обычного клиента");

// Для премиум клиента
        IDiscount premiumDiscount = new PremiumCustomerDiscount();
        double premiumCustomerDiscount = calculator.CalculateDiscount(premiumDiscount); // Вернет 0.2
        Console.WriteLine("Для премиум клиента");

    } 
}
