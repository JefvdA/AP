package AP.labo3.oef4;

import java.util.ArrayDeque;

public class ArrayLIFOQueue<T> implements LIFOQueue<T> {
    ArrayDeque<T> deQueue = new ArrayDeque<>();

    @Override
    public Boolean isEmpty() {
        if(deQueue.size() == 0) return true;

        return false;
    }

    @Override
    public void push(T item) {
        deQueue.addFirst(item);
    }

    @Override
    public T pop() {
        return deQueue.pollFirst();
    }

    @Override
    public T peek() {
        return deQueue.peekFirst();
    }
}
