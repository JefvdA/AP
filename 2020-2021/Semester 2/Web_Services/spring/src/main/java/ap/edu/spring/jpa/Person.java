package ap.edu.spring.jpa;

import javax.persistence.*;

@Entity
public class Person {
    
    @Id
    @GeneratedValue
    private long id;

    @Column(unique = true)
    private String name;

    public Person(){
        this.name = "Stranger";
    }

    public Person(String name){
        this.name = name;
    }

    public void setId(long id){
        this.id = id;
    }
    
    public long getId(){
        return this.id;
    }

    public void setName(String name){
        this.name = name;
    }

    public String getName(){
        return this.name;
    }
}