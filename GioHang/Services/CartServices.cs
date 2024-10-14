using System.Collections.Generic;
namespace GioHang.Services
{
    public class CartServices
    {
        public List<string> Items { get; private set; } = new List<string>();

        public void AddItem(string item)
        {
            Items.Add(item);
        }

        public void RemoveItem(string item)
        {
            Items.Remove(item);
        }

        public void ClearCart()
        {
            Items.Clear();
        }

        public void UpdateItem(int index, string newItem)
        {
            if (index >= 0 && index < Items.Count)
            {
                Items[index] = newItem;
            }
        }
    }
}
