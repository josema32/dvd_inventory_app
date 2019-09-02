using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDLenderLibrary
{
    public class Inventory
    {
        public string dvdTitle { get; set; }
        public string dvdYear { get; set; }
        public string dvdActorsActresses { get; set; }

        public string DisplayInventory
        {
            get
            {
                return string.Format("{0} - {1} - {2}", dvdTitle, dvdYear, dvdActorsActresses);
            }
        }
    }
    
}
