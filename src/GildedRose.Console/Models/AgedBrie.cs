namespace GildedRoseEllie.Models
{
    public class AgedBrie : IItem
    {
        //public override string ItemType => "Aged Brie";

        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }
        public string ItemType { get; set; }

        private void UpdateSellIn() => SellIn--;

        public void UpdateItem() => UpdateSellIn();

        public void UpdateQuality() => Quality = SellIn <= 0 ? Quality += 2 : Quality += 1;
    }

}
