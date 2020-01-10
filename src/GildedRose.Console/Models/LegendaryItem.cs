namespace GildedRoseEllie.Models
{
    public class LegendaryItem : IItem
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }

        public string ItemType { get; set; }


        public void UpdateItem()
        {
            //do nothing deliberately
        }

        public void UpdateQuality()
        {
            //do nothing deliberately
        }
    }

}
