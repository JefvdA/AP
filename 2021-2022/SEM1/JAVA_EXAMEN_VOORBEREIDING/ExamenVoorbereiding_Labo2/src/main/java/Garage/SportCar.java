package Garage;

import java.util.Objects;

public class SportCar extends Car {
    private int pk;

    public SportCar(int sequenceNumber, CarBrand brand, int kmDriven, int chassisNumber, String licenceNumber, int pk) {
        super(sequenceNumber, brand, kmDriven, chassisNumber, licenceNumber);
        this.pk = pk;
    }

    public int getPk() {
        return pk;
    }

    public void setPk(int pk) {
        this.pk = pk;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        if (!super.equals(o)) return false;
        SportCar sportCar = (SportCar) o;
        return pk == sportCar.pk;
    }

    @Override
    public int hashCode() {
        return Objects.hash(super.hashCode(), pk);
    }

    @Override
    public String toString() {
        return "SportCar{" +
                "pk=" + pk +
                "} " + super.toString();
    }
}
