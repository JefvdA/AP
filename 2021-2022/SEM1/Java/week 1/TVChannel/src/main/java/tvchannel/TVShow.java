package tvchannel;

import java.time.LocalDate;

public class TVShow {
    private String name;
    private Person showHost;
    private Integer length;
    private LocalDate airTime;
    private Genre genre;

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public Person getShowHost() {
        return showHost;
    }

    public void setShowHost(Person showHost) {
        this.showHost = showHost;
    }

    public Integer getLength() {
        return length;
    }

    public void setLength(Integer length) {
        this.length = length;
    }

    public LocalDate getAirTime() {
        return airTime;
    }

    public void setAirTime(LocalDate airTime) {
        this.airTime = airTime;
    }

    public Genre getGenre() {
        return genre;
    }

    public void setGenre(Genre genre) {
        this.genre = genre;
    }

    public TVShow(String name, Person showHost, Integer length, LocalDate airTime, Genre genre) {
        this.name = name;
        this.showHost = showHost;
        this.length = length;
        this.airTime = airTime;
        this.genre = genre;
    }
}
