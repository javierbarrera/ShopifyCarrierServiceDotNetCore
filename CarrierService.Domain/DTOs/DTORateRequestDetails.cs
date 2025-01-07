using System.Text.Json.Serialization;

public class DTORateRequestDetails
{
    [JsonPropertyName("origin")]
    public DTOAddress Origin { get; set; }

    [JsonPropertyName("destination")]
    public DTOAddress Destination { get; set; }

    [JsonPropertyName("items")]
    public IEnumerable<DTOLineItem> Items { get; set; }

    [JsonPropertyName("currency")]
    public string Currency { get; set; }

    [JsonPropertyName("locale")]
    public string Locale { get; set; }

    public DTORateRequestDetails()
    {
        Origin = new DTOAddress();
        Destination = new DTOAddress();
        Items = new List<DTOLineItem>();
        Currency = string.Empty;
        Locale = string.Empty;
    }
}