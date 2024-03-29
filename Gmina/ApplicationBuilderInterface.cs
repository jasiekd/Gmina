﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gmina
{
    public enum ApplicationType{
        Coal,Plus500,IDCard,Shielding,Non
    }
    public enum ApplicationStatus
    {
        Submitted,Accepted,Rejected,Improvement,Cancelled,Non
    }
    public interface ApplicationBuilderInterface
    {
        public ApplicationBuilderInterface setUserID(int id);
        public ApplicationBuilderInterface setApplicationID(int id);
        public ApplicationBuilderInterface setDatedOfApplication(DateTime date);
        public ApplicationBuilderInterface setStatus(ApplicationStatus status);
        public ApplicationBuilderInterface setApplicationType(ApplicationType type);
        public ApplicationBuilderInterface addApplicationElement(String name, String value);
        public Body.UserApplication getResult();
    }
}
