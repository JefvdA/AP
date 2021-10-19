package AP.labo4.schoolApp.model;

public class Teacher extends Member implements Teaching {
    private Course course;

    public Course getCourse() {
        return course;
    }

    public void setCourse(Course course) {
        this.course = course;
    }

    public Teacher() {
    }

    public Teacher(String name, String firstName, int memberId, Course course) {
        super(name, firstName, memberId);
        this.course = course;
    }

    @Override
    public String toString() {
        return "Teacher{" +
                "course=" + course +
                "} " + super.toString();
    }

    @Override
    public void teach(Learning learn) {
        System.out.println(super.getName() + " " + super.getFirstName() + " is teaching");
        learn.learn();
    }
}
