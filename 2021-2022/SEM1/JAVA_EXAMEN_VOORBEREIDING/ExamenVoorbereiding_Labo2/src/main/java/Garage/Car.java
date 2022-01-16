package Garage;

import java.util.Objects;

public class Car implements Comparable<Car> {
    private final int sequenceNumber;
    private final CarBrand brand;
    private int kmDriven;
    private final int KMFactor;
    private final int chassisNumber;
    private String licenceNumber;

    public Car(int sequenceNumber, CarBrand brand, int kmDriven, int chassisNumber, String licenceNumber) {
        this.sequenceNumber = sequenceNumber;
        this.brand = brand;
        this.kmDriven = kmDriven;
        this.KMFactor = 100;
        this.chassisNumber = chassisNumber;
        this.licenceNumber = licenceNumber;
    }

    public int getSequenceNumber() {
        return sequenceNumber;
    }

    public CarBrand getBrand() {
        return brand;
    }

    public int getKmDriven() {
        return kmDriven;
    }

    public void setKmDriven(int kmDriven) {
        this.kmDriven = kmDriven;
    }

    public String getLicenceNumber() {
        return licenceNumber;
    }

    public void setLicenceNumber(String licenceNumber) {
        this.licenceNumber = licenceNumber;
    }

    public int getKMFactor() {
        return KMFactor;
    }

    public int getChassisNumber() {
        return chassisNumber;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Car car = (Car) o;
        return chassisNumber == car.chassisNumber;
    }

    @Override
    public int hashCode() {
        return Objects.hash(chassisNumber);
    }

    @Override
    public String toString() {
        return "Car{" +
                "sequenceNumber=" + sequenceNumber +
                ", brand='" + brand + '\'' +
                ", kmDriven=" + kmDriven +
                ", KMFactor=" + KMFactor +
                ", chassisNumber=" + chassisNumber +
                ", licenceNumber='" + licenceNumber + '\'' +
                '}';
    }

    @Override
    public int compareTo(Car that) {
        if (this.getSequenceNumber() != that.getSequenceNumber()) {
            return (this.getSequenceNumber() < that.getSequenceNumber() ? -1 : 1);
        }

        return 0;
    }
}
