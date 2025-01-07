using System.Text.Json.Serialization;
public class DTORate : IRate
{
    // 	The name of the rate, which customers see at checkout. For example: Expedited Mail.
    [JsonPropertyName("service_name")]
    public string ServiceName { get; set; }

    // A unique code associated with the rate. For example: expedited_mail.
    [JsonPropertyName("service_code")]
    public string ServiceCode { get; set; }

    // The total price expressed in subunits. If the currency doesn't use subunits, then the value must be multiplied by 100. For example: "total_price": 500 for 5.00 CAD, "total_price": 100000 for 1000 JPY.
    [JsonPropertyName("total_price")]
    public string TotalPrice { get; set; }

    // 	A description of the rate, which customers see at checkout. For example: Includes tracking and insurance.
    [JsonPropertyName("description")]
    public string Description { get; set; }

    // The currency of the shipping rate.
    [JsonPropertyName("currency")]
    public string Currency { get; set; }

    // Whether the customer must provide a phone number at checkout.
    [JsonPropertyName("phone_required")]
    public bool? PhoneRequired { get; set; }

    // The earliest delivery date for the displayed rate.
    [JsonIgnore]
    public DateTime? MinDeliveryDate { get; set; }

    [JsonPropertyName("min_delivery_date")]
    public string? MinDeliveryDateFormatted { get; set; }

    // The latest delivery date for the displayed rate to still be valid.
    [JsonIgnore]
    public DateTime? MaxDeliveryDate { get; set; }

    [JsonPropertyName("max_delivery_date")]
    public string? MaxDeliveryDateFormatted { get; set; }

    public DTORate()
    {
        ServiceName = string.Empty;
        ServiceCode = string.Empty;
        TotalPrice = string.Empty;
        Description = string.Empty;
        Currency = string.Empty;
    }
}