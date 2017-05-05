using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidgetDemo.Model
{
    public class Class1
    {
    }
}

public class TuniuDestinationModel
{
    public Mailclass[] MailClass { get; set; }
}

public class Mailclass
{
    public string MainClassName { get; set; }
    public Subclass[] SubClass { get; set; }
}

public class Subclass
{
    public string Name { get; set; }
    public string Value { get; set; }
}
