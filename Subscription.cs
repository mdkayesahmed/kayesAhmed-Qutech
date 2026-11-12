using System;
using System.Collections.Generic;
using System.Text;

namespace kayesAhmed_Qutech {
public class Subscription

    {
        // properies to store subscription information
        public string BusinessName { get; set; }
        public string PlanName { get; set; }

        public int NumberOfUsers { get; set; }

        public Decimal TotalPrice { get; set; }

        public bool HasDiscount { get; set; }

        // constructor 

        public Subscription(
            string businessName,
            string planName,
            int numberOfUsers,
            decimal totalPrice,
            bool hasDiscount)

        {
            BusinessName = businessName;
            PlanName = planName;
            NumberOfUsers = numberOfUsers;
            TotalPrice = totalPrice;
            HasDiscount = hasDiscount;
        }
    } }