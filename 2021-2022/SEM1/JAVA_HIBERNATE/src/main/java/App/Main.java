package App;

import DAO.StudentDAO;
import Model.Student;

public class Main {
    public static void main(String[] args) {
        StudentDAO studentManager = new StudentDAO();

        System.out.println(studentManager.addStudent("Mohamed", "Saadi", "s125317@ap.be"));
        System.out.println(studentManager.addStudent("Ismael", "Saadi", "s125317@ap.be"));
        System.out.println(studentManager.addStudent("Yassir", "Saadi", "s125317@ap.be"));

        Student student = studentManager.GetStudentByID(3);
        System.out.println(student);
    }
}
