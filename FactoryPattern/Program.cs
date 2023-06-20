namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            int wheelNum;
            bool input = false;

            do
            {
                Console.WriteLine("Enter the amout of tires: ");

                input = int.TryParse(Console.ReadLine(), out wheelNum);

            } while (!input);

            var vehicle = VehicleFactory.GetVehicle(wheelNum);
            vehicle.Drive();
        }
    }
}
