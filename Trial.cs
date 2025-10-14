/*
Module: Object Oriented Software Development 
Coursework: Coursework 1 
File: Trial.cs
Author: Oluwasanmi Longe  
Matriculation number: 40798397
Description: Implementation and testing the BusStop class
 */


///<summary>
///Initial implementation of BusStop class including validation and user input
/// </summary>

//namespace CW1
//{
//  public class MainClass
//        private readonly string[] _propertyTypes = { "ID", "Name", "Longitude", "Latitude" };
//        public bool InputValidator(BusStop stop, object property, string propertyType)
//        {
//            bool correctType = false;
//            foreach (string propType in _propertyTypes) // Checks if the specified property type is valid to avoid errors
//            {
//                if (propType == propertyType)
//                {
//                    correctType = true;
//                    break;
//                } // if statement 
//            } // foreach statement 
//            if (correctType)
//            {
//                try 
//                {
//                    switch (propertyType)
//                   {
//                        case "ID":
//                            stop.ID = Convert.ToInt32(property);
//                            break;
//                        case "Name":
//                            stop.Name = (string)property;
//                            break;
//                        case "Longitude":
//                            stop.Longitude = Convert.ToDouble(property);
//                            break;
//                        case "Latitude":
//                            stop.Latitude = Convert.ToDouble(property);
//                            break;
//                    } // switch 
//                    return true;
//                } // try    
//                catch (Exception ex)
//                {
//                    Console.WriteLine($"Error: {ex.Message}"); // Returns the error message when an exception is thrown
//                    return false;
//                } // catch 
//            }
//            else
//            {
//                Console.WriteLine("Invalid property type");
//                return false;
//            }
//        } // InputValidator method 
//        public void InputLoop(BusStop stop, string propertyType)
//        {
//            while (true)
//            {
//                Console.Write($"{propertyType}: "); 
//                string UserInput = Console.ReadLine();
//                if (InputValidator(stop, UserInput, propertyType))
//                {
//                    break;
//                } // if statement 
//            } // while loop 
//        } // InputLoop method
//        static void Main()
//        {
//            BusStop myStop = new(); // BusStop object
//            MainClass myClass = new(); // MainClass object, since Main is static
//            Console.WriteLine("Welcome to the BusStop class test!\nEnter your bus stop details as shown below (enter \"quit\" in the Name field to exit this program.)");
//            while (myStop.Passengers <= 999999) // To make sure number of passengers is kept within the limit
//            {
//                myClass.InputLoop(myStop, "ID");
//                Console.WriteLine("Valid ID."); // Validation message
//                myClass.InputLoop(myStop, "Name");
//                if (myStop.Name == "quit") // Break out point/stops the loop
//                {
//                    break;
//                }
//                Console.WriteLine("Valid Name.");
//                myClass.InputLoop(myStop, "Longitude");
//                Console.WriteLine("Valid Longitude.");
//                myClass.InputLoop(myStop, "Latitude");
//                Console.WriteLine("Valid Latitude.");
//                myStop.Board();
//                Console.WriteLine("--------------------------------Next--------------------------------");
//            }
//            Console.WriteLine("Thank you for using this program!");
//            Console.WriteLine($"There is/are {myStop.Passengers} passenger(s) on the bus."); // Number of passengers is printed out after the loop has ended
//        }
//    } // MainClass class 
//} // CourseWork namespace 