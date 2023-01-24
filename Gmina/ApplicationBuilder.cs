using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gmina
{
    public class ApplicationBuilder : ApplicationBuilderInterface
    {
        List<String> elementName = new List<String>();
        List<String> elementValue = new List<String>();
        int applicationID = -1;
        ApplicationType applicationType = ApplicationType.Non;
        DateTime datedOfApplication = new DateTime(0);
        ApplicationStatus applicationStatus = ApplicationStatus.Non;
        int userID = -1;
        public ApplicationBuilderInterface addApplicationElement(string name, string value)
        {
            elementName.Add(name);
            elementValue.Add(value);
            return this;
        }

        public Body.UserApplication getResult()
        {
            return new Body.UserApplication(elementName,elementValue,applicationType,datedOfApplication,applicationStatus,userID,applicationID);
        }

        public ApplicationBuilderInterface setApplicationID(int id)
        {
            this.applicationID = id;
            return this;
        }

        public ApplicationBuilderInterface setApplicationType(ApplicationType type)
        {
            this.applicationType = type;
            return this;
        }

        public ApplicationBuilderInterface setDatedOfApplication(DateTime date)
        {
            this.datedOfApplication = date;
            return this;
        }

        public ApplicationBuilderInterface setStatus(ApplicationStatus status)
        {
            this.applicationStatus = status;
            return this;
        }

        public ApplicationBuilderInterface setUserID(int id)
        {
            this.userID = id;
            return this;
        }

    }
}
