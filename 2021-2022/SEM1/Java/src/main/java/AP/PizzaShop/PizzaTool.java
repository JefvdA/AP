package AP.PizzaShop;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

/**
 * This class offers some tools for the PizzaShop Application
 * - pizzaData : List(List(String)) , in which we can find the data of all our pizza's and their ingredients
 *
 * @author JefvdA
 * @version 1.0.0
 * @since 15/11/2021
 */
public class PizzaTool {
    private static PizzaTool pizzaTool;

    private final static String COMMA_DELIMITER = ",";
    private final static String PIZZA_LIST_PATH = "C:/pizza-list.csv";


    private static List<List<String>> pizzaData;

    private PizzaTool() {
        // Try to read the file
        try {
            pizzaData = readCSV(PIZZA_LIST_PATH);
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    /**
     *
     * @param path This parameter specifies the path to the CSV file that needs to be read
     * @return List(List(String)), In which we can find the contents of the CSV file
     * @throws IOException On IO Error
     */
    private static List<List<String>> readCSV(String path) throws IOException{
        try(BufferedReader br = new BufferedReader(new FileReader(path))) {
            List<List<String>> result = new ArrayList<>();
            String line;
            while((line = br.readLine()) != null){
                String[] values = line.split(COMMA_DELIMITER);
                result.add(Arrays.asList(values));
            }
            return result;
        }
    }

    static PizzaTool getInstance(){
        if(null == pizzaTool)
            pizzaTool = new PizzaTool();
        return pizzaTool;
    }
}
