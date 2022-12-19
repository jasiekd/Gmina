using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gmina
{
    internal class ApplicationBuilder : ApplicationBuilderInterface
    {
        List<String> elementName = new List<String>();
        List<String> elementValue = new List<String>();
        long applicationID = -1;
        ApplicationType applicationType = ApplicationType.Non;
        DateTime datedOfApplication = new DateTime(0);
        ApplicationStstus applicationStstus = ApplicationStstus.Non;
        long userID = -1;

        public ApplicationBuilderInterface addApplicationElement(string name, string value)
        {
            elementName.Add(name);
            elementValue.Add(value);
            return this;
        }

        public Body.UserApplication getResult()
        {
            return new Body.UserApplication(elementName,elementValue,applicationType,datedOfApplication,applicationStstus,userID,applicationID);
        }

        public ApplicationBuilderInterface setApplicationID(long id)
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

        public ApplicationBuilderInterface setStatus(ApplicationStstus status)
        {
            this.applicationStstus = status;
            return this;
        }

        public ApplicationBuilderInterface setUserID(long id)
        {
            this.userID = id;
            return this;
        }

    }
}
