

namespace LabAssignment2_part2
{
    //Concrete HealthPlan class Obamacare corresponding to PlanType.ObamaCare
    class ObamaCare : IHealthPlan
    {
        //private member variables
        private readonly double _annualCharge, _deductionAmount;
        private const PlanType _plan = PlanType.ObamaCare;

        //Default constructor
        public ObamaCare()
        {
            _annualCharge = 15000.00;
            _deductionAmount = 2000.00;
        }

        //_annualCharge property, allows get
        public double AnnualCharge
        {
            get => _annualCharge;
        }

        //_deductionAmount property, allows get
        public double DeductionAmount
        {
            get => _deductionAmount;
        }

        //_plan property, allows get
        public PlanType Plan
        {
            get => _plan;
        }
    }
}
