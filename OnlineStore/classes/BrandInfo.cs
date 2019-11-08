namespace OnlineStore
{
    class BrandInfo
    {
        string b_name;
        string b_category;

        public BrandInfo()
        {
            b_name = string.Empty;
            b_category = string.Empty;
        }

        public void SetName(string bName)
        {
            b_name = bName;
        }

        public void SetCategory(string bCat)
        {
            b_category = bCat;
        }

        public string GetName()
        {
            return b_name;
        }

        public string GetCategory()
        {
            return b_category;
        }

    }
}
