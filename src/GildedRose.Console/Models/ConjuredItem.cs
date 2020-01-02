namespace GildedRoseEllie.Models
{
    public class ConjuredItem : CustomItem
    {
        private Item _item;

        public ConjuredItem(Item item) : base(item)
        {
            _item = item;
        }

        public override string ItemType => "Conjured Item";

        public override void UpdateItem()
        {
            SellIn -= 1;
            if (SellIn <= 0) Quality -= 4;
            else Quality -= 2;
        }
    }

}
