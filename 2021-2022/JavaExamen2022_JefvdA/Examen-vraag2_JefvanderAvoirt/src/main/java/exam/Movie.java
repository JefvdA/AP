package exam;

public class Movie implements Comparable<Movie> {

	private String title;
	private String director;
	private String leadActor;
	private Integer publishYear;
	private Genre genre;

	public Movie(String title, String director, String leadActor, Integer publishYear, Genre genre) {
		super();
		this.title = title;
		this.director = director;
		this.leadActor = leadActor;
		this.publishYear = publishYear;
		this.genre = genre;
	}

	public String getTitle() {
		return title;
	}

	public void setTitle(String title) {
		this.title = title;
	}

	public String getDirector() {
		return director;
	}

	public void setDirector(String director) {
		this.director = director;
	}

	public String getLeadActor() {
		return leadActor;
	}

	public void setLeadActor(String leadActor) {
		this.leadActor = leadActor;
	}

	public Integer getPublishYear() {
		return publishYear;
	}

	public void setPublishYear(Integer publishYear) {
		this.publishYear = publishYear;
	}

	public Genre getGenre() {
		return genre;
	}

	public void setGenre(Genre genre) {
		this.genre = genre;
	}

	@Override
	public String toString() {
		return "Movie [title=" + title + ", director=" + director + ", leadActor=" + leadActor + ", publishYear="
				+ publishYear + ", genre=" + genre + "]";
	}

	@Override
	public int compareTo(Movie o) {
		// Sort by director first
		if(!director.equals(o.getDirector()))
			return director.compareTo(o.getDirector());
		return leadActor.compareTo(o.getLeadActor()); // Sort by leadActor second (if directors are the same)
	}
}
