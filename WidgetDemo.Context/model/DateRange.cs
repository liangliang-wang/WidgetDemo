using System.Xml.Serialization;

namespace TC.InterVacation.OuterHotel.HotelInterface.GTAEntity
{
    [XmlType(AnonymousType = true)]
    public partial class DateRange
    {
        public string FromDate { get; set; }
        public string ToDate { get; set; }
    }
}