using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Enums
{
    public enum TimeOfDay
    {
        SmallHours = 0, // 12am-6am
        Morning = 1, // 6am-12pm
        Afternoon = 2, // 12pm-6pm
        Night = 3 // 6pm-12am
    }
}
