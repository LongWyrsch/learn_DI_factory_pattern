public class Consumer
{
    public IVehicleFactory _factory { get; set; } // factory is now a delegate
    public Consumer(IVehicleFactory factory) // dependency is now a delegate
    {
        _factory = factory;
    }

    public void PrintCurrentDateTime()
    {
        string? input = string.Empty;
        while (input != "Exit")
        {
            Console.WriteLine($"Chosen vehicle is: \"{_factory.Create("Truck")}\".");
            Console.Write("(Enter: again, Exit: termate)");

            input = Console.ReadLine();
        }
    }
}
