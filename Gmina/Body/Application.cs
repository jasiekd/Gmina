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
        public ApplicationStatus applicationStatus { get; set; }
        public int userID { get; set; }
        public int applicationID { get; set; }

        public UserApplication(List<string> elementName, List<string> elementValue, ApplicationType applicationType, DateTime datedOfApplication, ApplicationStatus applicationStstus, int userID, int applicationID)
        {
            this.elementName = elementName;
            this.elementValue = elementValue;
            this.applicationType = applicationType;
            this.datedOfApplication = datedOfApplication;
            this.applicationStatus = applicationStstus;
            this.userID = userID;
            this.applicationID = applicationID; 
        }

    }
}
