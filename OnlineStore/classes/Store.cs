

namespace OnlineStore.classes
{
    class Store
    {
        private StoreInfo s_info;

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
