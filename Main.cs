/*
Module: Object Oriented Software Development 
Coursework: Coursework 1 
File: Main.cs 
Author: Oluwasanmi Longe  
Matriculation number: 40798397 
Description: Implementation and testing the BusStop class while relying on user input
 */


using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace CW1
{
    /// <summary>
    /// Main entry point, tests the BusStop class and the initially defined validation
    /// Handles and implements input validation and flow for BusStop program
    /// </summary>

    public class MainClassInput
    {
        static void Main()
        {
            BusStop stop = new(); // BusStop object
            Console.WriteLine("Welcome to the BusStop class test!\nEnter the details as shown below (enter \"quit\" in the ID field to exit this program.)");
            while (stop.Passengers < 999999) // Makes sure program terminates once number of Passengers exceeds limit
            {
                while (true)
                {
                    Console.Write("ID: ");
                    string userID = Console.ReadLine();
                    if (userID == "quit") // Exits the program when quit is entered into the ID field. This is to prevent an infinite loop
                    {
                        Console.WriteLine($"Thank you for using this program.\n{stop.Passengers} passenger(s) boarded this bus."); // Prints number of passengers
                        return; // Exits program
                    }
                    try
                    {
                        stop.ID = Convert.ToInt32(userID); // To see if an integer was entered or not
                        break;
                    } // try
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    } // catch
                } // while loop
                while (true)
                {
                    Console.Write("Name: ");
                    string userName = Console.ReadLine();
                    try
                    {
                        stop.Name = userName;
                        break;
                    } // try
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    } // catch
                } // while loop
                while (true)
                {
                    Console.Write("Latitude: ");
                    string userLat = Console.ReadLine();
                    try
                    {
                        stop.Latitude = Convert.ToDouble(userLat); // To check if user entered a double 
                        break;
                    } // try
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    } // catch
                } // while loop
                while (true)
                {
                    Console.Write("Longitude: ");
                    string userLong = Console.ReadLine();
                    try
                    {
                        stop.Longitude = Convert.ToDouble(userLong);
                        break;
                    } // try
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}"); // Presents the exception as an error msg so users know what they are doing wrong
                    } // catch
                } // while loop
                stop.Board();
                Console.WriteLine("--------------------Next--------------------");
            } // while loop
        } // Main method
    } // MainClass
} // CW1

//Welcome to the BusStop class test!
//Enter the details as shown below (enter "quit" in the ID field to exit this program.)
//ID: on
//Error: The input string 'on' was not in a correct format.
//ID: 0
//Error: Id is out of range
//ID: -23
//Error: Id is out of range
//ID: 21
//21 - Valid ID
//Name:
//Error: Name cannot be empty.
//Name: Princes Street
//Princes Street - Valid Bus stop name
//Latitude: we
//Error: The input string 'we' was not in a correct format.
//Latitude: 123
//Error: Latitude is out of range! (Must be within 55.8 and 55.9).
//Latitude: 55.87654
//55.87654 - Valid latitude
//Longitude: ten
//Error: The input string 'ten' was not in a correct format.
//Longitude: 10
//Error: Longitude is out of range! (Must be within -3.0 and -3.4).
//Longitude: -3.393458
//- 3.393458 - Valid longitude
//A passenger has boarded the bus
//--------------------Next--------------------
//ID: 219
//219 - Valid ID
//Name: XC Lothian
//XC Lothian  - Valid Bus stop name
//Latitude: 55.89
//55.89 - Valid latitude
//Longitude: -3.2958
//- 3.2958 - Valid longitude
//A passenger has boarded the bus
//--------------------Next--------------------
//ID: quit
//Thank you for using this program.
//2 passenger(s) boarded this bus.

//C:\Users\PC\Desktop\OOSDCW1\bin\Debug\net8.0\CW1.exe (process 3184) exited with code 0 (0x0).
//To automatically close the console when debugging stops, enable Tools->Options->Debugging->Automatically close the console when debugging stops.
//Press any key to close this window . . .