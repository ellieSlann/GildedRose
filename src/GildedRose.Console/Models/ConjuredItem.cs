namespace GildedRoseEllie.Models
{
    public class ConjuredItem : IItem
    {
        //public override string ItemType => "Conjured Item";

        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }
        public string ItemType { get; set; }

        public void UpdateSellIn() => SellIn--;

        public void UpdateItem() => UpdateSellIn();

        public void UpdateQuality() => Quality = SellIn <= 0 ? Quality -= 4 : Quality -= 2;
    }

}
