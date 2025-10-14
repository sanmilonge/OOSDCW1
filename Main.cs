///*
//Module: Object Oriented Software Development 
//Coursework: Coursework 1 
//File: Main.cs 
//Author: Oluwasanmi Longe  
//Matriculation number: 40798397 
//Description: Implementation and testing the BusStop class
// */


//namespace CW1
//{
//    /// <summary>
//    /// Main entry point, tests the BusStop class and the initially defined validation
//    /// Handles and implements input validation and flow for BusStop program
//    /// </summary>
 
//    public class MainClassInput
//    {
//        static void Main()
//        {
//            BusStop stop = new(); // BusStop object
//            Console.WriteLine("Welcome to the BusStop class test!\nEnter the details as shown below (enter \"quit\" in the ID field to exit this program.)"); 
//            while (stop.Passengers < 999999) // Makes sure program terminates once number of Passengers exceeds limit
//            {
//                while (true)
//                {
//                    Console.Write("ID: ");
//                    string userID = Console.ReadLine();
//                    if (userID == "quit") // Exits the program when quit is entered into the ID field. This is to prevent an infinite loop
//                    {
//                        Console.WriteLine($"Thank you for using this program.\n{stop.Passengers} passenger(s) boarded this bus."); // Prints number of passengers
//                        return; // Exits program
//                    }
//                    try
//                    {
//                        stop.ID = Convert.ToInt32(userID); // To see if an integer was entered or not
//                        break;
//                    } // try
//                    catch (Exception ex)
//                    {
//                        Console.WriteLine($"Error: {ex.Message}");
//                    } // catch
//                } // while loop
//                while (true)
//                {
//                    Console.Write("Name: ");
//                    string userName = Console.ReadLine();
//                    try
//                    {
//                        stop.Name = userName;
//                        break;
//                    } // try
//                    catch (Exception ex)
//                    {
//                        Console.WriteLine($"Error: {ex.Message}");
//                    } // catch
//                } // while loop
//                while (true)
//                {
//                    Console.Write("Latitude: ");
//                    string userLat = Console.ReadLine();
//                    try
//                    {
//                        stop.Latitude = Convert.ToDouble(userLat); // To check if user entered a double 
//                        break;
//                    } // try
//                    catch (Exception ex)
//                    {
//                        Console.WriteLine($"Error: {ex.Message}");
//                    } // catch
//                } // while loop
//                while (true)
//                {
//                    Console.Write("Longitude: ");
//                    string userLong = Console.ReadLine();
//                    try
//                    {
//                        stop.Longitude = Convert.ToDouble(userLong);
//                        break;
//                    } // try
//                    catch (Exception ex)
//                    {
//                        Console.WriteLine($"Error: {ex.Message}"); // Presents the exception as an error msg so users know what they are doing wrong
//                    } // catch
//                } // while loop
//                stop.Board();
//                Console.WriteLine("--------------------Next--------------------");
//            } // while loop
//        } // Main method
//    } // MainClass
//} // CW1