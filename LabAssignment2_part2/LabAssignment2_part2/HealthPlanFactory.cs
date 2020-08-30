using System;
using System.Collections.Generic;
using System.Text;

namespace LabAssignment2_part2
{
    class HealthPlanFactory
    {
        public static HealthPlan getHealthPlan(PlanType planType)
        {
            HealthPlan plan = null;

            switch (planType)
            {
                case PlanType.HMO : 
                    plan = new HMO();
                    break;

                /*case PPO:
                    plan = new PPO();
                    break;

                case ObamaCare:
                    plan = new ObamaCare();
                    break;*/
            }

            return plan;
        }
    }
}
