

namespace LabAssignment2_part2
{
    //Concrete HealthPlan class PPO corresponding to PlanType.PPO
    class PPO : IHealthPlan
    {
        //private member variables
        private readonly double _annualCharge, _deductionAmount;
        private const PlanType _plan = PlanType.PPO;

        //Default constructor
        public PPO()
        {
            _annualCharge = 8000.00;
            _deductionAmount = 1350.00;
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
