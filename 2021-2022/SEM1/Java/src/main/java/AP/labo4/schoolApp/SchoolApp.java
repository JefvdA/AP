package AP.labo4.schoolApp;

import AP.labo4.schoolApp.model.*;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class SchoolApp {
    public static void main(String[] args) {
        List<Student> students = new ArrayList<Student>();
        students.add(new Student("Den bos", "Jos", 1234, 180, StudentMajor.EICT));
        students.add(new Student("Van Eik", "Danny", 1237, 8, StudentMajor.EICT));
        students.add(new Student("Struik", "Marie", 1235, 80, StudentMajor.IT));
        students.add(new Student("Van Boom", "Tom",1236, 100, StudentMajor.DUTCH));

        List<Teacher> teachers = new ArrayList<Teacher>();
        teachers.add(new Teacher("Wegge", "Lus", 3234, Course.JAVA));
        teachers.add(new Teacher("Van Mechelen", "Eden", 2234, Course.JAVA));
        teachers.add(new Teacher("Wegge", "Lus", 3234, Course.JAVA));

        System.out.println(teachers.get(0).equals(teachers.get(2)));

        List<Member> members = new ArrayList<Member>();
        members.addAll(students);
        members.addAll(teachers);

        Collections.sort(members);

        GuestTeacher guestTeacher = new GuestTeacher("Jansens", "Bill");
        ForeignStudent foreignStudent = new ForeignStudent();

        members.forEach(m -> System.out.println(m));

        //teachers.get(0).teach(students.get(0));
        //guestTeacher.teach(students.get(1));
        //teachers.get(1).teach(foreignStudent);
    }
}
