package AP.labo2.garage;

public class FamilyCar extends Car{
    private Integer seats;
    private Boolean towBar;

    public Integer getSeats() {
        return seats;
    }

    public Boolean getTowBar() {
        return towBar;
    }

    public void setTowBar(Boolean towBar) {
        this.towBar = towBar;
    }

    public FamilyCar(Integer sequenceNumber, CarType type, CarBrand brand, float kmDriven, Integer chassisNumber, String licencePlate, Integer seats, Boolean towBar) {
        super(sequenceNumber, type, brand, kmDriven, chassisNumber, licencePlate);
        this.seats = seats;
        this.towBar = towBar;
    }

    @Override
    public String toString() {
        return "FamilyCar{" +
                "seats=" + seats +
                ", towBar=" + towBar +
                "} " + super.toString();
    }
}
