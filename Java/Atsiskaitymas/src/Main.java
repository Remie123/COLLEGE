public class Main {
    public static void main(String[] args) {

        Firm firm = new Firm("Maxima");

        Department department1 = new Department("IT department", firm);
        Department department2 = new Department("Support department", firm);
        firm.addDepartment(department1);
        firm.addDepartment(department2);

        Employee employee1 = new Employee("Dziugas Apanavicius", "Programuotojas", 4000);
        Employee employee2 = new Employee("Jonas Makaronas", "Kasininkas", 1300);
        Employee employee3 = new Employee("Ausra Juodyte", "Vadove", 6000);
        Employee employee4 = new Employee("Mikolojus Maironis", "Kepejas", 1500);
        Employee employee5 = new Employee("Bananas Ananasas", "Vairuotojas", 1700);
        Employee employee6 = new Employee("Sabonis Maironis", "Krepsininkas", 17000);
        department1.addEmployee(employee1);
        department1.addEmployee(employee2);
        department1.addEmployee(employee6);
        department2.addEmployee(employee3);
        department2.addEmployee(employee4);
        department2.addEmployee(employee5);

        System.out.println("Maxima");
        System.out.println("--------------------------------------------------------");

        System.out.println("IT dapartamento darbuotojai");
        for (Employee employee : department1.getEmployees()) {
            System.out.println(employee.getNameSurname());
        }
        System.out.println("--------------------------------------------------------");

        System.out.println("Support dapartamento darbuotojai:");
        for (Employee employee : department2.getEmployees()) {
            System.out.println(employee.getNameSurname());
        }
        System.out.println("--------------------------------------------------------");

        Employee foundEmployee = firm.findEmployee("Ausra Juodyte");
        if (foundEmployee != null) {
            System.out.println("Darbuotojas/a = " + foundEmployee.getNameSurname());
            System.out.println("Jo/jos Departamentas = " + foundEmployee.getDepartment().getDepartmentName());
        } else {
            System.out.println("Ieskomas Darbuotojas neegzistuoja");
        }
    }
}