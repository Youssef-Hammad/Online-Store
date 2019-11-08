namespace OnlineStore
{
    class Store
    {
        private StoreInfo s_info;

        public Store(StoreInfo sInfo = null)
        {
            s_info = sInfo;
        }

        public void SetStoreInfo(StoreInfo sInfo)
        {
            s_info = sInfo;
        }

        public StoreInfo GetStoreInfo()
        {
            return s_info;
        }
    }
}
