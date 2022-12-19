using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gmina.Body
{
    internal class UserApplication 
    {
        public List<String> elementName { get; set; }
        public List<String> elementValue { get; set; }

        public ApplicationType applicationType { get; set; }
        public DateTime datedOfApplication { get; set; }
        public ApplicationStstus applicationStstus { get; set; }
        public long userID { get; set; }
        public long applicationID { get; set; }

        public UserApplication(List<string> elementName, List<string> elementValue, ApplicationType applicationType, DateTime datedOfApplication, ApplicationStstus applicationStstus, long userID, long applicationID)
        {
            this.elementName = elementName;
            this.elementValue = elementValue;
            this.applicationType = applicationType;
            this.datedOfApplication = datedOfApplication;
            this.applicationStstus = applicationStstus;
            this.userID = userID;
            this.applicationID = applicationID; 
        }

    }
}
