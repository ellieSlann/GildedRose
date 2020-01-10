namespace GildedRoseEllie.Models
{
    //todo put a wrapper around item class to get quality type or an extension methods.
    
    public interface IItem
    {
        string Name { get; set; }

        int SellIn { get; set; }

        int Quality { get; set; }

        string ItemType { get; set; }

        //void UpdateSellIn();

        // to do: sell in is duplicated across multilple item types
        void UpdateItem();

        void UpdateQuality();
    }
}
