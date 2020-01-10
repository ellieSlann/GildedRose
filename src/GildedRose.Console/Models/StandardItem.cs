namespace GildedRoseEllie.Models
{
    public class StandardItem : IItem//, IEnumerable<Item>, IEquatable<Item>
    {
        public string Name { get; set; }
        public string ItemType { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        private void UpdateSellIn() => SellIn--;

        // to do: sell in is duplicated across multilple item types
        public void UpdateItem()
        {
            UpdateQuality();
            Quality = SellIn <= 0 ? Quality - 2 : Quality--;
        }

        public void UpdateQuality() => UpdateSellIn();
    }
}
