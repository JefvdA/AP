package edu.ap.jefvda.Voorbeeldexamen_Vraag1;

import edu.ap.jefvda.Voorbeeldexamen_Vraag1.dao.FilmDao;
import edu.ap.jefvda.Voorbeeldexamen_Vraag1.entity.Film;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.util.List;
import java.util.Objects;
import java.util.Scanner;

public class FilmController {
    static FilmDao filmDao;

    public static void main(String[] args) {
        filmDao = new FilmDao();
        importFromCsv();

        startUIApp();
    }

    private static void startUIApp(){
        System.out.println("Welcome @ Java's movie database!");

        boolean runApp = true;
        while (runApp){
            int menuOption = getMenuOption();
            switch (menuOption){
                case 1:
                    searchByYear();
                    break;
                case 2:
                    searchByTitle();
                    break;
                case 3:
                    runApp = false;
                    break;
                default:
                    System.out.println("Sorry, dat is geen geldige optie, probeer opnieuw!");
                    break;
            }
        }
    }

    private static void searchByYear(){
        System.out.println("U koos: zoeken op jaar");
        int year = getInputInt("Geef uw jaar: ");

        List<Film> films =  filmDao.getFilmsByReleaseYear(year);
        films.forEach(System.out::println);
    }

    private static void searchByTitle(){
        System.out.println("U koos: zoeken op titel");
        String title = getInputString("Geef uw titel: ");

        List<Film> films = filmDao.getFilmsByPartInTitle(title);
        films.forEach(System.out::println);
    }

    private static int getMenuOption(){
        System.out.println("Wat wilt u doen?");
        System.out.println("1. Zoeken op jaar");
        System.out.println("2. Zoeken op titel");
        System.out.println("3. Dit programma afsluiten");

        return getInputInt("Geef de nummer van uw keuze: ");
    }

    private static int getInputInt(String question){
        System.out.println(question);
        Scanner consoleInput = new Scanner(System.in);
        return consoleInput.nextInt();
    }

    private static String getInputString(String question){
        System.out.println(question);
        Scanner consoleInput = new Scanner(System.in);
        return consoleInput.nextLine();
    }

    private static void importFromCsv(){
        String line = "";
        String splitBy = ";";
        try
        {
            //parsing a CSV file into BufferedReader class constructor
            BufferedReader br = new BufferedReader(new FileReader("src/main/resources/netflix_titles.csv"));
            int num = -1;
            while ((line = br.readLine()) != null)   //returns a Boolean value
            {
                num++;
                String[] film = line.split(splitBy);    // use comma as separator

                if(film.length < 11 || num == 0) // Skip over movies that don't have all the properties
                    continue;

                // Get properties out of film
                String showId = film[0];
                String type = film[1];
                String title = film[2];
                String director = film[3];
                String country = film[5];
                String releaseYear = film[7];
                String description = film[11];

                if(Objects.equals(type, "Movie"))
                    filmDao.createFilm(Integer.parseInt(showId), title, director, country, Integer.parseInt(releaseYear), description);
            }
        } catch (IOException e)
        {
            e.printStackTrace();
        }
    }
}
