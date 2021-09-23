package edu.ap.flights;

import java.time.LocalDate;
import java.util.ArrayList;

public class FlightManager {
    public static void main(String[] args) {
        Flight flight = new Flight(City.PARIJS, LocalDate.now(), 1);
        Passenger passenger1 = new Passenger("Jef", "van der Avoirt", 2630383);
        Passenger passenger2 = new Passenger("Louise", "van der Avoirt", 38428930);

        flight.getPassengerList().add(passenger1);
        flight.getPassengerList().add(passenger2);
        System.out.print(flight.getPassengerList());
    }
}
