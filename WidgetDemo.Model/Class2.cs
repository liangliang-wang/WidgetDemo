
public class Rootobject
{
    public Data data { get; set; }
    public int errno { get; set; }
    public string errmsg { get; set; }
}

public class Data
{
    public float ProductMinPrice { get; set; }
    public string ProductMinPriceRemark { get; set; }
    public float ProductDiscount { get; set; }
    public float ProductMarketPrice { get; set; }
    public string DateRangeEffectDate { get; set; }
    public string DateRangeExpireDate { get; set; }
    public Availabledate[] AvailableDate { get; set; }
    public object FestivalsDate { get; set; }
    public string ProhibitDate { get; set; }
    public Promotioninfo PromotionInfo { get; set; }
    public object DepartureCity { get; set; }
    public bool HasReturnDate { get; set; }
    public int ReturnDateMinDateAddDays { get; set; }
    public int ReturnDateMaxDateAddDays { get; set; }
    public string SecondSegmentSchedule { get; set; }
    public int CountryID { get; set; }
}

public class Promotioninfo
{
    public object[] Promotions { get; set; }
    public object PromotionTags { get; set; }
}

public class Availabledate
{
    public string Date { get; set; }
    public float MinPrice { get; set; }
    public int RemainingInventory { get; set; }
    public string IsAnnouncedGroup { get; set; }
    public Tourgroupcalenderinfo[] TourGroupCalenderInfo { get; set; }
}

public class Tourgroupcalenderinfo
{
    public bool IsAnnouncedGroup { get; set; }
    public int MinPrice { get; set; }
    public int ProductID { get; set; }
    public int RemainingAmount { get; set; }
    public int RemainingInventory { get; set; }
}
