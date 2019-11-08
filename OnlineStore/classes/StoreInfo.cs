using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.classes
{
    enum STYPE { sports, entertainment, clothes, technology };

    class StoreInfo
    {
        private String s_name;
        private String s_location;
        private STYPE s_type;

        public void SetName(String sName)
        {
            s_name = sName;
        }
        public void SetLocation(String sLoc)
        {
            s_location = sLoc;
        }
        public void SetType(STYPE sType)
        {
            s_type = sType;
        }

        public String GetName()
        {
            return s_name;
        }
        public String GetLocaction()
        {
            return s_location;
        }
        public STYPE GetType()
        {
            return s_type;
        }

    }
}
