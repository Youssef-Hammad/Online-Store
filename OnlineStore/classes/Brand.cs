namespace OnlineStore
{
    class Brand
    {
        BrandInfo b_info;

        public Brand(BrandInfo bInfo = null)
        {
            b_info = bInfo;
        }

        public void SetBrandInfo(BrandInfo bInfo)
        {
            b_info = bInfo;
        }

        public BrandInfo GetBrandInfo()
        {
            return b_info;
        }
    }
}
