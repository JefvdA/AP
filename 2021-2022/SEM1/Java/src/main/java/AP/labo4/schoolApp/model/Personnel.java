package AP.labo4.schoolApp.model;

public class Personnel extends Member {
    private String jobName;

    public String getJobName() {
        return jobName;
    }

    public void setJobName(String jobName) {
        this.jobName = jobName;
    }

    public Personnel() {
    }

    public Personnel(String name, String firstName, int memberId, String jobName) {
        super(name, firstName, memberId);
        this.jobName = jobName;
    }

    @Override
    public String toString() {
        return "Personnel{" +
                "jobName='" + jobName + '\'' +
                "} " + super.toString();
    }
}
