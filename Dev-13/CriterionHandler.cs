using System;

namespace Dev_13
{
    enum CriterionType
    {
        MaxProductivity = 1,
        MinSum = 2,
        MaxJunior = 3
    }
    class CriterionHandler
    {
        public int CriterionNumb { get; set; }
        public CriterionHandler(int criterionNumb)
        {
            CriterionNumb = criterionNumb;
        }
        public IPickable PickTheCriterion()
        {
            switch ((CriterionType)CriterionNumb)
            {
                case CriterionType.MaxProductivity:
                    {
                        return new MaxProductivityPick();
                    }
                case CriterionType.MinSum:
                    {
                        return new MinSumPick();
                    }
                case CriterionType.MaxJunior:
                    {
                        return new MinHighQualifiedEmployeesPick();
                    }
                default:
                    {
                        throw new InvalidOperationException();
                    }
            }
        }
    }
}
