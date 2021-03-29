package com.jefvda.spring.students.jpa;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;

@Entity
public class Student {
    
    // Properties
    @Id
    @GeneratedValue
    private long id;

    @Column
    private String name;

    @Column
    private String birthday;

    @Column
    private String program;

    // Constructor
    public Student(){
        this.name = "Jan Jansens";
        this.birthday = "UNKNOWN";
        this.program = "IT";
    }

    public Student(String name, String birthday, String program) {
        this.name = name;
        this.birthday = birthday;
        this.program = program;
    }

    // Getters and Setters
    public long getId() {
        return this.id;
    }

    public void setId(long id) {
        this.id = id;
    }

    public String getName(){
        return this.name;
    }

    public void setName(String name){
        this.name = name;
    }

    public String getBirthday() {
        return this.birthday;
    }

    public void setBirthday(String birthday) {
        this.birthday = birthday;
    }

    public String getProgram() {
        return this.program;
    }

    public void setProgram(String program) {
        this.program = program;
    }

}