using System.Globalization;

public class RateFactory(IRateRequestDetails rateRequestDetails)
{
    public List<IRate> GetMockRates()
    {
        var mockDateString = "2013-04-12 14:48:45 -0400";
        var mockDate = DateTime.Parse(mockDateString);
        string formattedDateTime = mockDate.ToString("o");

        return
        [
            new DTORate
            {
                ServiceName = "canadapost-overnight",
                ServiceCode = "ON",
                TotalPrice = "1295",
                Description = "This is the fastest option by far",
                Currency = "CAD",
                MinDeliveryDate = mockDate,
                MinDeliveryDateFormatted = formattedDateTime,
                MaxDeliveryDate = mockDate,
                MaxDeliveryDateFormatted = formattedDateTime
            },
            new DTORate
            {
                ServiceName = "fedex-2dayground",
                ServiceCode = "2D",
                TotalPrice = "2934",
                Currency = "USD",
                MinDeliveryDate = mockDate,
                MinDeliveryDateFormatted = formattedDateTime,
                MaxDeliveryDate = mockDate,
                MaxDeliveryDateFormatted = formattedDateTime
            },
            new DTORate
            {
                ServiceName = "fedex-priorityovernight",
                ServiceCode = "1D",
                TotalPrice = "3587",
                Currency = "USD",
                MinDeliveryDate = mockDate,
                MinDeliveryDateFormatted = formattedDateTime,
                MaxDeliveryDate = mockDate,
                MaxDeliveryDateFormatted = formattedDateTime
            }
        ];
    }
}