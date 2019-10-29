namespace OnlineStore
{
    class ProductInfo
    {
        private string p_name;
        private float p_price;
        private string p_category;

        public string GetName()
        {
            return p_name;
        }
        public float GetPrice()
        {
            return p_price;
        }
        public string GetCategory()
        {
            return p_category;
        }
        public bool SetName(string name)
        {
            p_name = name;
            return true;
        }
        public bool SetPrice(float price)
        {
            p_price = price;
            return true;
        }
        public bool SetCategory(string category)
        {
            p_category = category;
            return true;
        }
    }
}
