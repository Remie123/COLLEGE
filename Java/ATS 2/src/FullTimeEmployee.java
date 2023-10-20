public class FullTimeEmployee extends Employee {
    private double salary;
    private double bonus;

    public FullTimeEmployee(String nameSurname, String duties, double salary, double bonus) {
        super(nameSurname, duties);
        this.salary = salary;
        this.bonus = bonus;
    }

    public double getSalary() {
        return salary;
    }

    public void setSalary(double salary) {
        this.salary = salary;
    }

    public double getBonus() {
        return bonus;
    }

    public void setBonus(double bonus) {
        this.bonus = bonus;
    }

    @Override
    public double salaryCalculation() {
        return salary + bonus;
    }
}
