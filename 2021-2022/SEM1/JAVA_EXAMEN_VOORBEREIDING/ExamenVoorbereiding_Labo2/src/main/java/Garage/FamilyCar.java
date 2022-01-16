package Garage;

import java.util.Objects;

public class FamilyCar extends Car {
    private final int seats;
    private Boolean towBar;

    public FamilyCar(int sequenceNumber, CarBrand brand, int kmDriven, int chassisNumber, String licenceNumber, int seats, Boolean towBar) {
        super(sequenceNumber, brand, kmDriven, chassisNumber, licenceNumber);
        this.seats = seats;
        this.towBar = towBar;
    }

    public int getSeats() {
        return seats;
    }

    public Boolean getTowBar() {
        return towBar;
    }

    public void setTowBar(Boolean towBar) {
        this.towBar = towBar;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        if (!super.equals(o)) return false;
        FamilyCar familyCar = (FamilyCar) o;
        return seats == familyCar.seats && Objects.equals(towBar, familyCar.towBar);
    }

    @Override
    public int hashCode() {
        return Objects.hash(super.hashCode(), seats, towBar);
    }

    @Override
    public String toString() {
        return "FamilyCar{" +
                "seats=" + seats +
                ", towBar=" + towBar +
                "} " + super.toString();
    }
}
