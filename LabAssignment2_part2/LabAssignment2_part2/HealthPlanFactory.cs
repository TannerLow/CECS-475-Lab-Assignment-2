

namespace LabAssignment2_part2
{
    // Factory class for creating different health plan objects.
    class HealthPlanFactory
    {
        //IHealthPlan factory for creating concrete HealthPlans based on the given PlanType enum
        public static IHealthPlan GetHealthPlan(PlanType planType)
        {
            IHealthPlan plan = null;
            // Construct HMO, PPO, or ObamaCare Plan Type based on user input. 
            switch (planType)
            {
                case PlanType.HMO : 
                    plan = new HMO();
                    break;

                case PlanType.PPO:
                    plan = new PPO();
                    break;

                case PlanType.ObamaCare:
                    plan = new ObamaCare();
                    break;
            }

            return plan;
        }
    }
}
