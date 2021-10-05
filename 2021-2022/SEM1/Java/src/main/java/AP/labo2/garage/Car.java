package AP.labo2.garage;

import java.util.Objects;

public abstract class Car implements Comparable<Car>{
    private Integer sequenceNumber;
    private CarType type;
    private CarBrand brand;
    private float kmDriven;
    private Integer chassisNumber;
    private String licencePlate;

    public Integer getSequenceNumber() {
        return sequenceNumber;
    }

    public CarType getType() {
        return type;
    }

    public CarBrand getBrand() {
        return brand;
    }

    public float getKmDriven() {
        return kmDriven;
    }

    public void setKmDriven(float kmDriven) {
        this.kmDriven = kmDriven;
    }

    public Integer getChassisNumber() {
        return chassisNumber;
    }

    public String getLicencePlate() {
        return licencePlate;
    }

    public void setLicencePlate(String licencePlate) {
        this.licencePlate = licencePlate;
    }

    public Car(Integer sequenceNumber, CarType type, CarBrand brand, float kmDriven, Integer chassisNumber, String licencePlate) {
        this.sequenceNumber = sequenceNumber;
        this.type = type;
        this.brand = brand;
        this.kmDriven = kmDriven;
        this.chassisNumber = chassisNumber;
        this.licencePlate = licencePlate;
    }

    @Override
    public int compareTo(Car o) {
        if(this.sequenceNumber == o.sequenceNumber)
            return 0;
        else if(this.sequenceNumber > o.sequenceNumber)
            return 1;
        else
            return -1;
    }

    @Override
    public String toString() {
        return "Car{" +
                "sequenceNumber=" + sequenceNumber +
                ", type=" + type +
                ", brand=" + brand +
                ", kmDriven=" + kmDriven +
                ", chassisNumber=" + chassisNumber +
                ", licencePlate='" + licencePlate + '\'' +
                '}';
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Car car = (Car) o;
        return Objects.equals(chassisNumber, car.chassisNumber);
    }

    @Override
    public int hashCode() {
        return Objects.hash(chassisNumber);
    }
}
