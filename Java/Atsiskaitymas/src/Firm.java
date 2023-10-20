import java.util.ArrayList;

public class Firm {
    private String firmospav;
    private ArrayList<Department> departments = new ArrayList<>();

    public Firm(String firmospav) {
        this.firmospav = firmospav;
    }

    public void addDepartment(Department department) {
        departments.add(department);
    }

    public Employee findEmployee(String nameSurname) {
        for (Department department : departments) {
            for (Employee employee : department.getEmployees()) {
                if (employee.getNameSurname().equals(nameSurname)) {
                    return employee;
                }
            }
        }
        return null;
    }
}