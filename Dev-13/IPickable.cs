using System;

namespace Dev_13
{
    /// <summary>
    /// Interface for picking a employee's team.
    /// </summary>
    interface IPickable
    {
        int[] PickATeam(int[] customerInfo);
    }
}
