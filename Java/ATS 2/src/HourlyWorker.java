public class HourlyWorker extends Employee {
    private double hourlyRate;
    private int hoursWorked;

    public HourlyWorker(String nameSurname, String duties, double hourlyRate, int hoursWorked) {
        super(nameSurname, duties);
        this.hourlyRate = hourlyRate;
        this.hoursWorked = hoursWorked;
    }

    public double getHourlyRate() {
        return hourlyRate;
    }

    public void setHourlyRate(double hourlyRate) {
        this.hourlyRate = hourlyRate;
    }

    public int getHoursWorked() {
        return hoursWorked;
    }

    public void setHoursWorked(int hoursWorked) {
        this.hoursWorked = hoursWorked;
    }

    @Override
    public double salaryCalculation() {
        return hourlyRate * hoursWorked;
    }
}
