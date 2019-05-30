# Booking-Platform
GOLOGIC code challenge

Description of the problem and solution.
This is a booking platform for users to rent a room. Users will see a list of rooms available for rent and able to click into them to see details about that room. A room 
A room has the following details:
- Title
- Images
- Price
- Description
- Address
- Capacity of room

Users can be able to book the room using their email address, the dates they require and how many people will be staying. 
They cannot be able to book a room on a date that has already been booked or doesn't have the capacity for the number of people they require.


Reasoning behind my technical choices, including architectural.
This is a Single Page Application with ASP.Net Core 2.0
Microsoft Visual Studio Community 2017 Version 15.9.5
Target Framework - .Net Core 2.2
Entity Framework Core
Angular CLI version 6
MS SQL Express v17.9.1

I used CQRS(Command and Query Responsibility Segregation) Pattern to maximize performance, scalability and security. It can also support the evolution of the system over time through higher flexibility. It can also prevent update commands from causing merge conflicts at the domain level.

Trade-offs you might have made, anything you left out, or what you might do differently if you were to spend additional time on the project.

I left out the front-end part but if given the time I will continue the routing of components.

I use OAS(Open API Specification) which defines the standard interface description for REST APIs. For the tool chain I use NSwag.

I got an issue with SwaggerUiSettings but if I still got time I would like to resolve it.
I still need to create filters for validating the inputted data for the selected room.
If I still have time I would like to create the unit test too to use TDD process



Angular CLI Level : Beginner
Single Page Appliction Level : Beginner


Link to my resume 
https://www.linkedin.com/in/sherleedinodizon/

Link to other code you're particularly proud of.
https://www.mssqltips.com/sqlserverauthor/71/sherlee-dizon/
