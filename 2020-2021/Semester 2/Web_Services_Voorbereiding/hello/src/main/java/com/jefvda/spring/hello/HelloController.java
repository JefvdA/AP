package com.jefvda.spring.hello;

import java.time.LocalTime;

import javax.servlet.http.Cookie;
import javax.servlet.http.HttpServletResponse;

import com.jefvda.spring.hello.jpa.Person;
import com.jefvda.spring.hello.jpa.PersonRepository;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;

@Controller
public class HelloController {
    
    private String name;
    @Autowired
    private PersonRepository repository;

    public HelloController(){
        this.name = "Stranger";
    }

    @RequestMapping("/")
    public String getIndex(){
        return "index";
    }

    @RequestMapping("/hello")
    public ResponseEntity<String> getHello(){

        try {
            // get the new person
            Person person = this.repository.findByName(this.name);
            this.name = person.getName();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }

        return new ResponseEntity<String>("Hello " + this.name, HttpStatus.OK);
    }

    @RequestMapping("/helloTemplate")
    public String getHelloTemplate(Model model){

        try {
            // get the new person
            Person person = this.repository.findByName(this.name);
            this.name = person.getName();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }

        model.addAttribute("name", this.name);

        return "helloTemplate";
    }

    @RequestMapping("/all")
    public ResponseEntity<String> getAll(){

        String all = "<b>All Persons</b><br/><br/>";
        
        try {
            // get all Persons
            Iterable<Person> itr = this.repository.findAll();
            for(Person p : itr){
                all += p.getName() + "<br/>";
            }
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }

        return new ResponseEntity<String>(all, HttpStatus.OK);
    }

    @RequestMapping("/addForm")
    public String getAddForm(){
        return "add_form";
    }

    @PostMapping("/add")
    public String add(@RequestParam("name") String name, HttpServletResponse response){

        this.name = name.trim();
        LocalTime localTime = LocalTime.now();
        response.addCookie(new Cookie("time", "" + localTime.getMinute()));

        try {
            // save the new Person
            Person newPerson = new Person(this.name);
            this.repository.save(newPerson);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }

        return "redirect:helloTemplate";
    }
}