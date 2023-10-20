import java.util.ArrayList;

public class Department {
    private String Pavadinimas;
    private ArrayList<Employee> employees = new ArrayList<>();
    private Firm firm;

    public Department(String departmentName, Firm firm) {
        this.Pavadinimas = departmentName;
        this.firm = firm;
    }
    public String getDepartmentName() {
        return Pavadinimas;
    }
    public ArrayList<Employee> getEmployees() {
        return employees;
    }

    public void addEmployee(Employee employee) {
        employees.add(employee);
        employee.setDepartment(this); // Nepanaudota dar.
    }

}