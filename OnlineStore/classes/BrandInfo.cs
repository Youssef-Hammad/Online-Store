using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.classes
{
    class BrandInfo
    {
        string b_name;
        string b_category;

        BrandInfo(string bName = null, string bCat = null)
        {
            b_name = bName;
            b_category = bCat;
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
