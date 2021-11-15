package AP.labo5.oef6;

public class Main {
    public static void main(String[] args) {
        String string = "atyueo";
        System.out.println(amountOfConsonants(string));
    }

    static int amountOfConsonants(String string){
        if(string.length() == 0)
            return 0;

        String currentChar = string.substring(string.length()-1);

        int consonants = 0;
        if(!"aeiou".contains(currentChar))
            consonants = 1;
        return consonants + amountOfConsonants(string.substring(0, string.length()-1));
    }
}
