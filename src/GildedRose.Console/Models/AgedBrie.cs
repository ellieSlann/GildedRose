namespace GildedRoseEllie.Models
{
    public class AgedBrie : CustomItem
    {
        //private Item _item;
        
        //public AgedBrie(Item item) : base(item)
        //{
        //    _item = item;
        //}

        public override string ItemType => "Aged Brie";

        public override void UpdateItem()
        {
            SellIn -= 1;
            if (SellIn <= 0) Quality += 2;
            else Quality += 1;
        }
    }

}
