package AP.testing;

public class Calculator {
    private int memory;

    public int add(int a, int b) {
        memory = a + b;
        return memory;
    }

    public int addToResult(int a) {
        memory += a;
        return memory;
    }
}
