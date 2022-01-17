package edu.ap.jefvda.examen_vraag1_jefvanderavoirt.util;

import edu.ap.jefvda.examen_vraag1_jefvanderavoirt.entity.Car;
import org.hibernate.SessionFactory;
import org.hibernate.cfg.Configuration;

public class HibernateUtil {

    private static SessionFactory sessionFactory;

    public static SessionFactory getSessionFactory() {

        if (sessionFactory == null){

            try{
                // get config
                Configuration configuration = new Configuration().configure("hibernate.cfg.xml");
                //add config entity class as -> configuration.addAnnotatedClass(entityClass.class):
                configuration.addAnnotatedClass(Car.class);
                sessionFactory = configuration.buildSessionFactory();

            }catch (Exception e) {
                e.printStackTrace();
            }
        }
        return sessionFactory;
    }

}