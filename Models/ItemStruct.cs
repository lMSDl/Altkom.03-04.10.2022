
namespace Models
{
    public struct ItemStruct
    {
        public ItemStruct()
        {
            Name = default;
            quantity = default;
        }
        public ItemStruct(string name)
        {
            Name = name;
            quantity = 1;
        }

        private int quantity;

        public string Name { get;  set; }

        public int Quantity
        {
            get { 
                return quantity;
            }
            set
            {
                if(value > 0)
                    quantity = value;
            }
        }
    }
}