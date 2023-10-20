public class Main {
    public static void main(String[] args) {
        Firm firm = new Firm("Buvo Maxima Dabar Iki", 3);
;
        Department department1 = new Department("Crusty Crabs", 10, firm);
        Department department2 = new Department("Almond Milk", 10, firm);
        firm.addDepartment(department1);
        firm.addDepartment(department2);

        FullTimeEmployee employee1 = new FullTimeEmployee("Kempiniukas Placiakelnis", "Kepejas", 2000, 500);
        FullTimeEmployee employee2 = new FullTimeEmployee("Patrikas", "Akmens priziuretojas", 1800, 300);
        FullTimeEmployee employee3 = new FullTimeEmployee("Algimantas", "Daininikas", 4000, 200);
        FullTimeEmployee employee4 = new FullTimeEmployee("Petras", "Asfaltas", 8000, 200);
        HourlyWorker worker1 = new HourlyWorker("Garry", "Sraiges myletojas", 10, 40);
        HourlyWorker worker2 = new HourlyWorker("Kalmaras", "Muzikantas", 8, 50);
        HourlyWorker worker3 = new HourlyWorker("Bananas", "Begikas", 50, 50);
        HourlyWorker worker4 = new HourlyWorker("Obuolys", "Vaisius", 70, 50);

        firm.addFullTimeEmployees(department1, employee1, employee2,employee3, employee4);
        firm.addHourlyWorkers(department2, worker1, worker2, worker3, worker4);
        System.out.println("------------------------------------------------------------------------------");
        department1.spausdinimas();

        Employee foundEmployee = firm.findEmployee("Kempiniukas Placiakelnis");
        if (foundEmployee != null) {
            System.out.println("Rastas Darbuotojas = " + foundEmployee.getNameSurname());
            System.out.println("Jo Departamentas = " + foundEmployee.getDepartment().getDepartmentName());
            System.out.println("------------------------------------------------------------------------------");
        } else {
            System.out.println("Ieskomas Darbuotojas neegzistuoja");
            System.out.println("------------------------------------------------------------------------------");
        }

            firm.rikiavimas();

    }

}
