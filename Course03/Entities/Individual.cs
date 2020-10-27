namespace Course03.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double anualIncome, double healthExpenditures) 
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (AnualIncome < 20000.00)
            {
                AnualIncome *= 0.15;
            }
            else
            {
                AnualIncome *= 0.25;
            }

            if (HealthExpenditures > 0.0)
            {
                HealthExpenditures *= 0.50;
            }

            return AnualIncome - HealthExpenditures;
        }
    }
}
