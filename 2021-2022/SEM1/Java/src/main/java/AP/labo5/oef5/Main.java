package AP.labo5.oef5;

import java.util.ArrayList;

public class Main {
    public static void main(String[] args) {
        doFibonacci(5);
    }

    static int doFibonacci(int n){
        if(n <= 1)
            return n;

        return doFibonacci(n-1) + doFibonacci(n-2);
    }
}
