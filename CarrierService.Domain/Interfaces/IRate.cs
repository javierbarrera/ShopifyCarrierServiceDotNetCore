public interface IRate
{
    string ServiceName { get; set; }
    string ServiceCode { get; set; }
    string TotalPrice { get; set; }
    string Description { get; set; }
    string Currency { get; set; }
    bool? PhoneRequired { get; set; }
    DateTime? MinDeliveryDate { get; set; }
    DateTime? MaxDeliveryDate { get; set; }
}