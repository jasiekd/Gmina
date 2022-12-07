using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gmina.Body
{
    internal class Application
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Submission_Date { get; set; }
        public string Status { get; set; }
        public string Action { get; set; }

        public Application()
        {

        }
    }
}
