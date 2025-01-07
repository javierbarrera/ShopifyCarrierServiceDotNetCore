using System.Text.Json.Serialization;

public class DTORateRequest
{
    [JsonPropertyName("rate")]
    public DTORateRequestDetails RateRequestDetails { get; set; }

    public DTORateRequest()
    {
        RateRequestDetails = new DTORateRequestDetails();
    }
}