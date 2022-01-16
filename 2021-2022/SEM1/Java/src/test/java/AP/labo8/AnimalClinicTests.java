package AP.labo8;

import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;

public class AnimalClinicTests {

    @Test
    void addOneAnimal(){
        AnimalClinic animalClinic = new AnimalClinic();
        int result = animalClinic.addAnimal(new Animal("Marie", AnimalType.DOG, "JefvdA"));

        // only 1 animal is in the clinic
        assertEquals(1, result);
    }

    @Test
    void addTwoDifferentAnimals(){
        AnimalClinic animalClinic = new AnimalClinic();
        animalClinic.addAnimal(new Animal("Marie", AnimalType.DOG, "JefvdA"));
        int result = animalClinic.addAnimal(new Animal("Simba", AnimalType.CAT, "JefvdA"));

        // 2 animals are in the clinic
        assertEquals(2, result);
    }

    @Test
    void addTwoSameAnimals(){
        AnimalClinic animalClinic = new AnimalClinic();
        animalClinic.addAnimal(new Animal("Marie", AnimalType.DOG, "JefvdA"));
        int result = animalClinic.addAnimal(new Animal("Marie", AnimalType.DOG, "JefvdA"));

        // only 1 animal is in the clinic
        assertEquals(1, result);
    }

    @Test
    void searchAnimal(){
        AnimalClinic animalClinic = new AnimalClinic();
        Animal animal = new Animal("Marie", AnimalType.DOG, "JefvdA");
        animalClinic.addAnimal(animal);
        Animal result = animalClinic.findAnimal("Marie", AnimalType.DOG);

        assertEquals(animal, result);
    }

    @Test
    void addTwoSearchOne(){
        AnimalClinic animalClinic = new AnimalClinic();
        Animal animal = new Animal("Marie", AnimalType.DOG, "JefvdA");
        animalClinic.addAnimal(animal);
        animalClinic.addAnimal(new Animal("Simba", AnimalType.CAT, "JefvdA"));
        Animal result = animalClinic.findAnimal("Marie", AnimalType.DOG);

        assertEquals(animal, result);
    }

    @Test
    void searchWrongAnimal(){
        AnimalClinic animalClinic = new AnimalClinic();
        animalClinic.addAnimal(new Animal("Marie", AnimalType.DOG, "JefvdA"));
        Animal result = animalClinic.findAnimal("Simba", AnimalType.CAT);

        assertNull(result);
    }

    @Test
    void addNoneCountIsZero(){
        AnimalClinic animalClinic = new AnimalClinic();

        assertEquals(0, animalClinic.countAnimals());
    }

    @Test
    void addThreeCountIsThree(){
        AnimalClinic animalClinic = new AnimalClinic();
        animalClinic.addAnimal(new Animal("Marie", AnimalType.DOG, "JefvdA"));
        animalClinic.addAnimal(new Animal("Simba", AnimalType.CAT, "JefvdA"));
        animalClinic.addAnimal(new Animal("Junior", AnimalType.DOG, "JefvdA"));

        assertEquals(3, animalClinic.countAnimals());
    }

    @Test
    void searchOnOwner(){
        AnimalClinic animalClinic = new AnimalClinic();
        Animal animal1 = new Animal("Marie", AnimalType.DOG, "JefvdA");
        Animal animal2 = new Animal("Simba", AnimalType.CAT, "JefvdA");
        Animal animal3 = new Animal("Junior", AnimalType.DOG, "FilipvdA");

        animalClinic.addAnimal(animal1);
        animalClinic.addAnimal(animal2);
        animalClinic.addAnimal(animal3);

        assertTrue(animalClinic.findAllAnimalsForOwner("JefvdA").contains(animal1));
        assertTrue(animalClinic.findAllAnimalsForOwner("JefvdA").contains(animal2));
        assertTrue(animalClinic.findAllAnimalsForOwner("FilipvdA").contains(animal3));
    }

    @Test
    void searchForUnknownOwner() {
        AnimalClinic animalClinic = new AnimalClinic();
        Animal animal = new Animal("Marie", AnimalType.DOG, "JefvdA");

        animalClinic.addAnimal(animal);

        assertFalse(animalClinic.findAllAnimalsForOwner("UNKNOWN_OWNER").contains(animal));
    }

    @Test
    void changeOwner(){
        AnimalClinic animalClinic = new AnimalClinic();
        Animal animal = new Animal("Marie", AnimalType.DOG, "JefvdA");

        animalClinic.addAnimal(animal);
        var result = animalClinic.changeAnimalOwner("Marie", AnimalType.DOG, "FilipvdA");

        assertTrue(result);
        assertEquals("FilipvdA", animalClinic.findAnimal("Marie", AnimalType.DOG).getOwner());
    }

    @Test
    void changeOwnerOfUnknownAnimal(){
        AnimalClinic animalClinic = new AnimalClinic();
        Animal animal = new Animal("Marie", AnimalType.DOG, "JefvdA");

        animalClinic.addAnimal(animal);
        var result = animalClinic.changeAnimalOwner("Kat", AnimalType.CAT, "JefvdA");

        assertFalse(result);
    }
}
