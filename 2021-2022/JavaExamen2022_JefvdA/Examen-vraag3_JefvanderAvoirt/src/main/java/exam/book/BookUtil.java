package exam.book;

import java.util.ArrayList;
import java.util.Collection;
import java.util.HashMap;
import java.util.Iterator;
import java.util.List;

public class BookUtil {
	private HashMap<String, Book> books;

	public BookUtil() {
		books = new HashMap<String, Book>();
	}

	public Collection<Book> getBooks() {
		return books.values();
	}

	public void addBookToStock(String bookId, String name, double price, int stockAmount) {
		if (bookId == null) {
			return;
		}
		if (books.containsKey(bookId)) {
			Book tmpBook = books.get(bookId);
			if (price > tmpBook.getPrice()) {
				tmpBook.setPrice(price);
			}
			tmpBook.setStockAmount(tmpBook.getStockAmount() + stockAmount);
			books.put(bookId, tmpBook);
		} else {
			books.put(bookId, new Book(bookId, name, price, stockAmount));
		}
	}

	public boolean sellBook(String bookId, int amount) throws OutOfStockException {
		if (!books.containsKey(bookId)) {
			return false;
		}
		Book stockBook = books.get(bookId);
		if (books.get(bookId).getStockAmount() < amount) {
			throw new OutOfStockException("No enough stock! Check id:" + bookId);
		}
		stockBook.setStockAmount(stockBook.getStockAmount() - amount);

		return true;
	}

	public Book getBookInfo(String bookId) {
		return books.get(bookId);
	}

	public List<String> getOutOfStockIds() {
		Iterator booksIterator = books.values().iterator();
		List<String> bookIds = new ArrayList<String>();
		while (booksIterator.hasNext()) {
			Book book = (Book) booksIterator.next();
			if (book.getStockAmount() == 0) {
				bookIds.add(book.getId());
			}
		}

		return bookIds;
	}
}
