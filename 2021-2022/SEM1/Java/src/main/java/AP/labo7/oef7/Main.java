package AP.labo7.oef7;

import AP.labo7.FileReader;

import java.util.List;

public class Main {
    public static void main(String[] args) {
        String path = "src/main/java/AP/labo7/four-letter-words.txt";

        List<String> wordList = FileReader.readTxt(path);
        wordList.stream().filter(w -> w.startsWith("A")).forEach(w -> System.out.println(w));
    }
}
