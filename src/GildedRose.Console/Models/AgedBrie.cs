namespace GildedRoseEllie.Models
{
    public class AgedBrie : CustomItem
    {
        private Item _item;
        
        public AgedBrie(Item item) : base(item)
        {
            _item = item;
        }

        public override string ItemType => "Aged Brie";

        public override void UpdateItem()
        {
            _item.SellIn -= 1;
            if (_item.SellIn <= 0) _item.Quality += 2;
            else _item.Quality += 1;
        }
    }

}
