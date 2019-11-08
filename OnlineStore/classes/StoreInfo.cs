namespace OnlineStore
{
    enum STYPE { na = 0, sports, entertainment, clothes, technology };  // na for non applicable

    class StoreInfo
    {
        private string s_name;
        private string s_location;
        private STYPE s_type;

        StoreInfo(string sName = null, string sLoc = null, STYPE sType = 0)
        {
            s_name = sName;
            s_location = sLoc;
            s_type = sType;
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
        public STYPE GetType()
        {
            return s_type;
        }

    }
}
