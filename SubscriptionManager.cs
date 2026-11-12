using System;
using System.Collections.Generic;

namespace kayesAhmed_Qutech
{
    public class SubscriptionManager
    {
        // Store all customer subscriptions
        private List<Subscription> subscriptions = new List<Subscription>();

        // METHOD 1: Display the main menu
        public void ShowMenu()
        {
            Console.WriteLine("==========================");
            Console.WriteLine("     Welcome to QuTech    ");
            Console.WriteLine("==========================");

            Console.WriteLine("Logged in as: Kayes Ahmed");
            Console.WriteLine("Role: Administrator");

            Console.WriteLine();

            Console.WriteLine("A. View Subscription Plans");
            Console.WriteLine("B. Create New Subscription");
            Console.WriteLine("C. View Subscription Summary");
            Console.WriteLine("D. Exit");

            Console.WriteLine();

            Console.Write("Please select an option: ");
        }

        // METHOD 2: Display subscription plans
        public void ShowPlans()
        {
            Console.WriteLine("====================================");
            Console.WriteLine("       QUTECH SUBSCRIPTION PLANS");
            Console.WriteLine("====================================");

            Console.WriteLine();

            Console.WriteLine("1. Startup       - $10.00 per user/month");
            Console.WriteLine("2. Standard      - $20.00 per user/month");
            Console.WriteLine("3. Premium       - $30.00 per user/month");
            Console.WriteLine("4. Enterprise    - $40.00 per user/month");

            Console.WriteLine();
        }

        // METHOD 3: Create a new subscription
        public void CreateSubscription()
        {
            Console.WriteLine("================================");
            Console.WriteLine("     CREATE NEW SUBSCRIPTION");
            Console.WriteLine("================================");

            Console.WriteLine();

            // STEP 1: Ask for business name
            Console.Write("Enter business name: ");

            string businessName = Console.ReadLine() ?? "";

            // Validate business name
            while (string.IsNullOrWhiteSpace(businessName))
            {
                Console.WriteLine("Business name cannot be empty!");

                Console.Write("Please enter business name again: ");

                businessName = Console.ReadLine() ?? "";
            }

            Console.WriteLine();

            // STEP 2: Display subscription plans
            ShowPlans();

            // STEP 3: Select a subscription plan
            int planNumber = 0;

            while (planNumber < 1 || planNumber > 4)
            {
                Console.Write("Enter plan number (1-4): ");

                if (!int.TryParse(Console.ReadLine(), out planNumber))
                {
                    Console.WriteLine("Please enter a valid number.");
                }
                else if (planNumber < 1 || planNumber > 4)
                {
                    Console.WriteLine("Please select a plan between 1 and 4.");
                }
            }

            // STEP 4: Determine plan name and price
            string planName = "";
            decimal planPrice = 0m;

            switch (planNumber)
            {
                case 1:
                    planName = "Startup";
                    planPrice = 10m;
                    break;

                case 2:
                    planName = "Standard";
                    planPrice = 20m;
                    break;

                case 3:
                    planName = "Premium";
                    planPrice = 30m;
                    break;

                case 4:
                    planName = "Enterprise";
                    planPrice = 40m;
                    break;
            }

            // STEP 5: Ask for number of users
            int numberOfUsers = 0;

            while (numberOfUsers < 1 || numberOfUsers > 100)
            {
                Console.Write("Enter number of users (1-100): ");

                if (!int.TryParse(Console.ReadLine(), out numberOfUsers))
                {
                    Console.WriteLine("Please enter a valid number.");
                }
                else if (numberOfUsers < 1 || numberOfUsers > 100)
                {
                    Console.WriteLine("Number of users must be between 1 and 100.");
                }
            }

            // STEP 6: Calculate monthly price
            decimal totalPrice = planPrice * numberOfUsers;

            // STEP 7: Ask for discount code
            Console.Write("Enter discount code: ");

            string discountCode = (Console.ReadLine() ?? "").Trim().ToUpper();

            // First three letters of Kayes Ahmed
            string studentName = "Kayes Ahmed";
            string correctDiscountCode =
                studentName.Trim().Substring(0, 3).ToUpperInvariant();

            // Check whether discount code matches
            bool hasDiscount = discountCode == correctDiscountCode;

            // Apply 15% discount
            if (hasDiscount)
            {
                totalPrice = totalPrice * 0.85m;

                Console.WriteLine("15% discount applied successfully!");
            }
            else
            {
                Console.WriteLine("No discount applied.");
            }

            // STEP 8: Create a new Subscription object
            Subscription newSubscription = new Subscription(
                businessName,
                planName,
                numberOfUsers,
                totalPrice,
                hasDiscount
            );

            // STEP 9: Save the subscription
            subscriptions.Add(newSubscription);

            // STEP 10: Display subscription details
            Console.WriteLine();

            Console.WriteLine("===== SUBSCRIPTION DETAILS =====");

            Console.WriteLine("Business: " + businessName);
            Console.WriteLine("Plan: " + planName);
            Console.WriteLine("Number of Users: " + numberOfUsers);
            Console.WriteLine("Price per User: $" + planPrice.ToString("F2"));
            Console.WriteLine("Discount Applied: " + (hasDiscount ? "Yes" : "No"));
            Console.WriteLine("Total Monthly Price: $" + totalPrice.ToString("F2"));

            Console.WriteLine();

            Console.WriteLine("Subscription saved successfully!");
        }

        // METHOD 4: Display subscription summary
        public void ShowSummary()
        {
            Console.WriteLine();

            Console.WriteLine("========== SUBSCRIPTION SUMMARY ==========");

            // Check whether any subscriptions exist
            if (subscriptions.Count == 0)
            {
                Console.WriteLine("No subscriptions have been created yet.");
                return;
            }

            // Display table headings
            Console.WriteLine(
                $"{"Business",-20} {"Plan",-12} {"Users",-7} {"Total",-12} {"Discount",-10}"
            );

            Console.WriteLine(new string('-', 70));

            // Display every saved subscription
            foreach (Subscription sub in subscriptions)
            {
                Console.WriteLine(
                    $"{sub.BusinessName,-20} " +
                    $"{sub.PlanName,-12} " +
                    $"{sub.NumberOfUsers,-7} " +
                    $"${sub.TotalPrice,-11:F2} " +
                    $"{(sub.HasDiscount ? "Yes" : "No"),-10}"
                );
            }

            Console.WriteLine();
        }

        // METHOD 5: Run the application
        public void Run()
        {
            string choice = "";

            while (choice != "D")
            {
                ShowMenu();

                choice = (Console.ReadLine() ?? "").Trim().ToUpper();

                switch (choice)
                {
                    case "A":
                        ShowPlans();
                        break;

                    case "B":
                        CreateSubscription();
                        break;

                    case "C":
                        ShowSummary();
                        break;

                    case "D":
                        Console.WriteLine("Thank you for using QuTech!");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}