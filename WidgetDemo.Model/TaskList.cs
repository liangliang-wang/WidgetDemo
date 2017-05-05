using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidgetDemo.Model
{

    public class Rootobject
    {
        public Tasklist[] taskList { get; set; }
    }

    public class Tasklist
    {
        public string description { get; set; }
        public string familyTree { get; set; }
        public int id { get; set; }
        public int parserId { get; set; }
        public string pattern { get; set; }
        public int priority { get; set; }
        public Request request { get; set; }
        public int requirementId { get; set; }
        public int status { get; set; }
    }

    public class Request
    {
        public string method { get; set; }
        public string url { get; set; }
    }

}
