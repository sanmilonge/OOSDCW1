/*
Module: Object Oriented Software Development 
Coursework: Coursework 1 
File: test.cs 
Author: Oluwasanmi Longe  
Matriculation number: 40798397 
Description: Implementation and testing the BusStop class without relying on user input
 */


namespace CW1
{
    /// <summary>
    /// This class tests the BusStop class and catches errors it throws without using user input
    /// </summary>
    public class MainClass
    {
        static void Main()
        {
            BusStop stop = new() //Instance of the BusStop class
            {
                ID = 12,
                Name = "Princes Street",
                Longitude = -3.23,
                Latitude = 55.8345
            }; // Initializer
            stop.Board();

            try // Different try/catch for each vlue so the program keeps running after an error
            {
                stop.ID = 0;
            } // try
            catch(Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            } // catch
            try
            {
                stop.Name = "";
            } // try
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            } // catch
            try
            {
                stop.Latitude = 1234;
            } // try
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            } // catch
            try
            {
                stop.Longitude = 92438;
            } // try
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            } // catch

            stop.ID = 234;
            stop.Name = "XC Lothian";
            stop.Latitude = 55.9;
            stop.Longitude = -3.4;
            stop.Board();

            Console.WriteLine($"{stop.Passengers} have boarded the bus successfully"); // Displays number of passengers

        } // MainClass
    }
}
