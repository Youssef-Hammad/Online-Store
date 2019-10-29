

namespace OnlineStore
{
    class Store
    {
        private string s_StoreName;

        public void SetStoreName(string newName)
        {
            s_StoreName = newName;
        }

        public string GetStoreName()
        {
            return s_StoreName;
        }
    }
}
