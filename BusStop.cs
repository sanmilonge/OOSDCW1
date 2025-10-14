/* 
Module: Object Oriented Software Development 
Coursework: Coursework 1 
File: BusStop.cs 
Author: Oluwasanmi Longe  
Matriculation number: 40798397 
Properties: 
-id (get, set) 
-name (get, set) 
-latitude (get, set) 
-longitude (get, set) 
-passengers (get) 
Methods: 
-Board() 
Description: Design of BusStop class 
Assumptions: 
-ID must be an integer (whole number) 
*/

namespace CW1
{
    /// <summary>
    /// Design of the BusStop class that simulates a bus stop system that allows passengers board the bus using
    /// ID, bus stop name, longitude and latitude.
    /// </summary>
    public class BusStop
    {
        //Fields 
        private int _id;
        private string _name = string.Empty;
        private double _latitude;
        private double _longitude;
        private int _passengers = 0;

        //Properties 
        /// <summary>
        /// Gets or sets the _id value. ID must be a positive integer.
        /// </summary>
        public int ID
        {
            get

            {
                return _id;
            } //get 
            set
            {
                if (value <= 0) //To ensure ID is positive and not zero 
                {
                    throw new ArgumentException("Id is out of range");
                } // if statement 
                _id = value;
                Console.WriteLine($"{value} - Valid ID");
            } // set 
        } // ID accessor 

        /// <summary>
        /// Gets and sets the bus stop name (_name). It must not be an emty string
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            } // get 
            set
            {
                if (string.IsNullOrWhiteSpace(value)) //To ensure name is not an empty string 
                {
                    throw new ArgumentException("Name cannot be empty.");
                } // if statement 
                _name = value;
                Console.WriteLine($"{value} - Valid Bus stop name");
            } // set 
        } // name accessor 

        /// <summary>
        /// Gets and sets the bus stop latitude, and it must be within the range of Edinburgh.
        /// </summary>
        public double Latitude
        {
            get
            {
                return _latitude;
            } // get 
            set
            {
                if (!(value <= 55.9 && value >= 55.8))//Ensures longitude is within range and inside Edinburgh 
                {
                    throw new ArgumentException("Latitude is out of range! (Must be within 55.8 and 55.9).");
                } // if statement 
                _latitude = value;
                Console.WriteLine($"{value} - Valid latitude");
           } // set 
        } // latitude accessor 

        /// <summary>
        /// Gets and sets the longitude of the bus stop, and it must be within the range of Edinburgh.
        /// </summary>
        public double Longitude
        {
            get
            {
                return _longitude;
            } // get 
            set
            {
                if (!(value >= -3.4 && value <= -3.0)) //Ensures longitude is within range and inside Edinburgh 
                {
                    throw new ArgumentException("Longitude is out of range! (Must be within -3.0 and -3.4).");
                } // if statement 
                _longitude = value;
                Console.WriteLine($"{value} - Valid longitude");
            } // set 
        } // longitude accessor 

        /// <summary>
        /// Gets the number of passengers that have been added using the board method
        /// </summary>
        public int Passengers //To make sure passenger field cannot manually be changed outside of class 
        {
            get
            {
                return _passengers;
            } // get 
        } // passengers accessor 


        /// <summary>
        /// Increases the number of passengers that have boarded the bus and prints a message
        /// </summary>
        public void Board()
        {
            _passengers++; //Number of passenger increases by 1 when all details are entered 
            Console.WriteLine("A passenger has boarded the bus");
        } // Board method 
    } // BusStop class 
} //CourseWork namespace 