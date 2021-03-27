package ap.edu.spring;

import java.time.LocalTime;

import javax.servlet.http.Cookie;
import javax.servlet.http.HttpServletResponse;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.context.annotation.Scope;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.CookieValue;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.ui.Model;

import ap.edu.spring.aop.Interceptable;
import ap.edu.spring.jpa.*;
import net.bytebuddy.asm.Advice.Local;

@Controller
@Scope("session")
public class HelloController {
    
    private String name;
    @Autowired
    private PersonRepository repository;

    public HelloController(){
        this.name = "Stranger";
    }

    @Interceptable
    @RequestMapping("/hello")
    public ResponseEntity<String> getHello() {

        try {
            // get the new person
            Person savedPerson = this.repository.findByName(this.name);
            this.name = savedPerson.getName();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }

        return new ResponseEntity<String>("Hello " + this.name, HttpStatus.OK);
    }

    @RequestMapping("/helloTemplate")
    public String getHelloTemplate(Model model){

        try {
            // get the new person
            Person savedPerson = this.repository.findByName(this.name);
            this.name = savedPerson.getName();
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
            // get all persons
            Iterable<Person> itr = this.repository.findAll();
            for (Person p : itr){
                all += p.getName() + "<br/>";
            }
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }

        return new ResponseEntity<String>(all, HttpStatus.OK);
    }

    @RequestMapping("/addForm")
    public String getAddFrom() {
        return "addForm";
    }

    @PostMapping("/add")
    public String add(@RequestParam("name") String name, HttpServletResponse response){

        this.name = name.trim();
        LocalTime localTime = LocalTime.now();
        response.addCookie(new Cookie("remote", "" + localTime.getMinute()));
    
        try {
            // save the new person
            Person newPerson = new Person(this.name);
            this.repository.save(newPerson);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }

        return "redirect:hello";
    }

    @RequestMapping("/cookie")
    public ResponseEntity<String> getCookie(@CookieValue(value = "remote", defaultValue = "Unknown") String remote) {

        return new ResponseEntity<String>("Cookie : " + remote, HttpStatus.OK);
    }
}