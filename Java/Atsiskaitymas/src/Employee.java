public class Employee
// Get set isiraso nepamirsk.!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
{
    private String nameSurname;
    private String duties;
    private double salary;
    private Department department;

    public Employee(String nameSurname, String duties, double salary) {
        this.nameSurname = nameSurname;
        this.duties = duties;
        this.salary = salary;
    }

    public String getNameSurname() {
        return nameSurname;
    }

    public Department getDepartment() {
        return department;
    }

    public void setDepartment(Department department) {
        this.department = department;
    }
}