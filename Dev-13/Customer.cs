using System;

namespace Dev_13
{
    /// <summary>
    /// Customer contains his requirements.
    /// </summary>
    class Customer
    {
        protected int moneySum;
        protected int requiredProductivity;
        public IPickable Pickable { private get; set; }
        public Customer(int[] customerInfo, IPickable pick)
        {
            moneySum = customerInfo[0];
            requiredProductivity = customerInfo[1];
            Pickable = pick;
        }
        /// <summary>
        /// Pick a Team
        /// </summary>
        /// <param name="customerInfo">Info from customer.</param>
        /// <returns>Int array consists amount of each employee.</returns>
        public int[] PickATeam(int[] customerInfo)
        {
            return Pickable.PickATeam(customerInfo);
        }
    }
}
