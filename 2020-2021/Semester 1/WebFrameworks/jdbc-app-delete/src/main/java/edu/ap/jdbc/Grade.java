package edu.ap.jdbc;

public class Grade {

    private int id;
    private String firstName;
    private String lastName;
    private int grade;


    public Grade(int id, String firstName, String lastName, int grade) {
        this.id = id;
        this.firstName = firstName;
        this.lastName = lastName;
        this.grade = grade;
    }


    public int getId() {
        return this.id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getFirstName() {
        return this.firstName;
    }

    public void setFirstName(String firstName) {
        this.firstName = firstName;
    }

    public String getLastName() {
        return this.lastName;
    }

    public void setLastName(String lastName) {
        this.lastName = lastName;
    }

    public int getGrade() {
        return this.grade;
    }

    public void setGrade(int grade) {
        this.grade = grade;
    }
}
