package exam;
import java.util.*;
import java.util.stream.Collectors;

public class Application {

	public static void main(String[] args) {

		List<Book> books = Arrays.asList(
//				new Book("De Kapellekensbaan","Louis Paul Boon",1953),
//				new Book("Het verdriet van België","Hugo Claus",1983),
//				new Book("De leeuw van Vlaanderen","Hendrik Conscience",1838),
//				new Book("Kaas","Willem Elsschot",1933),
//				new Book("Een revolverschot","Virginie Loveling",1911),
//				new Book("Dood van een non","Maria Rosseels",1961),
//				new Book("Meester Mitraillette","Jan Vantoortelboom",2014),
//				new Book("Oorlog en vrede","Lev Nikolajevitsj Tolstoj",1985),
//				new Book("Hersenschimmen","J. Bernlef",2009),
//				new Book("Verhalen","Isaak Babel",2013),
//				new Book("Publieke werken","Thomas Rosenboom",1999),
//				new Book("Max Havelaar","Multatuli",1899),
//				new Book("Dode zielen","Nikolaj Gogol",1900),
//				new Book("De avonden","Gerard Reve",1947),
//				new Book("Het stenen bruidsbed","Harry Mulisch",1900),
//				new Book("Een revolverschot","Bob Ross",1995),
//				new Book("De welwillenden","Jonathan Littell",2008),
//				new Book("De donkere kamer van Damokles","Willem Frederik Hermans",1994),
//				new Book("Dode zielen","Nikolaj Gogol",1900),
//				new Book("Honderd jaar eenzaamheid","Gabriel García Márquez",1900),
//				new Book("De goddelijke komedie","Dante Alighieri",2009),
//				new Book("De Kapellekensbaan","Louis Paul Boon",1953)
				new Book("De Kapellekensbaan","Louis Paul Boon",1953),
				new Book("De Kapellekensbaan","Louis Paul Boon",1953)
		);

		System.out.println("--------------------");
		System.out.println("Demo bookist 1P");
		System.out.println("--------------------");
		books.forEach(b -> System.out.println(b));
		System.out.println("");
		
		System.out.println("--------------------");
		System.out.println("Alfabetic bookist 1P");
		System.out.println("--------------------");
		getSortedBooks(books);
		System.out.println("");

		System.out.println("----------------");
		System.out.println("Books by Year 1P");
		System.out.println("----------------");
		sortBooksByYear(books);
		System.out.println("");

		System.out.println("------------------------");
		System.out.println("Bookist no duplicated 1P");
		System.out.println("------------------------");
		removeDuplicates(books);
		System.out.println("");
		
		System.out.println("----------------------");
		System.out.println("Bookist before year 1P");
		System.out.println("----------------------");
		getBooksbefore(books);
	}

	// 1P
	// Pas de Book klasse aan zodat die standaard sorteerd op het veld title.
	// Sorteer de lijst print naar de console.
	private static void getSortedBooks(List<Book> books) {
		
		// Code vf nhj
		Collections.sort(books);
		books.forEach(System.out::println);
		
	}
	// 1P
	// Maak gebruik van een collectie die boeken altijd sorteerd op het veld year.
	// Print de items in deze collectie naar de console.
	private static void sortBooksByYear(List<Book> books) {

		//Code
		TreeSet<Book> orderedBooks = new TreeSet<>(new SortByYear());
		orderedBooks.addAll(books);
		orderedBooks.forEach(System.out::println);
		
	}


	// 1P
	// Streams & Lambdas
	// Zorg er voor dat de items uit books in een collectie zonder duplicaten komen.
	// Print het resultaat naar de console.
	private static void removeDuplicates(List<Book> books) {
		
		//Code
		HashSet<Book> noDuplicateBooks = new HashSet<>(books);
		noDuplicateBooks.forEach(System.out::println);
		
	}

	// 1P
	// Streams & Lambdas
	// Maak een collectie met alle boektitels van boeken voor 1950.
	// Print deze lijst naar de console.
	private static  void getBooksbefore(List<Book> books) {

		//Code
		List<Book> booksBefore1950 = books.stream().filter(book -> book.getReleaseYear() < 1950).collect(Collectors.toList());
		booksBefore1950.forEach(System.out::println);
		
	}
}
