using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gmina
{
    enum ApplicationType{
        Coal,Plus500,IDCard,Shielding,Non
    }
    enum ApplicationStstus
    {
        Submitted,Accepted,Rejected,Improvement,Canceled,Non
    }
    internal interface ApplicationBuilderInterface
    {
        public ApplicationBuilderInterface setUserID(long id);
        public ApplicationBuilderInterface setApplicationID(long id);
        public ApplicationBuilderInterface setDatedOfApplication(DateTime date);
        public ApplicationBuilderInterface setStatus(ApplicationStstus status);
        public ApplicationBuilderInterface setApplicationType(ApplicationType type);
        public ApplicationBuilderInterface addApplicationElement(String name, String value);
        public Body.UserApplication getResult();
    }
}
