package AP.labo5.oef3;

public class Main {
    public static void main(String[] args) {
        System.out.println(calculateDigitsRecursive(186513));
        System.out.println(calculateDigitsIterative(186513));
    }

    static int calculateDigitsIterative(int n){
        int digits = 1;
        while (n > 10){
            digits += 1;
            n /= 10;
        }
        return digits;
    }

    static int calculateDigitsRecursive(int n){
        if(n < 10)
            return 1;

        return 1 + calculateDigitsRecursive(n / 10);
    }
}
