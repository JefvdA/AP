package AP.labo3.oef5;

import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

public class Controller {
    public static void main(String[] args) {
        List<String> names = new ArrayList<>();
        names.add ("Abu");
        names.add ("Bob");
        names.add ("Bea");
        System.out.print(names + "\n");
        for (String name : names){
            if(name == "Bob"){
                names.remove("Bob");
            }
        }
        System.out.print(names + "\n");
    }
}
