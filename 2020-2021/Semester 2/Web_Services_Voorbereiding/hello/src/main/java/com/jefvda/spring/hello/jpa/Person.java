package com.jefvda.spring.hello.jpa;

import javax.persistence.*;

@Entity
public class Person {
    
    // Properties
    @Id
    @GeneratedValue
    private long id;

    @Column(unique = true)
    private String name;

    // Getters and setters
    public Person(){
        this.name = "Stranger";
    }

    public Person(String name){
        this.name = name;
    }

    public long getId() {
        return this.id;
    }

    public void setId(long id) {
        this.id = id;
    }

    public String getName() {
        return this.name;
    }

    public void setName(String name) {
        this.name = name;
    }
}