package com.jefvda.spring.students;

import javax.servlet.http.HttpServletResponse;

import com.jefvda.spring.students.jpa.Student;
import com.jefvda.spring.students.jpa.StudentRepository;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestParam;

@Controller
public class StudentsController {

    @Autowired
    private StudentRepository repository;
    
    @GetMapping("/")
    public ResponseEntity<String> getIndex(){
        String all = "<b>All Students:</b></br></br>";

        try {
            // get all Students
            Iterable<Student> itr = this.repository.findAll();
            for(Student s : itr){
                all += s.getName() + "<br/>";
                System.out.println(s);
            }
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }

        return new ResponseEntity<String>(all, HttpStatus.OK);
    }

    @GetMapping("/addForm")
    public String getAddForm(){
        return "addForm";
    }

    @PostMapping("/add")
    public String add(@RequestParam("firstName") String _firstName, @RequestParam("lastName") String _lastName, @RequestParam("birthday") String _birthday, @RequestParam("program") String _program, HttpServletResponse response){

        String name = _firstName + " " + _lastName;
        String birthday = _birthday;
        String program = _program;

        try {
            Student newStudent = new Student(name, birthday, program);

            Student foundStudent = repository.findByName(name);
            if(foundStudent == null)
                this.repository.save(newStudent);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }

        return "redirect:";
    }
}