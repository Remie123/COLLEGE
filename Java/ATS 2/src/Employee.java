public abstract class Employee {
    private String nameSurname;
    private String duties;
    private Department department;

    public Employee(String nameSurname, String duties) {
        this.nameSurname = nameSurname;
        this.duties = duties;
    }

    public String getNameSurname() {
        return nameSurname;
    }

    public void setNameSurname(String nameSurname) {
        this.nameSurname = nameSurname;
    }

    public String getDuties() {
        return duties;
    }

    public void setDuties(String duties) {
        this.duties = duties;
    }

    public abstract double salaryCalculation();

    public Department getDepartment() {
        return department;
    }

    public void setDepartment(Department department) {
        this.department = department;
    }
}
