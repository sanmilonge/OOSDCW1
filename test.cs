namespace CW1
{
    public class MainClass
    {
        static void Main()
        {
            BusStop stop = new()
            {
                ID = 12,
                Name = "Princes Street",
                Longitude = -3.23,
                Latitude = 55.8345
            };
            stop.Board();

            try
            {
                stop.ID = 0;
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            try
            {
                stop.Name = "";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            try
            {
                stop.Latitude = 1234;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            try
            {
                stop.Longitude = 92438;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            stop.ID = 234;
            stop.Name = "XC Lothian";
            stop.Latitude = 55.9;
            stop.Longitude = -3.4;
            stop.Board();

            Console.WriteLine($"{stop.Passengers} have boarded the bus successfully");

        } // MainClass
    }
}
