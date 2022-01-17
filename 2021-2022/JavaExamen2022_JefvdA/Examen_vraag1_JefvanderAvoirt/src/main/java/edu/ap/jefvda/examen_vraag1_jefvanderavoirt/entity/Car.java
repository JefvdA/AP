package edu.ap.jefvda.examen_vraag1_jefvanderavoirt.entity;

import edu.ap.jefvda.examen_vraag1_jefvanderavoirt.CarType;

import javax.persistence.*;
import java.util.Date;
import java.util.Objects;

@Entity
@Table(name = "Car")
public class Car {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "ID")
    private int ID;

    @Column(name = "carBrand")
    private String carBrand;

    @Column(name = "carModel")
    private String carModel;

    @Column(name = "firstRegisteryDate")
    private Date firstRegisteryDate;

    @Column(name = "carType")
    private CarType carType;

    @Column(name = "purchasePrice")
    private float purchasePrice;

    public Car() {}

    public Car(String carBrand, String carModel, Date firstRegisteryDate, CarType carType, float purchasePrice) {
        this.carBrand = carBrand;
        this.carModel = carModel;
        this.firstRegisteryDate = firstRegisteryDate;
        this.carType = carType;
        this.purchasePrice = purchasePrice;
    }

    public String getCarBrand() {
        return carBrand;
    }

    public void setCarBrand(String carBrand) {
        this.carBrand = carBrand;
    }

    public String getCarModel() {
        return carModel;
    }

    public void setCarModel(String carModel) {
        this.carModel = carModel;
    }

    public Date getFirstRegisteryDate() {
        return firstRegisteryDate;
    }

    public void setFirstRegisteryDate(Date firstRegisteryDate) {
        this.firstRegisteryDate = firstRegisteryDate;
    }

    public CarType getCarType() {
        return carType;
    }

    public void setCarType(CarType carType) {
        this.carType = carType;
    }

    public float getPurchasePrice() {
        return purchasePrice;
    }

    public void setPurchasePrice(float purchasePrice) {
        this.purchasePrice = purchasePrice;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Car car = (Car) o;
        return ID == car.ID && Float.compare(car.purchasePrice, purchasePrice) == 0 && Objects.equals(carBrand, car.carBrand) && Objects.equals(carModel, car.carModel) && Objects.equals(firstRegisteryDate, car.firstRegisteryDate) && carType == car.carType;
    }

    @Override
    public int hashCode() {
        return Objects.hash(ID, carBrand, carModel, firstRegisteryDate, carType, purchasePrice);
    }

    @Override
    public String toString() {
        return "Car{" +
                "ID=" + ID +
                ", carBrand='" + carBrand + '\'' +
                ", carModel='" + carModel + '\'' +
                ", firstRegisteryDate=" + firstRegisteryDate +
                ", carType=" + carType +
                ", purchasePrice=" + purchasePrice +
                '}';
    }
}
