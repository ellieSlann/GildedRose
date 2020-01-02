namespace GildedRoseEllie.Models
{
    public class CustomItem : Item//, IEnumerable<Item>, IEquatable<Item>
    {
        private Item _item;

        public CustomItem(Item item)
        {
            _item = item;
        }

        public new string Name
        {
            get { return _item.Name; }
        }
        public new int SellIn
        {
            get { return _item.SellIn; }
            set { _item.SellIn = value; }
        }
        public new int Quality
        {
            get { return _item.Quality; }
            set { _item.Quality = value; }
        }
        public virtual string ItemType { get; }

        public virtual void UpdateItem()
        {
            SellIn -= 1;
            if (SellIn <= 0) Quality -= 2;
            else Quality -= 1;
        }
    }

    //public class ItemWrapper
    //{
       

    //    public virtual void UpdateItem()
    //    {
    //        Quality -= 1;
    //        SellIn -= 1;
    //    }

    //}

}
