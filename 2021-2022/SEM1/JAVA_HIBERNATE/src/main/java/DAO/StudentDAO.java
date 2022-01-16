package DAO;

import java.util.List;
import java.util.stream.Collectors;

import javax.persistence.criteria.CriteriaBuilder;
import javax.persistence.criteria.CriteriaQuery;
import javax.persistence.criteria.Root;

import org.hibernate.HibernateException;
import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.Transaction;
import org.hibernate.cfg.Configuration;
import org.hibernate.query.Query;
import Model.Student;

public class StudentDAO {
    private static SessionFactory factory;

    public StudentDAO() {
        try {
            //could also be
            factory = new Configuration().configure().buildSessionFactory();
        } catch (Throwable ex) {
            System.err.println("Failed to create sessionFactory object." + ex);
            throw new ExceptionInInitializerError(ex);
        }
    }


    public Integer addStudent(String firstname, String lastname, String email) {
        Session session = factory.openSession();
        Transaction tx = null;
        Integer studentID = null;

        try {
            tx = session.beginTransaction();
            Student student = new Student(firstname, lastname, email);
            studentID = (Integer) session.save(student);
            tx.commit();
        } catch (HibernateException e) {
            if (tx != null)
                tx.rollback();
            e.printStackTrace();
        } finally {
            session.close();
        }
        return studentID;
    }


    public List<Student> getStudents() {
        Session session = factory.openSession();
        Transaction tx = null;
        List<Student> students = null;

        try {
            tx = session.beginTransaction();
            students = session.createQuery("from Student", Student.class).list();
            return students;
        } catch (Exception e) {
            if (tx != null)
                tx.rollback();
            e.printStackTrace();
        } finally {
            session.close();
        }
        return null;
    }

    public Student GetStudentByID(int id) {
        Session session = factory.openSession();
        CriteriaBuilder builder = session.getCriteriaBuilder();
        Transaction tx = null;

        try {
            tx = session.beginTransaction();
            List<Student> students = session.createQuery("from Student", Student.class).list();
            Student student = students.stream().filter(s -> s.getId() == id).findFirst().orElse(null);
            return student;
        } catch (Exception e) {
            if (tx != null)
                tx.rollback();
            e.printStackTrace();
        } finally {
            session.close();
        }
        return null;
    }
}