namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tires on the vehicle: ");
            if (int.TryParse(Console.ReadLine(), out int tireCount))
            {
                try
                {
                    IVehicle vehicle = VehicleFactory.GetVehicle(tireCount);
                    vehicle.Drive();
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number of tires.");
            }
        }
    }
}
