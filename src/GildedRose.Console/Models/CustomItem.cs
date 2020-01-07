namespace GildedRoseEllie.Models
{
    public class CustomItem : Item//, IEnumerable<Item>, IEquatable<Item>
    {
        public virtual string ItemType { get; set; }

        public virtual void UpdateItem()
        {
            SellIn -= 1;
            if (SellIn <= 0) Quality -= 2;
            else Quality -= 1;
        }
    }
}
