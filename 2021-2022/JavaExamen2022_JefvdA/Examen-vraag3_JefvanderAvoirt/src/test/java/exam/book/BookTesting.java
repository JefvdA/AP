package exam.book;

import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;

public class BookTesting {
    @Test
    void createBookUtilHasNoBooks(){
        BookUtil bookUtil = new BookUtil();

        assertEquals(bookUtil.getBooks().size(), 0);
    }

    @Test
    void addBookToStockAdds1Book(){
        BookUtil bookUtil = new BookUtil();

        bookUtil.addBookToStock("0", "Harry Potter", 12.09, 10);

        assertEquals(bookUtil.getBooks().size(), 1);
    }

    @Test
    void addBookToStockBookAlreadyExistsBookHasCorrectValues(){
        BookUtil bookUtil = new BookUtil();

        bookUtil.addBookToStock("0", "Harry Potter", 12.09, 10);
        bookUtil.addBookToStock("0", "Harry Potter", 13.09, 10);

        Book book = bookUtil.getBookInfo("0");

        assertEquals(book.getId(), "0");
        assertEquals(book.getName(), "Harry Potter");
        assertEquals(book.getPrice(), 13.09);
        assertEquals(book.getStockAmount(), 20);
    }

    @Test
    void stockTenSellOneStockNine() throws OutOfStockException {
        BookUtil bookUtil = new BookUtil();

        bookUtil.addBookToStock("0", "Harry Potter", 12.09, 10);

        bookUtil.sellBook("0", 1);

        assertEquals(bookUtil.getBookInfo("0").getStockAmount(), 9);
    }

    @Test
    void sellBookBookIdDoesntExistReturnsFalse() throws OutOfStockException {
        BookUtil bookUtil = new BookUtil();

        boolean result = bookUtil.sellBook("0", 1);

        assertFalse(result);
    }

    @Test
    void sellBookNotInStockThrowsOutOfStockException() throws OutOfStockException {
        BookUtil bookUtil = new BookUtil();

        bookUtil.addBookToStock("0", "Harry Potter", 12.09, 0);

        assertThrows(OutOfStockException.class, () -> bookUtil.sellBook("0", 1));
    }

    @Test
    void bookOutOfStockGetBookOutOfStockIds(){
        BookUtil bookUtil = new BookUtil();

        bookUtil.addBookToStock("0", "Harry Potter", 12.09, 0);

        assertTrue(bookUtil.getOutOfStockIds().contains("0"));
    }

    @Test
    void bookSetIdBookHasNewId(){
        Book book = new Book("0", "Harry Potter", 12.09, 10);

        book.setId("1");

        assertEquals(book.getId(), "1");
    }

    @Test
    void bookSetNameBookHasNewName(){
        Book book = new Book("0", "Harry Potter", 12.09, 10);

        book.setName("Harry Potter 2");

        assertEquals(book.getName(), "Harry Potter 2");
    }

    @Test
    void createTwoBooksSameIdBooksAreEqual(){
        Book book1 = new Book("0", "Harry Potter", 12.09, 10);
        Book book2 = new Book("0", "Harry Potter", 12.09, 10);

        assertTrue(book1.equals(book2));
    }

    @Test
    void createTwoBooksDifferentIdsBooksAreNotEqual(){
        Book book1 = new Book("0", "Harry Potter", 12.09, 10);
        Book book2 = new Book("1", "Harry Potter2", 12.09, 10);

        assertFalse(book1.equals(book2));
    }

    @Test
    void createBookBookToStringReturnsRightString(){
        Book book = new Book("0", "Harry Potter", 12.09, 10);

        assertEquals(book.toString(), "Book [id=" + book.getId() + ", name=" + book.getName() + ", price=" + book.getPrice() + ", stockAmount=" + book.getStockAmount() + "]");
    }
}
