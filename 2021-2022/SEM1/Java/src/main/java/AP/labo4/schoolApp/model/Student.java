package AP.labo4.schoolApp.model;

import java.util.Objects;

public class Student extends Member implements Learning {
    private int studentPoints;
    private StudentMajor major;

    public int getStudentPoints() {
        return studentPoints;
    }

    public void setStudentPoints(int studentPoints) {
        this.studentPoints = studentPoints;
    }

    public StudentMajor getMajor() {
        return major;
    }

    public void setMajor(StudentMajor major) {
        this.major = major;
    }

    public Student() {
    }

    public Student(String name, String firstName, int memberId, int studentPoints, StudentMajor major) {
        super(name, firstName, memberId);
        this.studentPoints = studentPoints;
        this.major = major;
    }

    @Override
    public String toString() {
        return "Student{" +
                "studentPoints=" + studentPoints +
                ", major=" + major +
                "} " + super.toString();
    }

    @Override
    public void learn() {
        System.out.println(super.getName() + " " + super.getFirstName() + " is learning!");
    }

    @Override
    public int compareTo(Member o) {
        return super.getFirstName().compareTo(o.getFirstName());
    }
}
