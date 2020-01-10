namespace GildedRoseEllie.Models
{
    public class BackstagePass : IItem
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }
        public string ItemType { get; set; }

        public void UpdateItem() {
            if (SellIn <= 0) Quality = 0;
            else if (SellIn <= 5) Quality += 3;
            else if (SellIn <= 10) Quality += 2;
            else Quality++;

            //Quality = SellIn <= 0 ? 0 : SellIn <= 5 ? 
            //    Quality += 3 : Quality <= 10 ?
            //    Quality += 2 : Quality++;
        }
        public void UpdateQuality() => UpdateSellIn();
        private void UpdateSellIn() => SellIn--;
    }

}
