

namespace LabAssignment2_part2
{
    //HealthPlan interface to standardize concrete HealthPlans
    interface IHealthPlan
    {
        //Each HealthPlan must contain an annual charge, deduction amount, and plan type
        double AnnualCharge
        {
            get;
        }

        double DeductionAmount
        {
            get;
        }

        PlanType Plan
        {
            get;
        }
    }
}
