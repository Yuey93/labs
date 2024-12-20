namespace QAShopping
{
    public class ShoppingItem
    {
        public int _id { get; set; }
        public string _name { get; set; }
        public double _price { get; set; }
        public bool _vat { get; set; }

        public ShoppingItem(int id, string name, double price, bool vat)
        {
            _id = id;
            _name = name;
            _price = price;
            _vat = vat;
        }
    }
}
