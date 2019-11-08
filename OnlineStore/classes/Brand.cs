using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.classes
{
    class Brand
    {
        BrandInfo b_info;

        Brand(BrandInfo bInfo = null)
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
