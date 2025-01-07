public class RateRequestDetails : IRateRequestDetails
{
    public Address Origin { get; set; }
    public Address Destination { get; set; }
    public IEnumerable<ILineItem> Items { get; set; }
    public string Currency { get; set; }
    public string Locale { get; set; }

    public RateRequestDetails()
    {
        Origin = new Address();
        Destination = new Address();
        Items = new List<ILineItem>();
        Currency = string.Empty;
        Locale = string.Empty;
    }
}