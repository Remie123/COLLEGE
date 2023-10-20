public class Department {
    private String departmentName;
    private Employee[] employees;
    private int employeeCount;
    private Firm firm;

    public Department(String departmentName, int maxEmployees, Firm firm) { // nereikes konstruktoriu
        this.departmentName = departmentName;
        this.employees = new Employee[maxEmployees]; // turi 0
        this.employeeCount = 0;
        this.firm = firm;
    }

    public String getDepartmentName() {
        return departmentName;
    }

    public void setDepartmentName(String departmentName) {
        this.departmentName = departmentName;
    }

    public void addEmployee(Employee employee) {
        if (employeeCount < employees.length) { // vieta
            employees[employeeCount] = employee; // idet
            employee.setDepartment(this); //koks skyrius
            employeeCount++;
        } else {
            System.out.println("------------------------------------------------------------------------------");
            System.out.println("Negalima daugiau darbdaviu!");
            System.out.println("------------------------------------------------------------------------------");
        }
    }

    public Firm getFirm() {
        return firm;
    }

    public int getNumberOfEmployees() {
        return employeeCount;
    }

    public Employee findEmployee(String nameSurname) {
        for (Employee employee : employees) {
            if (employee != null && employee.getNameSurname().equals(nameSurname)) { // pati patikra , kartais uzsiglitchina.
                return employee;
            }
        }
        return null;
    }

    public Employee[] getEmployees() {
        return employees;
    }

    public void rikiavimoradimas() {
        for (int i = 0; i < employeeCount - 1; i++) {
            for (int j = 0; j < employeeCount - i - 1; j++) {
                if (employees[j].salaryCalculation() < employees[j + 1].salaryCalculation()) {
                    Employee temp = employees[j];
                    employees[j] = employees[j + 1];
                    employees[j + 1] = temp; // pasivogiau is andriaus [COMPARETO] figuros skaidrese reikes su SORT metodu.

                }
            }
        }
    }

    public void spausdinimas() {


        for (Department department : firm.getDepartments()) { // tikra
            if (department != null) { // dapart tikr
                System.out.println("Skyrius: " + department.getDepartmentName());
                for (Employee employee : department.getEmployees()) {
                    if (employee != null) { //  darb tikr
                        System.out.println(employee.getNameSurname() + " yra " + employee.getDuties() +
                                " ir uzdirba " + employee.salaryCalculation());
                    }
                }
                System.out.println("------------------------------------------------------------------------------");
            }

        }
    }
}
