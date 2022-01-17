package exam.book;

public class OutOfStockException extends Exception {

	/**
	 * 
	 */
	private static final long serialVersionUID = 1370080503462332763L;
	
    public OutOfStockException(String message) {
        super(message);
    }
}
