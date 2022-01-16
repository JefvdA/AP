package edu.ap.jefvda.Voorbeeldexamen_Vraag1.dao;

import edu.ap.jefvda.Voorbeeldexamen_Vraag1.entity.Film;
import edu.ap.jefvda.Voorbeeldexamen_Vraag1.util.HibernateUtil;
import org.hibernate.Session;
import org.hibernate.Transaction;

import java.util.List;
import java.util.Locale;

public class FilmDao {

    // Add a new object with given parameters, and add it to database. Also return this film so u can use it if needed.
    public Film createFilm(int showId, String title, String director, String country, int releaseYear, String description) {
        // create object
        Film film = new Film(showId, title, director, country, releaseYear, description);

        Transaction transaction = null;
        try (Session session = HibernateUtil.getSessionFactory().openSession()) {

            transaction = session.beginTransaction();
            session.save(film);
            transaction.commit();

        } catch (Exception e) {
            if (transaction != null) {
                transaction.rollback();
            }
            e.printStackTrace();
        }
        return film;
    }

    // Add an already created object to the database
    public void addFilm(Film film){
        Transaction transaction = null;
        try(Session session = HibernateUtil.getSessionFactory().openSession()){

            transaction = session.beginTransaction();
            session.save(film);
            transaction.commit();

        } catch(Exception e){
            if(transaction != null){
                transaction.rollback();
            }
            e.printStackTrace();
        }
    }

    // Get all the objects and return them
    public List<Film> getFilms(){
        try(Session session = HibernateUtil.getSessionFactory().openSession()) {
            return session.createQuery("SELECT f FROM Film f", Film.class).list();

        }catch (Exception e){
            e.printStackTrace();
        }
        return null;
    }

    // Get all objects by searching for a matching releaseYear
    public List<Film> getFilmsByReleaseYear(int year){
        try(Session session = HibernateUtil.getSessionFactory().openSession()) {
            return session.createQuery("SELECT f FROM Film f WHERE f.releaseYear = " + year, Film.class).list();

        }catch (Exception e){
            e.printStackTrace();
        }
        return null;
    }

    // Get all objects by searching for a part recurring in the title
    public List<Film> getFilmsByPartInTitle(String text){
        try(Session session = HibernateUtil.getSessionFactory().openSession()) {
            return session.createQuery("SELECT f FROM Film f WHERE UPPER(f.title) LIKE '%" + text.toUpperCase() + "%'", Film.class).list();

        }catch (Exception e){
            e.printStackTrace();
        }
        return null;
    }
}
