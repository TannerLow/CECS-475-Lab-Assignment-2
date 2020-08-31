using System;

namespace LabAssignment2_part2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create HealthPlan interface.
            IHealthPlan plan = null;

            // Prompt user to enter the desired health plan information.
            while (true)
            {
                Console.WriteLine("==Factory Demo==\nWhich plan would you like info on?\n" +
                "> HMO\n> PPO\n> ObamaCare\nType \"exit\" to quit program.\n");
                string input = Console.ReadLine();

                // Use factory pattern to create different health plan objects with similar attributes.
                // Plan creation is based on user input.
                switch (input)
                {
                    case "HMO":
                        plan = HealthPlanFactory.GetHealthPlan(PlanType.HMO);
                        break;

                    case "PPO":
                        plan = HealthPlanFactory.GetHealthPlan(PlanType.PPO);
                        break;

                    case "ObamaCare":
                        plan = HealthPlanFactory.GetHealthPlan(PlanType.ObamaCare);
                        break;

                    case "exit": 
                        return;

                    default:
                        Console.WriteLine("Invalid Input, try again\n");
                        break;
                }

                // Output plan information to console. 
                if(plan != null)
                {
                    Console.WriteLine("Current Plan:");
                    DisplayPlan(plan);
                }
            }
            
        }

        // Method that displays the various attributes of the selected plan.
        static void DisplayPlan(IHealthPlan plan)
        {
            Console.WriteLine("Annual    : " + plan.AnnualCharge);
            Console.WriteLine("Deduction: " + plan.DeductionAmount);
            Console.WriteLine("Plan      : " + plan.Plan + "\n");
        }
    }
}
