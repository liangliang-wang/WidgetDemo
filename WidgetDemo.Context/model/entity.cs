
/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class Request
{
    /// <remarks/>
    public RequestSource Source{get; set;}

    /// <remarks/>
    public RequestRequestDetails RequestDetails{get; set; }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestSource
{

    private RequestSourceRequestorID requestorIDField;

    private RequestSourceRequestorPreferences requestorPreferencesField;

    /// <remarks/>
    public RequestSourceRequestorID RequestorID
    {
        get;
        set;
    }

    /// <remarks/>
    public RequestSourceRequestorPreferences RequestorPreferences
    {
        get;
        set;
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestSourceRequestorID
{

    private ushort clientField;

    private string eMailAddressField;

    private string passwordField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort Client
    {
        get
        {
            return this.clientField;
        }
        set
        {
            this.clientField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string EMailAddress
    {
        get
        {
            return this.eMailAddressField;
        }
        set
        {
            this.eMailAddressField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Password
    {
        get
        {
            return this.passwordField;
        }
        set
        {
            this.passwordField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestSourceRequestorPreferences
{

    private string requestModeField;

    private string responseURLField;

    private string languageField;

    private string currencyField;

    /// <remarks/>
    public string RequestMode
    {
        get
        {
            return this.requestModeField;
        }
        set
        {
            this.requestModeField = value;
        }
    }

    /// <remarks/>
    public string ResponseURL
    {
        get
        {
            return this.responseURLField;
        }
        set
        {
            this.responseURLField = value;
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
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetails
{

    private RequestRequestDetailsAddBookingRequest addBookingRequestField;

    private RequestRequestDetailsModifyBookingRequest modifyBookingRequestField;

    private RequestRequestDetailsCancelBookingRequest cancelBookingRequestField;

    private RequestRequestDetailsSearchBookingRequest searchBookingRequestField;

    private RequestRequestDetailsAddBookingItemRequest addBookingItemRequestField;

    private object modifyBookingItemRequestField;

    private object cancelBookingItemRequestField;

    private object searchBookingItemRequestField;

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequest AddBookingRequest
    {
        get
        {
            return this.addBookingRequestField;
        }
        set
        {
            this.addBookingRequestField = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsModifyBookingRequest ModifyBookingRequest
    {
        get
        {
            return this.modifyBookingRequestField;
        }
        set
        {
            this.modifyBookingRequestField = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsCancelBookingRequest CancelBookingRequest
    {
        get
        {
            return this.cancelBookingRequestField;
        }
        set
        {
            this.cancelBookingRequestField = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsSearchBookingRequest SearchBookingRequest
    {
        get
        {
            return this.searchBookingRequestField;
        }
        set
        {
            this.searchBookingRequestField = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsAddBookingItemRequest AddBookingItemRequest
    {
        get
        {
            return this.addBookingItemRequestField;
        }
        set
        {
            this.addBookingItemRequestField = value;
        }
    }

    /// <remarks/>
    public object ModifyBookingItemRequest
    {
        get
        {
            return this.modifyBookingItemRequestField;
        }
        set
        {
            this.modifyBookingItemRequestField = value;
        }
    }

    /// <remarks/>
    public object CancelBookingItemRequest
    {
        get
        {
            return this.cancelBookingItemRequestField;
        }
        set
        {
            this.cancelBookingItemRequestField = value;
        }
    }

    /// <remarks/>
    public object SearchBookingItemRequest
    {
        get
        {
            return this.searchBookingItemRequestField;
        }
        set
        {
            this.searchBookingItemRequestField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequest
{

    private string bookingNameField;

    private string bookingReferenceField;

    private string agentReferenceField;

    private System.DateTime bookingDepartureDateField;

    private string passengerEmailField;

    private RequestRequestDetailsAddBookingRequestPaxName[] paxNamesField;

    private RequestRequestDetailsAddBookingRequestBookingItem[] bookingItemsField;

    private string currencyField;

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
    public string BookingReference
    {
        get
        {
            return this.bookingReferenceField;
        }
        set
        {
            this.bookingReferenceField = value;
        }
    }

    /// <remarks/>
    public string AgentReference
    {
        get
        {
            return this.agentReferenceField;
        }
        set
        {
            this.agentReferenceField = value;
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
    public string PassengerEmail
    {
        get
        {
            return this.passengerEmailField;
        }
        set
        {
            this.passengerEmailField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("PaxName", IsNullable = false)]
    public RequestRequestDetailsAddBookingRequestPaxName[] PaxNames
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
    [System.Xml.Serialization.XmlArrayItemAttribute("BookingItem", IsNullable = false)]
    public RequestRequestDetailsAddBookingRequestBookingItem[] BookingItems
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
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestPaxName
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
public partial class RequestRequestDetailsAddBookingRequestBookingItem
{

    private byte itemReferenceField;

    private RequestRequestDetailsAddBookingRequestBookingItemItemCity itemCityField;

    private RequestRequestDetailsAddBookingRequestBookingItemItem itemField;

    private RequestRequestDetailsAddBookingRequestBookingItemTransferItem transferItemField;

    private RequestRequestDetailsAddBookingRequestBookingItemSightseeingItem sightseeingItemField;

    private RequestRequestDetailsAddBookingRequestBookingItemItemRemarks itemRemarksField;

    private RequestRequestDetailsAddBookingRequestBookingItemHotelItem hotelItemField;

    private string itemTypeField;

    private decimal expectedPriceField;

    private bool expectedPriceFieldSpecified;

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
    public RequestRequestDetailsAddBookingRequestBookingItemItemCity ItemCity
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
    public RequestRequestDetailsAddBookingRequestBookingItemItem Item
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
    public RequestRequestDetailsAddBookingRequestBookingItemTransferItem TransferItem
    {
        get
        {
            return this.transferItemField;
        }
        set
        {
            this.transferItemField = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemSightseeingItem SightseeingItem
    {
        get
        {
            return this.sightseeingItemField;
        }
        set
        {
            this.sightseeingItemField = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemItemRemarks ItemRemarks
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
    public RequestRequestDetailsAddBookingRequestBookingItemHotelItem HotelItem
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

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal ExpectedPrice
    {
        get
        {
            return this.expectedPriceField;
        }
        set
        {
            this.expectedPriceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ExpectedPriceSpecified
    {
        get
        {
            return this.expectedPriceFieldSpecified;
        }
        set
        {
            this.expectedPriceFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemItemCity
{

    private string codeField;

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
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemItem
{

    private string codeField;

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
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemTransferItem
{

    private RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetails pickUpDetailsField;

    private RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetails dropOffDetailsField;

    private System.DateTime transferDateField;

    private string transferLanguageField;

    private RequestRequestDetailsAddBookingRequestBookingItemTransferItemTransferVehicle transferVehicleField;

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetails PickUpDetails
    {
        get
        {
            return this.pickUpDetailsField;
        }
        set
        {
            this.pickUpDetailsField = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetails DropOffDetails
    {
        get
        {
            return this.dropOffDetailsField;
        }
        set
        {
            this.dropOffDetailsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime TransferDate
    {
        get
        {
            return this.transferDateField;
        }
        set
        {
            this.transferDateField = value;
        }
    }

    /// <remarks/>
    public string TransferLanguage
    {
        get
        {
            return this.transferLanguageField;
        }
        set
        {
            this.transferLanguageField = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemTransferItemTransferVehicle TransferVehicle
    {
        get
        {
            return this.transferVehicleField;
        }
        set
        {
            this.transferVehicleField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetails
{

    private RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsCity cityField;

    private RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpAccommodation pickUpAccommodationField;

    private RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpAirport pickUpAirportField;

    private RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpStation pickUpStationField;

    private RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpPort pickUpPortField;

    private RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpOther pickUpOtherField;

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsCity City
    {
        get
        {
            return this.cityField;
        }
        set
        {
            this.cityField = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpAccommodation PickUpAccommodation
    {
        get
        {
            return this.pickUpAccommodationField;
        }
        set
        {
            this.pickUpAccommodationField = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpAirport PickUpAirport
    {
        get
        {
            return this.pickUpAirportField;
        }
        set
        {
            this.pickUpAirportField = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpStation PickUpStation
    {
        get
        {
            return this.pickUpStationField;
        }
        set
        {
            this.pickUpStationField = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpPort PickUpPort
    {
        get
        {
            return this.pickUpPortField;
        }
        set
        {
            this.pickUpPortField = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpOther PickUpOther
    {
        get
        {
            return this.pickUpOtherField;
        }
        set
        {
            this.pickUpOtherField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsCity
{

    private string codeField;

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
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpAccommodation
{

    private object pickUpFromField;

    private RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpAccommodationHotel hotelField;

    private RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpAccommodationApartment apartmentField;

    private RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpAccommodationAddress addressField;

    private RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpAccommodationMeetingpoint meetingpointField;

    /// <remarks/>
    public object PickUpFrom
    {
        get
        {
            return this.pickUpFromField;
        }
        set
        {
            this.pickUpFromField = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpAccommodationHotel Hotel
    {
        get
        {
            return this.hotelField;
        }
        set
        {
            this.hotelField = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpAccommodationApartment Apartment
    {
        get
        {
            return this.apartmentField;
        }
        set
        {
            this.apartmentField = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpAccommodationAddress Address
    {
        get
        {
            return this.addressField;
        }
        set
        {
            this.addressField = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpAccommodationMeetingpoint Meetingpoint
    {
        get
        {
            return this.meetingpointField;
        }
        set
        {
            this.meetingpointField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpAccommodationHotel
{

    private string codeField;

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
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpAccommodationApartment
{

    private string codeField;

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
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpAccommodationAddress
{

    private object addressLine1Field;

    private object addressLine2Field;

    private RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpAccommodationAddressCity cityField;

    private object countyField;

    private object postCodeField;

    private object telephoneField;

    /// <remarks/>
    public object AddressLine1
    {
        get
        {
            return this.addressLine1Field;
        }
        set
        {
            this.addressLine1Field = value;
        }
    }

    /// <remarks/>
    public object AddressLine2
    {
        get
        {
            return this.addressLine2Field;
        }
        set
        {
            this.addressLine2Field = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpAccommodationAddressCity City
    {
        get
        {
            return this.cityField;
        }
        set
        {
            this.cityField = value;
        }
    }

    /// <remarks/>
    public object County
    {
        get
        {
            return this.countyField;
        }
        set
        {
            this.countyField = value;
        }
    }

    /// <remarks/>
    public object PostCode
    {
        get
        {
            return this.postCodeField;
        }
        set
        {
            this.postCodeField = value;
        }
    }

    /// <remarks/>
    public object Telephone
    {
        get
        {
            return this.telephoneField;
        }
        set
        {
            this.telephoneField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpAccommodationAddressCity
{

    private string codeField;

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
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpAccommodationMeetingpoint
{

    private string codeField;

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
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpAirport
{

    private RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpAirportArrivingFrom arrivingFromField;

    private string flightNumberField;

    private decimal estimatedArrivalField;

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpAirportArrivingFrom ArrivingFrom
    {
        get
        {
            return this.arrivingFromField;
        }
        set
        {
            this.arrivingFromField = value;
        }
    }

    /// <remarks/>
    public string FlightNumber
    {
        get
        {
            return this.flightNumberField;
        }
        set
        {
            this.flightNumberField = value;
        }
    }

    /// <remarks/>
    public decimal EstimatedArrival
    {
        get
        {
            return this.estimatedArrivalField;
        }
        set
        {
            this.estimatedArrivalField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpAirportArrivingFrom
{

    private RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpAirportArrivingFromAirport airportField;

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpAirportArrivingFromAirport Airport
    {
        get
        {
            return this.airportField;
        }
        set
        {
            this.airportField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpAirportArrivingFromAirport
{

    private string codeField;

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
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpStation
{

    private RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpStationStation stationField;

    private object arrivingFromField;

    private RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpStationCity cityField;

    private object trainNameField;

    private object estimateArrivalField;

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpStationStation Station
    {
        get
        {
            return this.stationField;
        }
        set
        {
            this.stationField = value;
        }
    }

    /// <remarks/>
    public object ArrivingFrom
    {
        get
        {
            return this.arrivingFromField;
        }
        set
        {
            this.arrivingFromField = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpStationCity City
    {
        get
        {
            return this.cityField;
        }
        set
        {
            this.cityField = value;
        }
    }

    /// <remarks/>
    public object TrainName
    {
        get
        {
            return this.trainNameField;
        }
        set
        {
            this.trainNameField = value;
        }
    }

    /// <remarks/>
    public object EstimateArrival
    {
        get
        {
            return this.estimateArrivalField;
        }
        set
        {
            this.estimateArrivalField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpStationStation
{

    private string codeField;

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
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpStationCity
{

    private string codeField;

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
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpPort
{

    private object arrivingFromField;

    private object shipNameField;

    private object shippingCompanyField;

    private object estimateArrivalField;

    /// <remarks/>
    public object ArrivingFrom
    {
        get
        {
            return this.arrivingFromField;
        }
        set
        {
            this.arrivingFromField = value;
        }
    }

    /// <remarks/>
    public object ShipName
    {
        get
        {
            return this.shipNameField;
        }
        set
        {
            this.shipNameField = value;
        }
    }

    /// <remarks/>
    public object ShippingCompany
    {
        get
        {
            return this.shippingCompanyField;
        }
        set
        {
            this.shippingCompanyField = value;
        }
    }

    /// <remarks/>
    public object EstimateArrival
    {
        get
        {
            return this.estimateArrivalField;
        }
        set
        {
            this.estimateArrivalField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpOther
{

    private object pickUpFromField;

    private RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpOtherHotel hotelField;

    private RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpOtherApartment apartmentField;

    private RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpOtherAddress addressField;

    private RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpOtherMeetingpoint meetingpointField;

    /// <remarks/>
    public object PickUpFrom
    {
        get
        {
            return this.pickUpFromField;
        }
        set
        {
            this.pickUpFromField = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpOtherHotel Hotel
    {
        get
        {
            return this.hotelField;
        }
        set
        {
            this.hotelField = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpOtherApartment Apartment
    {
        get
        {
            return this.apartmentField;
        }
        set
        {
            this.apartmentField = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpOtherAddress Address
    {
        get
        {
            return this.addressField;
        }
        set
        {
            this.addressField = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpOtherMeetingpoint Meetingpoint
    {
        get
        {
            return this.meetingpointField;
        }
        set
        {
            this.meetingpointField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpOtherHotel
{

    private string codeField;

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
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpOtherApartment
{

    private string codeField;

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
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpOtherAddress
{

    private object addressLine1Field;

    private object addressLine2Field;

    private RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpOtherAddressCity cityField;

    private object countyField;

    private object postCodeField;

    private object telephoneField;

    /// <remarks/>
    public object AddressLine1
    {
        get
        {
            return this.addressLine1Field;
        }
        set
        {
            this.addressLine1Field = value;
        }
    }

    /// <remarks/>
    public object AddressLine2
    {
        get
        {
            return this.addressLine2Field;
        }
        set
        {
            this.addressLine2Field = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpOtherAddressCity City
    {
        get
        {
            return this.cityField;
        }
        set
        {
            this.cityField = value;
        }
    }

    /// <remarks/>
    public object County
    {
        get
        {
            return this.countyField;
        }
        set
        {
            this.countyField = value;
        }
    }

    /// <remarks/>
    public object PostCode
    {
        get
        {
            return this.postCodeField;
        }
        set
        {
            this.postCodeField = value;
        }
    }

    /// <remarks/>
    public object Telephone
    {
        get
        {
            return this.telephoneField;
        }
        set
        {
            this.telephoneField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpOtherAddressCity
{

    private string codeField;

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
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemTransferItemPickUpDetailsPickUpOtherMeetingpoint
{

    private string codeField;

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
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetails
{

    private RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsCity cityField;

    private RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsDropOffAccommodation dropOffAccommodationField;

    private RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsDropOffAirport dropOffAirportField;

    private RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsDropOffStation dropOffStationField;

    private RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsDropOffPort dropOffPortField;

    private RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsPickUpOther pickUpOtherField;

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsCity City
    {
        get
        {
            return this.cityField;
        }
        set
        {
            this.cityField = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsDropOffAccommodation DropOffAccommodation
    {
        get
        {
            return this.dropOffAccommodationField;
        }
        set
        {
            this.dropOffAccommodationField = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsDropOffAirport DropOffAirport
    {
        get
        {
            return this.dropOffAirportField;
        }
        set
        {
            this.dropOffAirportField = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsDropOffStation DropOffStation
    {
        get
        {
            return this.dropOffStationField;
        }
        set
        {
            this.dropOffStationField = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsDropOffPort DropOffPort
    {
        get
        {
            return this.dropOffPortField;
        }
        set
        {
            this.dropOffPortField = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsPickUpOther PickUpOther
    {
        get
        {
            return this.pickUpOtherField;
        }
        set
        {
            this.pickUpOtherField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsCity
{

    private string codeField;

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
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsDropOffAccommodation
{

    private object dropOffToField;

    private RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsDropOffAccommodationHotel hotelField;

    private RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsDropOffAccommodationApartment apartmentField;

    private RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsDropOffAccommodationAddress addressField;

    private RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsDropOffAccommodationMeetingpoint meetingpointField;

    /// <remarks/>
    public object DropOffTo
    {
        get
        {
            return this.dropOffToField;
        }
        set
        {
            this.dropOffToField = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsDropOffAccommodationHotel Hotel
    {
        get
        {
            return this.hotelField;
        }
        set
        {
            this.hotelField = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsDropOffAccommodationApartment Apartment
    {
        get
        {
            return this.apartmentField;
        }
        set
        {
            this.apartmentField = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsDropOffAccommodationAddress Address
    {
        get
        {
            return this.addressField;
        }
        set
        {
            this.addressField = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsDropOffAccommodationMeetingpoint Meetingpoint
    {
        get
        {
            return this.meetingpointField;
        }
        set
        {
            this.meetingpointField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsDropOffAccommodationHotel
{

    private string codeField;

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
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsDropOffAccommodationApartment
{

    private string codeField;

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
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsDropOffAccommodationAddress
{

    private object addressLine1Field;

    private object addressLine2Field;

    private RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsDropOffAccommodationAddressCity cityField;

    private object countyField;

    private object postCodeField;

    private object telephoneField;

    /// <remarks/>
    public object AddressLine1
    {
        get
        {
            return this.addressLine1Field;
        }
        set
        {
            this.addressLine1Field = value;
        }
    }

    /// <remarks/>
    public object AddressLine2
    {
        get
        {
            return this.addressLine2Field;
        }
        set
        {
            this.addressLine2Field = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsDropOffAccommodationAddressCity City
    {
        get
        {
            return this.cityField;
        }
        set
        {
            this.cityField = value;
        }
    }

    /// <remarks/>
    public object County
    {
        get
        {
            return this.countyField;
        }
        set
        {
            this.countyField = value;
        }
    }

    /// <remarks/>
    public object PostCode
    {
        get
        {
            return this.postCodeField;
        }
        set
        {
            this.postCodeField = value;
        }
    }

    /// <remarks/>
    public object Telephone
    {
        get
        {
            return this.telephoneField;
        }
        set
        {
            this.telephoneField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsDropOffAccommodationAddressCity
{

    private string codeField;

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
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsDropOffAccommodationMeetingpoint
{

    private string codeField;

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
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsDropOffAirport
{

    private object departingToField;

    private RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsDropOffAirportAirport airportField;

    private string flightNumberField;

    private decimal departureTimeField;

    /// <remarks/>
    public object DepartingTo
    {
        get
        {
            return this.departingToField;
        }
        set
        {
            this.departingToField = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsDropOffAirportAirport Airport
    {
        get
        {
            return this.airportField;
        }
        set
        {
            this.airportField = value;
        }
    }

    /// <remarks/>
    public string FlightNumber
    {
        get
        {
            return this.flightNumberField;
        }
        set
        {
            this.flightNumberField = value;
        }
    }

    /// <remarks/>
    public decimal DepartureTime
    {
        get
        {
            return this.departureTimeField;
        }
        set
        {
            this.departureTimeField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsDropOffAirportAirport
{

    private string codeField;

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
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsDropOffStation
{

    private RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsDropOffStationStation stationField;

    private object departingToField;

    private RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsDropOffStationCity cityField;

    private object trainNameField;

    private object departureTimeField;

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsDropOffStationStation Station
    {
        get
        {
            return this.stationField;
        }
        set
        {
            this.stationField = value;
        }
    }

    /// <remarks/>
    public object DepartingTo
    {
        get
        {
            return this.departingToField;
        }
        set
        {
            this.departingToField = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsDropOffStationCity City
    {
        get
        {
            return this.cityField;
        }
        set
        {
            this.cityField = value;
        }
    }

    /// <remarks/>
    public object TrainName
    {
        get
        {
            return this.trainNameField;
        }
        set
        {
            this.trainNameField = value;
        }
    }

    /// <remarks/>
    public object DepartureTime
    {
        get
        {
            return this.departureTimeField;
        }
        set
        {
            this.departureTimeField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsDropOffStationStation
{

    private string codeField;

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
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsDropOffStationCity
{

    private string codeField;

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
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsDropOffPort
{

    private object departingToField;

    private object shipNameField;

    private object shippingCompanyField;

    private object departureTimeField;

    /// <remarks/>
    public object DepartingTo
    {
        get
        {
            return this.departingToField;
        }
        set
        {
            this.departingToField = value;
        }
    }

    /// <remarks/>
    public object ShipName
    {
        get
        {
            return this.shipNameField;
        }
        set
        {
            this.shipNameField = value;
        }
    }

    /// <remarks/>
    public object ShippingCompany
    {
        get
        {
            return this.shippingCompanyField;
        }
        set
        {
            this.shippingCompanyField = value;
        }
    }

    /// <remarks/>
    public object DepartureTime
    {
        get
        {
            return this.departureTimeField;
        }
        set
        {
            this.departureTimeField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsPickUpOther
{

    private object dropOffToField;

    private RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsPickUpOtherHotel hotelField;

    private RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsPickUpOtherApartment apartmentField;

    private RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsPickUpOtherAddress addressField;

    private RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsPickUpOtherMeetingpoint meetingpointField;

    /// <remarks/>
    public object DropOffTo
    {
        get
        {
            return this.dropOffToField;
        }
        set
        {
            this.dropOffToField = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsPickUpOtherHotel Hotel
    {
        get
        {
            return this.hotelField;
        }
        set
        {
            this.hotelField = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsPickUpOtherApartment Apartment
    {
        get
        {
            return this.apartmentField;
        }
        set
        {
            this.apartmentField = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsPickUpOtherAddress Address
    {
        get
        {
            return this.addressField;
        }
        set
        {
            this.addressField = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsPickUpOtherMeetingpoint Meetingpoint
    {
        get
        {
            return this.meetingpointField;
        }
        set
        {
            this.meetingpointField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsPickUpOtherHotel
{

    private string codeField;

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
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsPickUpOtherApartment
{

    private string codeField;

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
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsPickUpOtherAddress
{

    private object addressLine1Field;

    private object addressLine2Field;

    private RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsPickUpOtherAddressCity cityField;

    private object countyField;

    private object postCodeField;

    private object telephoneField;

    /// <remarks/>
    public object AddressLine1
    {
        get
        {
            return this.addressLine1Field;
        }
        set
        {
            this.addressLine1Field = value;
        }
    }

    /// <remarks/>
    public object AddressLine2
    {
        get
        {
            return this.addressLine2Field;
        }
        set
        {
            this.addressLine2Field = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsPickUpOtherAddressCity City
    {
        get
        {
            return this.cityField;
        }
        set
        {
            this.cityField = value;
        }
    }

    /// <remarks/>
    public object County
    {
        get
        {
            return this.countyField;
        }
        set
        {
            this.countyField = value;
        }
    }

    /// <remarks/>
    public object PostCode
    {
        get
        {
            return this.postCodeField;
        }
        set
        {
            this.postCodeField = value;
        }
    }

    /// <remarks/>
    public object Telephone
    {
        get
        {
            return this.telephoneField;
        }
        set
        {
            this.telephoneField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsPickUpOtherAddressCity
{

    private string codeField;

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
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemTransferItemDropOffDetailsPickUpOtherMeetingpoint
{

    private string codeField;

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
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemTransferItemTransferVehicle
{

    private RequestRequestDetailsAddBookingRequestBookingItemTransferItemTransferVehicleVehicle vehicleField;

    private byte passengersField;

    private byte leadPaxIdField;

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemTransferItemTransferVehicleVehicle Vehicle
    {
        get
        {
            return this.vehicleField;
        }
        set
        {
            this.vehicleField = value;
        }
    }

    /// <remarks/>
    public byte Passengers
    {
        get
        {
            return this.passengersField;
        }
        set
        {
            this.passengersField = value;
        }
    }

    /// <remarks/>
    public byte LeadPaxId
    {
        get
        {
            return this.leadPaxIdField;
        }
        set
        {
            this.leadPaxIdField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemTransferItemTransferVehicleVehicle
{

    private string codeField;

    private byte maximumPassengersField;

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
    public byte MaximumPassengers
    {
        get
        {
            return this.maximumPassengersField;
        }
        set
        {
            this.maximumPassengersField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemSightseeingItem
{

    private System.DateTime tourDateField;

    private RequestRequestDetailsAddBookingRequestBookingItemSightseeingItemTourLanguage tourLanguageField;

    private RequestRequestDetailsAddBookingRequestBookingItemSightseeingItemSpecialItem specialItemField;

    private byte[] paxIdsField;

    private RequestRequestDetailsAddBookingRequestBookingItemSightseeingItemTourDeparture tourDepartureField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime TourDate
    {
        get
        {
            return this.tourDateField;
        }
        set
        {
            this.tourDateField = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemSightseeingItemTourLanguage TourLanguage
    {
        get
        {
            return this.tourLanguageField;
        }
        set
        {
            this.tourLanguageField = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemSightseeingItemSpecialItem SpecialItem
    {
        get
        {
            return this.specialItemField;
        }
        set
        {
            this.specialItemField = value;
        }
    }

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
    public RequestRequestDetailsAddBookingRequestBookingItemSightseeingItemTourDeparture TourDeparture
    {
        get
        {
            return this.tourDepartureField;
        }
        set
        {
            this.tourDepartureField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemSightseeingItemTourLanguage
{

    private string codeField;

    private string languageListCodeField;

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
    public string LanguageListCode
    {
        get
        {
            return this.languageListCodeField;
        }
        set
        {
            this.languageListCodeField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemSightseeingItemSpecialItem
{

    private string codeField;

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
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemSightseeingItemTourDeparture
{

    private decimal timeField;

    private RequestRequestDetailsAddBookingRequestBookingItemSightseeingItemTourDepartureDeparturePoint departurePointField;

    private string descriptionField;

    private string[] addressLinesField;

    /// <remarks/>
    public decimal Time
    {
        get
        {
            return this.timeField;
        }
        set
        {
            this.timeField = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemSightseeingItemTourDepartureDeparturePoint DeparturePoint
    {
        get
        {
            return this.departurePointField;
        }
        set
        {
            this.departurePointField = value;
        }
    }

    /// <remarks/>
    public string Description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("AddressLine", IsNullable = false)]
    public string[] AddressLines
    {
        get
        {
            return this.addressLinesField;
        }
        set
        {
            this.addressLinesField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemSightseeingItemTourDepartureDeparturePoint
{

    private string codeField;

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
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemItemRemarks
{

    private RequestRequestDetailsAddBookingRequestBookingItemItemRemarksItemRemark itemRemarkField;

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemItemRemarksItemRemark ItemRemark
    {
        get
        {
            return this.itemRemarkField;
        }
        set
        {
            this.itemRemarkField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemItemRemarksItemRemark
{

    private string codeField;

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
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemHotelItem
{

    private bool alternativesAllowedField;

    private RequestRequestDetailsAddBookingRequestBookingItemHotelItemPeriodOfStay periodOfStayField;

    private RequestRequestDetailsAddBookingRequestBookingItemHotelItemHotelRooms hotelRoomsField;

    private RequestRequestDetailsAddBookingRequestBookingItemHotelItemHotelPaxRoom hotelPaxRoomField;

    /// <remarks/>
    public bool AlternativesAllowed
    {
        get
        {
            return this.alternativesAllowedField;
        }
        set
        {
            this.alternativesAllowedField = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemHotelItemPeriodOfStay PeriodOfStay
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
    public RequestRequestDetailsAddBookingRequestBookingItemHotelItemHotelRooms HotelRooms
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
    public RequestRequestDetailsAddBookingRequestBookingItemHotelItemHotelPaxRoom HotelPaxRoom
    {
        get
        {
            return this.hotelPaxRoomField;
        }
        set
        {
            this.hotelPaxRoomField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemHotelItemPeriodOfStay
{

    private System.DateTime checkInDateField;

    private System.DateTime checkOutDateField;

    private byte durationField;

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

    /// <remarks/>
    public byte Duration
    {
        get
        {
            return this.durationField;
        }
        set
        {
            this.durationField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemHotelItemHotelRooms
{

    private RequestRequestDetailsAddBookingRequestBookingItemHotelItemHotelRoomsHotelRoom hotelRoomField;

    /// <remarks/>
    public RequestRequestDetailsAddBookingRequestBookingItemHotelItemHotelRoomsHotelRoom HotelRoom
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
public partial class RequestRequestDetailsAddBookingRequestBookingItemHotelItemHotelRoomsHotelRoom
{

    private string descriptionField;

    private byte[] paxIdsField;

    private string codeField;

    private string idField;

    private bool extraBedField;

    private byte numberOfExtraBedsField;

    private bool sharingBeddingField;

    private byte numberOfCotsField;

    /// <remarks/>
    public string Description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }

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
    public string Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
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
    public byte NumberOfExtraBeds
    {
        get
        {
            return this.numberOfExtraBedsField;
        }
        set
        {
            this.numberOfExtraBedsField = value;
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

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte NumberOfCots
    {
        get
        {
            return this.numberOfCotsField;
        }
        set
        {
            this.numberOfCotsField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingRequestBookingItemHotelItemHotelPaxRoom
{

    private string descriptionField;

    private byte[] paxIdsField;

    private byte adultsField;

    private byte childrenField;

    private byte cotsField;

    private string idField;

    private bool sharingBeddingField;

    /// <remarks/>
    public string Description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }

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
    public byte Adults
    {
        get
        {
            return this.adultsField;
        }
        set
        {
            this.adultsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte Children
    {
        get
        {
            return this.childrenField;
        }
        set
        {
            this.childrenField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte Cots
    {
        get
        {
            return this.cotsField;
        }
        set
        {
            this.cotsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
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
public partial class RequestRequestDetailsModifyBookingRequest
{

    private RequestRequestDetailsModifyBookingRequestBookingReference bookingReferenceField;

    private string agentReferenceField;

    private System.DateTime bookingDepartureDateField;

    private string passengerEmailField;

    private RequestRequestDetailsModifyBookingRequestPaxName[] paxNamesField;

    /// <remarks/>
    public RequestRequestDetailsModifyBookingRequestBookingReference BookingReference
    {
        get
        {
            return this.bookingReferenceField;
        }
        set
        {
            this.bookingReferenceField = value;
        }
    }

    /// <remarks/>
    public string AgentReference
    {
        get
        {
            return this.agentReferenceField;
        }
        set
        {
            this.agentReferenceField = value;
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
    public string PassengerEmail
    {
        get
        {
            return this.passengerEmailField;
        }
        set
        {
            this.passengerEmailField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("PaxName", IsNullable = false)]
    public RequestRequestDetailsModifyBookingRequestPaxName[] PaxNames
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
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsModifyBookingRequestBookingReference
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
public partial class RequestRequestDetailsModifyBookingRequestPaxName
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
public partial class RequestRequestDetailsCancelBookingRequest
{

    private RequestRequestDetailsCancelBookingRequestBookingReference bookingReferenceField;

    /// <remarks/>
    public RequestRequestDetailsCancelBookingRequestBookingReference BookingReference
    {
        get
        {
            return this.bookingReferenceField;
        }
        set
        {
            this.bookingReferenceField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsCancelBookingRequestBookingReference
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
public partial class RequestRequestDetailsSearchBookingRequest
{

    private RequestRequestDetailsSearchBookingRequestBookingReference bookingReferenceField;

    private RequestRequestDetailsSearchBookingRequestBookingDateRange bookingDateRangeField;

    private byte bookingStatusCodeField;

    private string bookingNameField;

    private bool echoSearchCriteriaField;

    /// <remarks/>
    public RequestRequestDetailsSearchBookingRequestBookingReference BookingReference
    {
        get
        {
            return this.bookingReferenceField;
        }
        set
        {
            this.bookingReferenceField = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsSearchBookingRequestBookingDateRange BookingDateRange
    {
        get
        {
            return this.bookingDateRangeField;
        }
        set
        {
            this.bookingDateRangeField = value;
        }
    }

    /// <remarks/>
    public byte BookingStatusCode
    {
        get
        {
            return this.bookingStatusCodeField;
        }
        set
        {
            this.bookingStatusCodeField = value;
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
    public bool EchoSearchCriteria
    {
        get
        {
            return this.echoSearchCriteriaField;
        }
        set
        {
            this.echoSearchCriteriaField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsSearchBookingRequestBookingReference
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
public partial class RequestRequestDetailsSearchBookingRequestBookingDateRange
{

    private string dateTypeField;

    private System.DateTime valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string DateType
    {
        get
        {
            return this.dateTypeField;
        }
        set
        {
            this.dateTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute(DataType = "date")]
    public System.DateTime Value
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
public partial class RequestRequestDetailsAddBookingItemRequest
{

    private RequestRequestDetailsAddBookingItemRequestBookingReference bookingReferenceField;

    private RequestRequestDetailsAddBookingItemRequestBookingItems bookingItemsField;

    /// <remarks/>
    public RequestRequestDetailsAddBookingItemRequestBookingReference BookingReference
    {
        get
        {
            return this.bookingReferenceField;
        }
        set
        {
            this.bookingReferenceField = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsAddBookingItemRequestBookingItems BookingItems
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
public partial class RequestRequestDetailsAddBookingItemRequestBookingReference
{

    private string referenceSourceField;

    private ushort valueField;

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
    public ushort Value
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
public partial class RequestRequestDetailsAddBookingItemRequestBookingItems
{

    private RequestRequestDetailsAddBookingItemRequestBookingItemsBookingItem bookingItemField;

    /// <remarks/>
    public RequestRequestDetailsAddBookingItemRequestBookingItemsBookingItem BookingItem
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
public partial class RequestRequestDetailsAddBookingItemRequestBookingItemsBookingItem
{

    private byte itemReferenceField;

    private RequestRequestDetailsAddBookingItemRequestBookingItemsBookingItemItemCity itemCityField;

    private RequestRequestDetailsAddBookingItemRequestBookingItemsBookingItemItem itemField;

    private RequestRequestDetailsAddBookingItemRequestBookingItemsBookingItemItemRemarks itemRemarksField;

    private RequestRequestDetailsAddBookingItemRequestBookingItemsBookingItemHotelItem hotelItemField;

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
    public RequestRequestDetailsAddBookingItemRequestBookingItemsBookingItemItemCity ItemCity
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
    public RequestRequestDetailsAddBookingItemRequestBookingItemsBookingItemItem Item
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
    public RequestRequestDetailsAddBookingItemRequestBookingItemsBookingItemItemRemarks ItemRemarks
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
    public RequestRequestDetailsAddBookingItemRequestBookingItemsBookingItemHotelItem HotelItem
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
public partial class RequestRequestDetailsAddBookingItemRequestBookingItemsBookingItemItemCity
{

    private string codeField;

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
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingItemRequestBookingItemsBookingItemItem
{

    private string codeField;

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
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingItemRequestBookingItemsBookingItemItemRemarks
{

    private RequestRequestDetailsAddBookingItemRequestBookingItemsBookingItemItemRemarksItemRemark itemRemarkField;

    /// <remarks/>
    public RequestRequestDetailsAddBookingItemRequestBookingItemsBookingItemItemRemarksItemRemark ItemRemark
    {
        get
        {
            return this.itemRemarkField;
        }
        set
        {
            this.itemRemarkField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingItemRequestBookingItemsBookingItemItemRemarksItemRemark
{

    private string codeField;

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
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingItemRequestBookingItemsBookingItemHotelItem
{

    private bool alternativesAllowedField;

    private RequestRequestDetailsAddBookingItemRequestBookingItemsBookingItemHotelItemPeriodOfStay periodOfStayField;

    private RequestRequestDetailsAddBookingItemRequestBookingItemsBookingItemHotelItemHotelRooms hotelRoomsField;

    private string[] textField;

    /// <remarks/>
    public bool AlternativesAllowed
    {
        get
        {
            return this.alternativesAllowedField;
        }
        set
        {
            this.alternativesAllowedField = value;
        }
    }

    /// <remarks/>
    public RequestRequestDetailsAddBookingItemRequestBookingItemsBookingItemHotelItemPeriodOfStay PeriodOfStay
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
    public RequestRequestDetailsAddBookingItemRequestBookingItemsBookingItemHotelItemHotelRooms HotelRooms
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
    [System.Xml.Serialization.XmlTextAttribute()]
    public string[] Text
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
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RequestRequestDetailsAddBookingItemRequestBookingItemsBookingItemHotelItemPeriodOfStay
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
public partial class RequestRequestDetailsAddBookingItemRequestBookingItemsBookingItemHotelItemHotelRooms
{

    private RequestRequestDetailsAddBookingItemRequestBookingItemsBookingItemHotelItemHotelRoomsHotelRoom hotelRoomField;

    /// <remarks/>
    public RequestRequestDetailsAddBookingItemRequestBookingItemsBookingItemHotelItemHotelRoomsHotelRoom HotelRoom
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
public partial class RequestRequestDetailsAddBookingItemRequestBookingItemsBookingItemHotelItemHotelRoomsHotelRoom
{

    private byte[] paxIdsField;

    private string codeField;

    private bool extraBedField;

    private byte numberOfCotsField;

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
    public byte NumberOfCots
    {
        get
        {
            return this.numberOfCotsField;
        }
        set
        {
            this.numberOfCotsField = value;
        }
    }
}

