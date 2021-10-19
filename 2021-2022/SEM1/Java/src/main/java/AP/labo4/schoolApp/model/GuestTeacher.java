package AP.labo4.schoolApp.model;

public class GuestTeacher implements Teaching {
    private String name;
    private String firstName;

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getFirstName() {
        return firstName;
    }

    public void setFirstName(String firstName) {
        this.firstName = firstName;
    }

    public GuestTeacher(String name, String firstName) {
        this.name = name;
        this.firstName = firstName;
    }

    @Override
    public String toString() {
        return "GuestTeacher{" +
                "name='" + name + '\'' +
                ", firstName='" + firstName + '\'' +
                '}';
    }

    @Override
    public void teach(Learning learn) {
        System.out.println(name + " " + firstName + " is guest teaching");
        learn.learn();
    }
}
