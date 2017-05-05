using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TC.InterVacation.OuterHotel.HotelInterface.GTAEntity;

namespace WidgetDemo.Context.model.response
{
    /// <remarks/>
    [XmlType(AnonymousType = true)]
    public partial class EssentialInformation
    {
        /// <remarks/>
        public string Text { get; set; }

        /// <remarks/>
        public DateRange DateRange { get; set; }
    }

}
