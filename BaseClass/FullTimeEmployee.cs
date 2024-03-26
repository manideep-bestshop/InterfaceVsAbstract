namespace BaseClass
{
    public class FullTimeEmployee:BaseEmployee
    {
        public int AnnualSalary { get; set; }

        public override int GetMonthlySalary()
        {
            return this.AnnualSalary / 12;
        }

    }
}
