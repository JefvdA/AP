package AP.labo5.oef2;

public class Main {
    public static void main(String[] args) {
        countdown(10);
    }

    static void countdown(int i){
        if(i <= 0) {
            System.out.println("TAKE OFF! i = " + i);
            return;
        }

        countdown(i-1);
    }
}
