package edu.ap.flights;

import java.time.LocalDate;
import java.util.ArrayList;

public class Flight {
    private City destination;
    private City from;
    private LocalDate departureTime;
    private Integer flightNumber;

    private ArrayList<Passenger> passengerList;

    public City getDestination() {
        return destination;
    }

    public void setDestination(City destination) {
        this.destination = destination;
    }

    public City getFrom() {
        return from;
    }

    public void setFrom(City from) {
        this.from = from;
    }

    public LocalDate getDepartureTime() {
        return departureTime;
    }

    public void setDepartureTime(LocalDate departureTime) {
        this.departureTime = departureTime;
    }

    public Integer getFlightNumber() {
        return flightNumber;
    }

    public void setFlightNumber(Integer flightNumber) {
        this.flightNumber = flightNumber;
    }

    public ArrayList<Passenger> getPassengerList() {
        return passengerList;
    }

    public void setPassengerList(ArrayList<Passenger> passengerList) {
        this.passengerList = passengerList;
    }

    public Flight(City destination, LocalDate departureTime, Integer flightNumber) {
        this.destination = destination;
        this.from = City.BRUSSEL;
        this.departureTime = departureTime;
        this.flightNumber = flightNumber;

        this.passengerList = new ArrayList<Passenger>();
    }

    @Override
    public String toString() {
        return "Flight{" +
                "destination=" + destination +
                ", from=" + from +
                ", departureTime=" + departureTime +
                ", flightNumber=" + flightNumber +
                '}';
    }
}
