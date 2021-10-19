package AP.labo4.loops.oef2;

import org.apache.commons.lang3.StringUtils;

public class Main {
    public static void main(String[] args) {
        String string = "Dit is een string";
        System.out.println("LOOP: " + reverseStringLoop(string));
        System.out.println("Char Array: " + reverseStringCharArray(string));
        System.out.println("String Utils: " + reverseStringStringUtils(string));
        System.out.println("Recursion: " + reverseStringRecursion(string));
    }

    static String reverseStringLoop(String string){
        String reversedString = "";
        for (int i = string.length(); i > 0; i--){
            reversedString += string.charAt(i-1);
        }
        return reversedString;
    }

    static String reverseStringCharArray(String string){
        char[] reversedCharArray = new char[string.length()];

        for (int i = string.length()-1; i > -1; i--){
            reversedCharArray[string.length()-1 - i] = string.charAt(i);
        }

        return new String(reversedCharArray);
    }

    static String reverseStringStringUtils(String string){
        return StringUtils.reverse(string);
    }

    static String reverseStringRecursion(String string){
        if(string.length() == 1)
            return string;

        return string.charAt(string.length()-1) + reverseStringRecursion(string.substring(0, string.length()-1));
    }
}
