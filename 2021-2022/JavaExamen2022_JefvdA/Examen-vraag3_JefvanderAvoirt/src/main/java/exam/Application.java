package exam;

import exam.book.BookUtil;
import exam.book.OutOfStockException;

public class Application {
	public static void main(String[] args) {

		BookUtil bookUtil = new BookUtil();
		bookUtil.addBookToStock("Book1", "Best book1", 12.46d, 15);
		bookUtil.addBookToStock("Book2", "Best book2", 18.00d, 1);
		bookUtil.addBookToStock("Book3", "Best book3", 24.99d, 0);
		bookUtil.addBookToStock("Book4", "Best book4", 49.49d, 5);

		System.out.println("------ first list ------");
		bookUtil.getBooks().forEach(book -> System.out.println(book));
		System.out.println();

		bookUtil.addBookToStock("Book1", "Best book1", 12.75d, 5);
		bookUtil.addBookToStock("Book4", "Best book4", 00.00d, 3);

		System.out.println("----- After update -----");
		bookUtil.getBooks().forEach(book -> System.out.println(book));
		System.out.println();

		try {
			bookUtil.sellBook("Book4", 3);
			bookUtil.sellBook("Book4", 2);
			bookUtil.sellBook("Book2", 3);
		} catch (OutOfStockException e) {
			System.out.println(e.getMessage());
		}

		bookUtil.getBooks().forEach(book -> System.out.println(book));

		System.out.println("Items out of stock for:");
		bookUtil.getOutOfStockIds().forEach(id -> System.out.println(id + " "));
	}

}
