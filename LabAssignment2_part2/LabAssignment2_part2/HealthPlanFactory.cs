

namespace LabAssignment2_part2
{
    class HealthPlanFactory
    {
        //IHealthPlan factory for creating concrete HealthPlans based on the given PlanType enum
        public static IHealthPlan GetHealthPlan(PlanType planType)
        {
            IHealthPlan plan = null;

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
