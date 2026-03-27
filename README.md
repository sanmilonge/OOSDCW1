# Bus Stop System (OOSDCW1)

![Language](https://img.shields.io/badge/Language-C%23-blue)
![Framework](https://img.shields.io/badge/.NET-6.0+-purple)
![Status](https://img.shields.io/badge/Status-Completed-success)
![License](https://img.shields.io/badge/License-Educational-lightgrey)

## Overview

This project was developed as part of the **Object-Oriented Software Development (OOSD)** coursework. It demonstrates the design and implementation of a class-based system in C#, focusing on input validation, encapsulation, and structured program flow.

The application simulates a bus stop system where passengers are recorded based on validated input parameters.

---

## Objectives

* Apply core object-oriented programming principles
* Implement robust input validation using exceptions
* Develop a maintainable and modular class structure
* Demonstrate controlled data access through properties

---

## System Description

The system consists of two main components:

* `Main.cs`: Handles user interaction, input processing, and program flow
* `BusStop.cs`: Defines the `BusStop` class, including validation logic and passenger tracking

Users are prompted to input:

* Bus Stop ID
* Bus Stop Name
* Latitude
* Longitude

Each value is validated before being accepted into the system.

---

## Features

* Strong encapsulation using private fields and public properties
* Validation logic embedded within property setters
* Exception handling for invalid input
* Continuous user interaction via console interface
* Passenger counting mechanism

---

## Validation Rules

| Property  | Constraint                           |
| --------- | ------------------------------------ |
| ID        | Must be a positive integer           |
| Name      | Cannot be null, empty, or whitespace |
| Latitude  | Must be between 55.8 and 55.9        |
| Longitude | Must be between -3.4 and -3.0        |

---

## How to Run

### Prerequisites

* .NET SDK (6.0 or higher)

### Execution

```bash
dotnet run
```

---

## Example Usage

```
ID: 1
Name: Princes Street
Latitude: 55.85
Longitude: -3.2

A passenger has boarded the bus
```

---

## Design Considerations

* **Encapsulation**: Internal state is protected using private fields
* **Validation**: All constraints are enforced at the property level
* **Separation of Concerns**: Input handling and business logic are separated
* **Error Handling**: Exceptions provide clear feedback to the user

---

## Limitations

* Console-based interface only
* No persistent data storage
* Single bus stop instance

---

## Future Enhancements

* Graphical user interface (WPF or WinForms)
* Persistent storage (file or database)
* Support for multiple bus stops
* Unit testing implementation
* Logging and analytics

---

## Author

Oluwasanmi Longe
GitHub: https://github.com/sanmilonge

---

## License

This project is intended for educational use only.
