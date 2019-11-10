namespace OnlineStore
{
    public enum STYPE { NA, sports, entertainment, clothes, technology };  // na for non applicable

    public class StoreInfo
    {
        private string s_name;
        private string s_location;
        private STYPE s_type;

        public StoreInfo()
        {
            s_name = string.Empty;
            s_location = string.Empty;
            s_type = STYPE.NA;
        }

        public void SetName(string sName)
        {
            s_name = sName;
        }
        public void SetLocation(string sLoc)
        {
            s_location = sLoc;
        }
        public void SetType(STYPE sType)
        {
            s_type = sType;
        }

        public string GetName()
        {
            return s_name;
        }
        public string GetLocaction()
        {
            return s_location;
        }
        public STYPE GetStoreType()
        {
            return s_type;
        }

    }
}
