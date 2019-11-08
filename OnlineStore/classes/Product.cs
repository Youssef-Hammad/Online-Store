namespace OnlineStore
{
    class Product
    {
        private ProductInfo p_info;

        public Product(ProductInfo pInfo)
        {
            p_info = pInfo;
        }

        public ProductInfo GetProductInfo()
        {
            return p_info;
        }

        public void SetProductInfo(ProductInfo pInfo)
        {
            p_info = pInfo;
        }
    }
}
