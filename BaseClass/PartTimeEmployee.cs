namespace BaseClass
{
    public class PartTimeEmployee:BaseEmployee
    {
        public int HourlyPay { get; set; }
        public int TotalHoursWorked { get; set; }

      
        public  override int GetMonthlySalary()
        {
             return this.HourlyPay * this.TotalHoursWorked;
        }
        
    }
}
