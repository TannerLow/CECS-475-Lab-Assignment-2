

namespace LabAssignment2_part2
{
    //Concrete HealthPlan class HMO corresponding to PlanType.HMO
    class HMO : IHealthPlan
    {
        //private member variables
        private readonly double _annualCharge, _deductionAmount;
        private const PlanType _plan = PlanType.HMO;

        //Default constructor
        public HMO()
        {
            _annualCharge = 10000.00;
            _deductionAmount = 1200.00;
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
