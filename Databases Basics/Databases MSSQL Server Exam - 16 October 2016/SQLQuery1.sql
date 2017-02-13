CREATE TABLE Flights
(

FlightID INT PRIMARY KEY   CHECK (FlightID >=1),
DepartureTime DATETIME NOT NULL,
ArrivalTime DATETIME NOT NULL,
Status VARCHAR(9) CHECK (Status IN ('Departing','Delayed','Arrived','Cancelled')),
OriginAirportID INT CHECK (OriginAirportID>=1),
DestinationAirportID INT CHECK (DestinationAirportID>=1),
AirlineID INT CHECK (AirlineID>=1),
FOREIGN KEY (OriginAirportID) REFERENCES Airports(AirportID),
FOREIGN KEY (DestinationAirportID) REFERENCES Airports(AirportID),
FOREIGN KEY (AirlineID) REFERENCES Airlines(AirlineID),

)

CREATE TABLE Tickets
(
TicketId INT PRIMARY KEY CHECK (TicketID>=1),
Price NUMERIC (8,2) NOT NULL,
Class VARCHAR(6) CHECK (Class IN ('First','Second','Third')),
Seat VARCHAR(5) NOT NULL,
CustomerID INT CHECK (CustomerID>=1),
FlightID INT CHECK (FlightID>=1),
FOREIGN KEY (FlightID) REFERENCES Flights(FlightID),
FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID) 
)