using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidgetDemo.Context.model.response
{

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Response
    {

        private ResponseResponseDetails responseDetailsField;

        private string responseReferenceField;

        private byte responseSequenceField;

        /// <remarks/>
        public ResponseResponseDetails ResponseDetails
        {
            get
            {
                return this.responseDetailsField;
            }
            set
            {
                this.responseDetailsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResponseReference
        {
            get
            {
                return this.responseReferenceField;
            }
            set
            {
                this.responseReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ResponseSequence
        {
            get
            {
                return this.responseSequenceField;
            }
            set
            {
                this.responseSequenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseResponseDetails
    {

        private ResponseResponseDetailsBookingResponse bookingResponseField;

        private string languageField;

        /// <remarks/>
        public ResponseResponseDetailsBookingResponse BookingResponse
        {
            get
            {
                return this.bookingResponseField;
            }
            set
            {
                this.bookingResponseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseResponseDetailsBookingResponse
    {

        private ResponseResponseDetailsBookingResponseBookingReference[] bookingReferencesField;

        private System.DateTime bookingCreationDateField;

        private System.DateTime bookingDepartureDateField;

        private string bookingNameField;

        private ResponseResponseDetailsBookingResponseBookingPrice bookingPriceField;

        private ResponseResponseDetailsBookingResponseBookingStatus bookingStatusField;

        private ResponseResponseDetailsBookingResponsePaxName[] paxNamesField;

        private ResponseResponseDetailsBookingResponseBookingItems bookingItemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("BookingReference", IsNullable = false)]
        public ResponseResponseDetailsBookingResponseBookingReference[] BookingReferences
        {
            get
            {
                return this.bookingReferencesField;
            }
            set
            {
                this.bookingReferencesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime BookingCreationDate
        {
            get
            {
                return this.bookingCreationDateField;
            }
            set
            {
                this.bookingCreationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime BookingDepartureDate
        {
            get
            {
                return this.bookingDepartureDateField;
            }
            set
            {
                this.bookingDepartureDateField = value;
            }
        }

        /// <remarks/>
        public string BookingName
        {
            get
            {
                return this.bookingNameField;
            }
            set
            {
                this.bookingNameField = value;
            }
        }

        /// <remarks/>
        public ResponseResponseDetailsBookingResponseBookingPrice BookingPrice
        {
            get
            {
                return this.bookingPriceField;
            }
            set
            {
                this.bookingPriceField = value;
            }
        }

        /// <remarks/>
        public ResponseResponseDetailsBookingResponseBookingStatus BookingStatus
        {
            get
            {
                return this.bookingStatusField;
            }
            set
            {
                this.bookingStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PaxName", IsNullable = false)]
        public ResponseResponseDetailsBookingResponsePaxName[] PaxNames
        {
            get
            {
                return this.paxNamesField;
            }
            set
            {
                this.paxNamesField = value;
            }
        }

        /// <remarks/>
        public ResponseResponseDetailsBookingResponseBookingItems BookingItems
        {
            get
            {
                return this.bookingItemsField;
            }
            set
            {
                this.bookingItemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseResponseDetailsBookingResponseBookingReference
    {

        private string referenceSourceField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReferenceSource
        {
            get
            {
                return this.referenceSourceField;
            }
            set
            {
                this.referenceSourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseResponseDetailsBookingResponseBookingPrice
    {

        private string currencyField;

        private decimal grossField;

        private decimal commissionField;

        private decimal nettField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Gross
        {
            get
            {
                return this.grossField;
            }
            set
            {
                this.grossField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Commission
        {
            get
            {
                return this.commissionField;
            }
            set
            {
                this.commissionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Nett
        {
            get
            {
                return this.nettField;
            }
            set
            {
                this.nettField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseResponseDetailsBookingResponseBookingStatus
    {

        private string codeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseResponseDetailsBookingResponsePaxName
    {

        private byte paxIdField;

        private string paxTypeField;

        private byte childAgeField;

        private bool childAgeFieldSpecified;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte PaxId
        {
            get
            {
                return this.paxIdField;
            }
            set
            {
                this.paxIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PaxType
        {
            get
            {
                return this.paxTypeField;
            }
            set
            {
                this.paxTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ChildAge
        {
            get
            {
                return this.childAgeField;
            }
            set
            {
                this.childAgeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ChildAgeSpecified
        {
            get
            {
                return this.childAgeFieldSpecified;
            }
            set
            {
                this.childAgeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseResponseDetailsBookingResponseBookingItems
    {

        private ResponseResponseDetailsBookingResponseBookingItemsBookingItem bookingItemField;

        /// <remarks/>
        public ResponseResponseDetailsBookingResponseBookingItemsBookingItem BookingItem
        {
            get
            {
                return this.bookingItemField;
            }
            set
            {
                this.bookingItemField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseResponseDetailsBookingResponseBookingItemsBookingItem
    {

        private byte itemReferenceField;

        private ResponseResponseDetailsBookingResponseBookingItemsBookingItemItemCity itemCityField;

        private ResponseResponseDetailsBookingResponseBookingItemsBookingItemItem itemField;

        private ResponseResponseDetailsBookingResponseBookingItemsBookingItemItemPrice itemPriceField;

        private ResponseResponseDetailsBookingResponseBookingItemsBookingItemOffer offerField;

        private ResponseResponseDetailsBookingResponseBookingItemsBookingItemItemStatus itemStatusField;

        private ResponseResponseDetailsBookingResponseBookingItemsBookingItemItemRemark[] itemRemarksField;

        private string itemPayableByField;

        private ResponseResponseDetailsBookingResponseBookingItemsBookingItemEssentialInformation essentialInformationField;

        private ResponseResponseDetailsBookingResponseBookingItemsBookingItemHotelItem hotelItemField;

        private string itemTypeField;

        /// <remarks/>
        public byte ItemReference
        {
            get
            {
                return this.itemReferenceField;
            }
            set
            {
                this.itemReferenceField = value;
            }
        }

        /// <remarks/>
        public ResponseResponseDetailsBookingResponseBookingItemsBookingItemItemCity ItemCity
        {
            get
            {
                return this.itemCityField;
            }
            set
            {
                this.itemCityField = value;
            }
        }

        /// <remarks/>
        public ResponseResponseDetailsBookingResponseBookingItemsBookingItemItem Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        public ResponseResponseDetailsBookingResponseBookingItemsBookingItemItemPrice ItemPrice
        {
            get
            {
                return this.itemPriceField;
            }
            set
            {
                this.itemPriceField = value;
            }
        }

        /// <remarks/>
        public ResponseResponseDetailsBookingResponseBookingItemsBookingItemOffer Offer
        {
            get
            {
                return this.offerField;
            }
            set
            {
                this.offerField = value;
            }
        }

        /// <remarks/>
        public ResponseResponseDetailsBookingResponseBookingItemsBookingItemItemStatus ItemStatus
        {
            get
            {
                return this.itemStatusField;
            }
            set
            {
                this.itemStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ItemRemark", IsNullable = false)]
        public ResponseResponseDetailsBookingResponseBookingItemsBookingItemItemRemark[] ItemRemarks
        {
            get
            {
                return this.itemRemarksField;
            }
            set
            {
                this.itemRemarksField = value;
            }
        }

        /// <remarks/>
        public string ItemPayableBy
        {
            get
            {
                return this.itemPayableByField;
            }
            set
            {
                this.itemPayableByField = value;
            }
        }

        /// <remarks/>
        public ResponseResponseDetailsBookingResponseBookingItemsBookingItemEssentialInformation EssentialInformation
        {
            get
            {
                return this.essentialInformationField;
            }
            set
            {
                this.essentialInformationField = value;
            }
        }

        /// <remarks/>
        public ResponseResponseDetailsBookingResponseBookingItemsBookingItemHotelItem HotelItem
        {
            get
            {
                return this.hotelItemField;
            }
            set
            {
                this.hotelItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ItemType
        {
            get
            {
                return this.itemTypeField;
            }
            set
            {
                this.itemTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseResponseDetailsBookingResponseBookingItemsBookingItemItemCity
    {

        private string codeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseResponseDetailsBookingResponseBookingItemsBookingItemItem
    {

        private string codeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseResponseDetailsBookingResponseBookingItemsBookingItemItemPrice
    {

        private decimal commissionField;

        private string currencyField;

        private decimal grossField;

        private decimal grossWithoutDiscountField;

        private decimal includeOfferDiscountField;

        private decimal nettField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Commission
        {
            get
            {
                return this.commissionField;
            }
            set
            {
                this.commissionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Gross
        {
            get
            {
                return this.grossField;
            }
            set
            {
                this.grossField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal GrossWithoutDiscount
        {
            get
            {
                return this.grossWithoutDiscountField;
            }
            set
            {
                this.grossWithoutDiscountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal IncludeOfferDiscount
        {
            get
            {
                return this.includeOfferDiscountField;
            }
            set
            {
                this.includeOfferDiscountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Nett
        {
            get
            {
                return this.nettField;
            }
            set
            {
                this.nettField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseResponseDetailsBookingResponseBookingItemsBookingItemOffer
    {

        private string codeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseResponseDetailsBookingResponseBookingItemsBookingItemItemStatus
    {

        private string codeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseResponseDetailsBookingResponseBookingItemsBookingItemItemRemark
    {

        private string codeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseResponseDetailsBookingResponseBookingItemsBookingItemEssentialInformation
    {

        private ResponseResponseDetailsBookingResponseBookingItemsBookingItemEssentialInformationInformation informationField;

        /// <remarks/>
        public ResponseResponseDetailsBookingResponseBookingItemsBookingItemEssentialInformationInformation Information
        {
            get
            {
                return this.informationField;
            }
            set
            {
                this.informationField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseResponseDetailsBookingResponseBookingItemsBookingItemEssentialInformationInformation
    {

        private string textField;

        private ResponseResponseDetailsBookingResponseBookingItemsBookingItemEssentialInformationInformationDateRange dateRangeField;

        /// <remarks/>
        public string Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        public ResponseResponseDetailsBookingResponseBookingItemsBookingItemEssentialInformationInformationDateRange DateRange
        {
            get
            {
                return this.dateRangeField;
            }
            set
            {
                this.dateRangeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseResponseDetailsBookingResponseBookingItemsBookingItemEssentialInformationInformationDateRange
    {

        private System.DateTime fromDateField;

        private System.DateTime toDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime FromDate
        {
            get
            {
                return this.fromDateField;
            }
            set
            {
                this.fromDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime ToDate
        {
            get
            {
                return this.toDateField;
            }
            set
            {
                this.toDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseResponseDetailsBookingResponseBookingItemsBookingItemHotelItem
    {

        private ResponseResponseDetailsBookingResponseBookingItemsBookingItemHotelItemPeriodOfStay periodOfStayField;

        private ResponseResponseDetailsBookingResponseBookingItemsBookingItemHotelItemHotelRooms hotelRoomsField;

        private ResponseResponseDetailsBookingResponseBookingItemsBookingItemHotelItemMeals mealsField;

        /// <remarks/>
        public ResponseResponseDetailsBookingResponseBookingItemsBookingItemHotelItemPeriodOfStay PeriodOfStay
        {
            get
            {
                return this.periodOfStayField;
            }
            set
            {
                this.periodOfStayField = value;
            }
        }

        /// <remarks/>
        public ResponseResponseDetailsBookingResponseBookingItemsBookingItemHotelItemHotelRooms HotelRooms
        {
            get
            {
                return this.hotelRoomsField;
            }
            set
            {
                this.hotelRoomsField = value;
            }
        }

        /// <remarks/>
        public ResponseResponseDetailsBookingResponseBookingItemsBookingItemHotelItemMeals Meals
        {
            get
            {
                return this.mealsField;
            }
            set
            {
                this.mealsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseResponseDetailsBookingResponseBookingItemsBookingItemHotelItemPeriodOfStay
    {

        private System.DateTime checkInDateField;

        private System.DateTime checkOutDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime CheckInDate
        {
            get
            {
                return this.checkInDateField;
            }
            set
            {
                this.checkInDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime CheckOutDate
        {
            get
            {
                return this.checkOutDateField;
            }
            set
            {
                this.checkOutDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseResponseDetailsBookingResponseBookingItemsBookingItemHotelItemHotelRooms
    {

        private ResponseResponseDetailsBookingResponseBookingItemsBookingItemHotelItemHotelRoomsHotelRoom hotelRoomField;

        /// <remarks/>
        public ResponseResponseDetailsBookingResponseBookingItemsBookingItemHotelItemHotelRoomsHotelRoom HotelRoom
        {
            get
            {
                return this.hotelRoomField;
            }
            set
            {
                this.hotelRoomField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseResponseDetailsBookingResponseBookingItemsBookingItemHotelItemHotelRoomsHotelRoom
    {

        private byte[] paxIdsField;

        private string codeField;

        private bool extraBedField;

        private bool sharingBeddingField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("PaxId", IsNullable = false)]
        public byte[] PaxIds
        {
            get
            {
                return this.paxIdsField;
            }
            set
            {
                this.paxIdsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ExtraBed
        {
            get
            {
                return this.extraBedField;
            }
            set
            {
                this.extraBedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SharingBedding
        {
            get
            {
                return this.sharingBeddingField;
            }
            set
            {
                this.sharingBeddingField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseResponseDetailsBookingResponseBookingItemsBookingItemHotelItemMeals
    {

        private ResponseResponseDetailsBookingResponseBookingItemsBookingItemHotelItemMealsBasis basisField;

        private ResponseResponseDetailsBookingResponseBookingItemsBookingItemHotelItemMealsBreakfast breakfastField;

        /// <remarks/>
        public ResponseResponseDetailsBookingResponseBookingItemsBookingItemHotelItemMealsBasis Basis
        {
            get
            {
                return this.basisField;
            }
            set
            {
                this.basisField = value;
            }
        }

        /// <remarks/>
        public ResponseResponseDetailsBookingResponseBookingItemsBookingItemHotelItemMealsBreakfast Breakfast
        {
            get
            {
                return this.breakfastField;
            }
            set
            {
                this.breakfastField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseResponseDetailsBookingResponseBookingItemsBookingItemHotelItemMealsBasis
    {

        private string codeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseResponseDetailsBookingResponseBookingItemsBookingItemHotelItemMealsBreakfast
    {

        private string codeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }


}
