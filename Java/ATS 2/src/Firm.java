
public class Firm {

    private String firmName;
    private Department[] departments; // mas
    private int departmentCount;

    public Firm(String firmName, int maxDepartments) {
        this.firmName = firmName;
        this.departments = new Department[maxDepartments];
        this.departmentCount = 0; // ISTRINT
    }

    public String getFirmName() {
        return firmName;
    }

    public void setFirmName(String firmName) {
        this.firmName = firmName;
    }

    public void addDepartment(Department department) {
        if (departmentCount < departments.length) { // vieta
            departments[departmentCount] = department; // pridet
            departmentCount++; // padid ISTRINT
        } else {
            System.out.println("Negalima daugiau skyrių!");
        }
    }

    public Employee findEmployee(String nameSurname) {
        for (Department department : departments) {
            if (department != null) {
                Employee employee = department.findEmployee(nameSurname); // iesk skyr
                if (employee != null) {
                    return employee;
                }
            }
        }
        return null;
    }

    public void addFullTimeEmployees(Department department, FullTimeEmployee employee1, FullTimeEmployee employee2, FullTimeEmployee employee3, FullTimeEmployee employee4) {
        department.addEmployee(employee1);
        department.addEmployee(employee2);
        department.addEmployee(employee3);
        department.addEmployee(employee4);
    }


    public void addHourlyWorkers(Department department, HourlyWorker worker1, HourlyWorker worker2, HourlyWorker worker3, HourlyWorker worker4) {
        department.addEmployee(worker1);
        department.addEmployee(worker2);
        department.addEmployee(worker3);
        department.addEmployee(worker4);
    }

    public Department[] getDepartments() {
        return departments;
    }
    public void rikiavimas() {
        for (Department department : departments) {
           if (department != null) {
                department.rikiavimoradimas();
               System.out.println("Skyrius: " + department.getDepartmentName());
                for (Employee employee : department.getEmployees()) {
                   if (employee != null) {
                       System.out.println(employee.getNameSurname() + ": " + employee.salaryCalculation()); // pasivogiau is google
                  }
              }
               System.out.println("------------------------------------------------------------------------------");
            }
        }
   }
}

