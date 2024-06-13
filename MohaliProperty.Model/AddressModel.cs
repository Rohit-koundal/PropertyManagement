using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MohaliProperty.Model
{
    public class AddressModel
    {
        public string DeveloperOfficeAddress { get; set; }
        public string DeveloperOfficeLocation { get; set; }
        public string DeveloperOfficePinCode  {get;set;}
        public string DeveloperWebsiteUrl{ get; set; }
        public string DeveloperOfficeState { get; set; }
        public string DeveloperOfficeCity   { get; set; }
        public string WorkPhone { get; set; }
        public string EmailID    { get; set; }


    }
}
