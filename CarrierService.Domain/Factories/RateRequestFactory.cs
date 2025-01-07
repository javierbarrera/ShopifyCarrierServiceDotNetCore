public class RateRequestFactory
{
    public static RateRequestDetails MapFromDTO(DTORateRequest rateRequest)
    {
        var rateRequestDetails = new RateRequestDetails
        {
            Origin = new Address
            {
                Country = rateRequest.RateRequestDetails.Origin.Country,
                PostalCode = rateRequest.RateRequestDetails.Origin.PostalCode,
                Province = rateRequest.RateRequestDetails.Origin.Province,
                City = rateRequest.RateRequestDetails.Origin.City,
                Name = rateRequest.RateRequestDetails.Origin.Name,
                Address1 = rateRequest.RateRequestDetails.Origin.Address1,
                Address2 = rateRequest.RateRequestDetails.Origin.Address2,
                Address3 = rateRequest.RateRequestDetails.Origin.Address3,
                Phone = rateRequest.RateRequestDetails.Origin.Phone,
                Fax = rateRequest.RateRequestDetails.Origin.Fax,
                Email = rateRequest.RateRequestDetails.Origin.Email,
                AddressType = rateRequest.RateRequestDetails.Origin.AddressType,
                CompanyName = rateRequest.RateRequestDetails.Origin.CompanyName
            },
            Destination = new Address
            {
                Country = rateRequest.RateRequestDetails.Destination.Country,
                PostalCode = rateRequest.RateRequestDetails.Destination.PostalCode,
                Province = rateRequest.RateRequestDetails.Destination.Province,
                City = rateRequest.RateRequestDetails.Destination.City,
                Name = rateRequest.RateRequestDetails.Destination.Name,
                Address1 = rateRequest.RateRequestDetails.Destination.Address1,
                Address2 = rateRequest.RateRequestDetails.Destination.Address2,
                Address3 = rateRequest.RateRequestDetails.Destination.Address3,
                Phone = rateRequest.RateRequestDetails.Destination.Phone,
                Fax = rateRequest.RateRequestDetails.Destination.Fax,
                Email = rateRequest.RateRequestDetails.Destination.Email,
                AddressType = rateRequest.RateRequestDetails.Destination.AddressType,
                CompanyName = rateRequest.RateRequestDetails.Destination.CompanyName
            },
            Items = rateRequest.RateRequestDetails.Items.Select(item => new LineItem
            {
                Name = item.Name,
                Sku = item.Sku,
                Quantity = item.Quantity,
                Grams = item.Grams,
                Price = item.Price,
                Vendor = item.Vendor,
                RequiresShipping = item.RequiresShipping,
                Taxable = item.Taxable,
                FulfillmentService = item.FulfillmentService,
                Properties = item.Properties,
                ProductId = item.ProductId,
                VariantId = item.VariantId
            }).ToList(),
            Currency = rateRequest.RateRequestDetails.Currency,
            Locale = rateRequest.RateRequestDetails.Locale
        };

        return rateRequestDetails;
    }
}