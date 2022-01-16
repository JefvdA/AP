package AP.testing;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

public class CalculatorTests {

    @Test
    void addOneAndTwoIsThree() {
        Calculator calc = new Calculator();
        int result = calc.add(1, 2);
        assertEquals(3, result);
    }

    @Test
    void addOneAndFour(){
        Calculator calc = new Calculator();
        int result = calc.add(1, 4);
        assertEquals(5, result);
    }

    @Test
    void addThreeAndFive() {
        Calculator calc = new Calculator();
        int result = calc.add(3, 5);
        assertEquals(8, result);
    }

    @Test
    void resultFiveAddOneIsSix(){
        Calculator calc = new Calculator();
        calc.add(2, 3);
        int result = calc.addToResult(1);
        assertEquals(6, result);
    }

    @Test
    void resultFourAddOneIsFive() {
        Calculator calc = new Calculator();
        calc.add(3, 1);
        int result = calc.addToResult(1);
        assertEquals(5, result);
    }

    @Test
    void resultFourAddTwoIsSix(){
        Calculator calc = new Calculator();
        calc.add(3, 1);
        int result = calc.addToResult(2);
        assertEquals(6, result);
    }

    @Test
    void resultFourAddTwoAddOneIsSeven(){
        Calculator calc = new Calculator();
        calc.add(3, 1);
        calc.addToResult(2);
        int result = calc.addToResult(1);
        assertEquals(7, result);
    }

    @Test
    void noResultAddOneIsOne(){
        Calculator calc = new Calculator();
        int result = calc.addToResult(1);
        assertEquals(1, result);
    }
}
