public class Rate : IRate
{
    public string ServiceName { get; set; }
    public string ServiceCode { get; set; }
    public string TotalPrice { get; set; }
    public string Description { get; set; }
    public string Currency { get; set; }
    public bool? PhoneRequired { get; set; }
    public DateTime? MinDeliveryDate { get; set; }
    public DateTime? MaxDeliveryDate { get; set; }

    public Rate()
    {
        ServiceName = string.Empty;
        ServiceCode = string.Empty;
        TotalPrice = string.Empty;
        Description = string.Empty;
        Currency = string.Empty;
    }
}