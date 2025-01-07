public interface IRateRequestDetails
{
    public Address Origin { get; set; }
    public Address Destination { get; set; }
    public IEnumerable<ILineItem> Items { get; set; }
    public string Currency { get; set; }
    public string Locale { get; set; }
}