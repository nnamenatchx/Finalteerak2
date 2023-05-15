class Program
{
    static void Main()
    {
        Console.WriteLine("waterWelfare");
        Console.Write("10: ");
        double tankCapacity = Convert.ToDouble(Console.ReadLine());

        Console.Write("4: ");
        double averageWaterConsumption = Convert.ToDouble(Console.ReadLine());

        Console.Write("8: ");
        double refillAmount = Convert.ToDouble(Console.ReadLine());

        Console.Write("3: ");
        double breakInterval = Convert.ToDouble(Console.ReadLine());

        Console.Write("1.5: ");
        double refillInterval = Convert.ToDouble(Console.ReadLine());

        Console.Write("10: ");
        double totalActivityTime = Convert.ToDouble(Console.ReadLine());

        double totalBreakTime = totalActivityTime / breakInterval;
        double totalRefillTime = totalActivityTime / refillInterval;
        double totalWaterConsumption = totalBreakTime * averageWaterConsumption;
        double totalRefillAmount = totalRefillTime * refillAmount;
        double remainingWater = tankCapacity - totalWaterConsumption + totalRefillAmount;

        if (remainingWater >= 0)
        {
            Console.WriteLine("Enough Water, {0} left", remainingWater);
        }
        else if (remainingWater < 0 && totalRefillAmount <= tankCapacity)
        {
            Console.WriteLine("Overflow Water");
        }
        else
        {
            Console.WriteLine("Not Enough Water");
        }

        Console.WriteLine("treasurer");
        Console.Write("Balance 1 : 150.0, Balance 2 : 200.0, Balance 3 : 500.0: ");
        double b1 = Convert.ToDouble(Console.ReadLine());
        double b2 = Convert.ToDouble(Console.ReadLine());
        double b3 = Convert.ToDouble(Console.ReadLine());

        double balance1 = b1;
        double balance2 = b2;
        double balance3 = b3;
        double leftover = 0;

        while (true)
        {
            Console.Write("payment: ");
            double payment = double.Parse(Console.ReadLine());

            if (payment == 0)
                break;

            if (b1 >= payment)
            {
                b1 -= payment;
            }
            else if (b2 >= payment)
            {
                b2 -= payment;
            }
            else if (b3 >= payment)
            {
                b3 -= payment;
        }
    }
    Console.WriteLine($"Balance 1: {B1}, Balance 2: {B2}, Balance 3: {B3}");

}
}