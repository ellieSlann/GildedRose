namespace GildedRoseEllie.Models
{
    public class BackstagePass : CustomItem
    {
        private Item _item;

        public BackstagePass(Item item) : base(item)
        {
            _item = item;
        }

        public override string ItemType => "Backstage Pass";

        public override void UpdateItem()
        {
            SellIn -= 1;
            if (SellIn <= 0) Quality = 0;
            else if (SellIn <= 5) Quality += 3;
            else if (SellIn <= 10) Quality += 2;
            else Quality += 1;
        }
    }

}
