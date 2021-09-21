package edu.ap.flights;

import java.time.LocalDate;

public class Passenger {
    private String firstName;
    private String name;
    private LocalDate birthday;
    private Integer InsuranceNumber;

    public String getFirstName() {
        return firstName;
    }

    public void setFirstName(String firstName) {
        this.firstName = firstName;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public LocalDate getBirthday() {
        return birthday;
    }

    public void setBirthday(LocalDate birthday) {
        this.birthday = birthday;
    }

    public Integer getInsuranceNumber() {
        return InsuranceNumber;
    }

    public void setInsuranceNumber(Integer insuranceNumber) {
        InsuranceNumber = insuranceNumber;
    }

    public Passenger(String firstName, String name, Integer insuranceNumber) {
        this.firstName = firstName;
        this.name = name;
        InsuranceNumber = insuranceNumber;
    }

    public Passenger(String firstName, String name, LocalDate birthday, Integer insuranceNumber) {
        this.firstName = firstName;
        this.name = name;
        this.birthday = birthday;
        InsuranceNumber = insuranceNumber;
    }

    @Override
    public String toString() {
        return "Passenger{" +
                "firstName='" + firstName + '\'' +
                ", name='" + name + '\'' +
                ", birthday=" + birthday +
                ", InsuranceNumber=" + InsuranceNumber +
                '}';
    }
}
