package edu.ap.jefvda.examen_vraag1_jefvanderavoirt.dao;

import edu.ap.jefvda.examen_vraag1_jefvanderavoirt.entity.Car;
import edu.ap.jefvda.examen_vraag1_jefvanderavoirt.CarType;
import edu.ap.jefvda.examen_vraag1_jefvanderavoirt.util.HibernateUtil;
import org.hibernate.Session;
import org.hibernate.Transaction;

import java.util.Date;
import java.util.List;

public class CarDao {
    // Add a new object with given parameters, and add it to database. Also return this object so u can use it if needed.
    public Car createCar(String carBrand, String carModel, Date firstRegisteryDate, CarType carType, float purchasePrice) {
        // create object
        Car car = new Car(carBrand, carModel, firstRegisteryDate, carType, purchasePrice);

        Transaction transaction = null;
        try (Session session = HibernateUtil.getSessionFactory().openSession()) {

            transaction = session.beginTransaction();
            session.save(car);
            transaction.commit();

        } catch (Exception e) {
            if (transaction != null) {
                transaction.rollback();
            }
            e.printStackTrace();
        }
        return car;
    }

    // Add an already created object to the database
    public void addCar(Car car){
        Transaction transaction = null;
        try(Session session = HibernateUtil.getSessionFactory().openSession()){

            transaction = session.beginTransaction();
            session.save(car);
            transaction.commit();

        } catch(Exception e){
            if(transaction != null){
                transaction.rollback();
            }
            e.printStackTrace();
        }
    }

    // Get all the objects and return them
    public List<Car> getCars(){
        try(Session session = HibernateUtil.getSessionFactory().openSession()) {
            return session.createQuery("SELECT c FROM Car c", Car.class).list();

        }catch (Exception e){
            e.printStackTrace();
        }
        return null;
    }

    // Add a whole new list of cars (and over-write the old ones)
    public void replaceCars(List<Car> cars){
        Transaction transaction = null;
        try(Session session = HibernateUtil.getSessionFactory().openSession()){

            List<Car> currentCars = getCars();
            currentCars.forEach(this::deleteCar); // Remove all current cars
            cars.forEach(this::addCar); // Add all new cars

            transaction = session.beginTransaction();
            transaction.commit();

        } catch(Exception e){
            if(transaction != null){
                transaction.rollback();
            }
            e.printStackTrace();
        }
    }

    // Delete a car
    public boolean deleteCar(Car car){
        Transaction transaction = null;
        try(Session session = HibernateUtil.getSessionFactory().openSession()){

            transaction = session.beginTransaction();
            session.delete(car);
            transaction.commit();

        } catch(Exception e){
            if(transaction != null){
                transaction.rollback();
            }
            e.printStackTrace();
            return false;
        }
        return true;
    }
}
