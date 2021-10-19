package AP.labo4.schoolApp.model;

import java.util.Objects;

public abstract class Member implements Comparable<Member> {
    private String name;
    private String firstName;
    private int memberId;

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

    public int getMemberId() {
        return memberId;
    }

    public void setMemberId(int memberId) {
        this.memberId = memberId;
    }

    public Member() {
    }

    public Member(String name, String firstName, int memberId) {
        this.name = name;
        this.firstName = firstName;
        this.memberId = memberId;
    }

    @Override
    public String toString() {
        return "Member{" +
                "name='" + name + '\'' +
                ", firstName='" + firstName + '\'' +
                ", memberId=" + memberId +
                '}';
    }

    @Override
    public int compareTo(Member o) {
        return this.getName().compareTo(o.getName());
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Member member = (Member) o;
        return memberId == member.memberId && Objects.equals(name, member.name) && Objects.equals(firstName, member.firstName);
    }

    @Override
    public int hashCode() {
        return Objects.hash(name, firstName, memberId);
    }
}
