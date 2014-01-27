using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DinnerParty
{
    class DinnerParty
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople;
        public decimal CostOfBeveragesPerPerson;
        public decimal CostOfDecorations = 0;


        public void SetHealthyOption(bool healthyOption)
        {
            if (healthyOption)
            {
                CostOfBeveragesPerPerson = 5.00M;
            }
            else
            {
                CostOfBeveragesPerPerson = 20.00M;
            }
        }


        public void CalculateCostOfDecorations(bool fancy)
        {
            if (fancy)
            {
                CostOfDecorations = (15.00M * NumberOfPeople) + 50.00M;
            }
            else
            {
                CostOfDecorations = (7.50M * NumberOfPeople) + 30.00M;
            }
        }




        public decimal CalculateCost(bool healthyOption)
        {

            decimal TotalCost = CostOfDecorations + (CostOfBeveragesPerPerson + CostOfFoodPerPerson) * NumberOfPeople;

            if (healthyOption)
            {
                return TotalCost * .95M;
            }
            else
            {

                return TotalCost;
            }


        }


    }
}
