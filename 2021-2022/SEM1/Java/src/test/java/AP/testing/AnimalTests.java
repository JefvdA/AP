package AP.testing;

import static org.junit.jupiter.api.Assertions.*;
import org.junit.jupiter.api.Test;

public class AnimalTests {
    @Test
    void createNewCat(){
        Animal cat = new Animal("Pluisje", AnimalType.CAT, "vdA");
        assertEquals("Pluisje", cat.getName());
    }

    @Test
    void changeOwner(){
        Animal cat = new Animal("Pluisje", AnimalType.CAT, "vdA");
        cat.changeOwner("Jan");

        assertNotEquals("vdA", cat.getOwner());
        assertEquals("Jan", cat.getOwner());
    }
}
