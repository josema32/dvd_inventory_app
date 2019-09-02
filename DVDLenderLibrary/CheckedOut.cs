using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDLenderLibrary
{
    public class CheckedOut
    {
        public string LendedDVDTitle { get; set; }
        public string LendedDVDYear { get; set; }
        public string LendedDVDActorsActresses{ get; set; }
        public string BorrowerFirstName { get; set; }
        public string BorrowerLastName { get; set; }
        public string BorrowerEmail { get; set; }
        public string BorrowerPhone { get; set; }

        public string DisplayCheckedOut
        {
            get
            {
                return string.Format("{0} - {1} - {2} - {3} {4} - {5} - {6}", LendedDVDTitle, LendedDVDYear, LendedDVDActorsActresses, BorrowerFirstName, BorrowerLastName, BorrowerEmail, BorrowerPhone);
            }
        }
    }
}
