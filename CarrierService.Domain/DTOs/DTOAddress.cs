using System.Text.Json.Serialization;
public class DTOAddress : IAddress
{
    [JsonPropertyName("country")]
    public string Country { get; set; }

    [JsonPropertyName("postal_code")]
    public string PostalCode { get; set; }

    [JsonPropertyName("province")]
    public string Province { get; set; }

    [JsonPropertyName("city")]
    public string City { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("address1")]
    public string Address1 { get; set; }

    [JsonPropertyName("address2")]
    public string Address2 { get; set; }

    [JsonPropertyName("address3")]
    public string Address3 { get; set; }

    [JsonPropertyName("phone")]
    public string Phone { get; set; }

    [JsonPropertyName("fax")]
    public string Fax { get; set; }

    [JsonPropertyName("email")]
    public string Email { get; set; }

    [JsonPropertyName("address_type")]
    public string AddressType { get; set; }

    [JsonPropertyName("company_name")]
    public string CompanyName { get; set; }

    public DTOAddress()
    {
        Country = string.Empty;
        PostalCode = string.Empty;
        Province = string.Empty;
        City = string.Empty;
        Name = string.Empty;
        Address1 = string.Empty;
        Address2 = string.Empty;
        Address3 = string.Empty;
        Phone = string.Empty;
        Fax = string.Empty;
        Email = string.Empty;
        AddressType = string.Empty;
        CompanyName = string.Empty;
    }
}