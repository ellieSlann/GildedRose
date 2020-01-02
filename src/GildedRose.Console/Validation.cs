using GildedRoseEllie.Models;

namespace GildedRoseEllie
{
    public class Validation
    {
        public static bool ValidateQuality(CustomItem item)
        {
            if (item.Quality >= 0 && item.Quality <= 50) return true;
            return false;
        }
    }
}
