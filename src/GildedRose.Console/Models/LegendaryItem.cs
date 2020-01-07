namespace GildedRoseEllie.Models
{
    public class LegendaryItem : CustomItem
    {
        //private Item _item;

        //public LegendaryItem(Item item) : base(item)
        //{
        //    _item = item;
        //}

        public new string Name {get; set; }

        public new int Quality => 80;
        public new int SellIn => int.MaxValue;

        public override string ItemType => "Legendary Item";

        public override void UpdateItem()
        {
        }
    }

}
