package AP.labo5.oef1;

public class Main {
    public static void main(String[] args) {
        System.out.println(gcd(20, 10));
    }

    static int gcd(int a, int b){
        System.out.println("A: " + a + ", B: " + b);
        if(b == 0)
            return a;

        return gcd(b, a % b);
    }
}
