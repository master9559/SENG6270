using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// I know some of these need broken out into classes..
/// For instance PhotoTypeChoices should return a string of their 
/// name how we want it presented...  It was a quick way to get
/// rolling.
/// </summary>
namespace _6270PersonalAttempt
{
    public enum PhotoTypeChoices { fourbysix, fivebyseven, eightbyten };
    public enum DeliveryTypeChoices { oneHour, nextDay };
    public enum FinishTypeChoices { glossy, matte };
    public enum OrderType { standard, byPiece };
}
