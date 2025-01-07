public class Address : IAddress
{
    public string Country { get; set; }

    public string PostalCode { get; set; }

    public string Province { get; set; }

    public string City { get; set; }

    public string Name { get; set; }

    public string Address1 { get; set; }

    public string Address2 { get; set; }

    public string Address3 { get; set; }

    public string Phone { get; set; }

    public string Fax { get; set; }

    public string Email { get; set; }

    public string AddressType { get; set; }

    public string CompanyName { get; set; }

    public Address()
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