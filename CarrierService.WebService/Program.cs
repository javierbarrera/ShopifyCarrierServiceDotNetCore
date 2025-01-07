using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapPost("/", async (HttpContext context) =>
{
    // Deserialize the incoming JSON request body
    using var reader = new StreamReader(context.Request.Body);
    var requestBody = await reader.ReadToEndAsync();
    var rateRequest = new DTORateRequest();

    try
    {
        rateRequest = JsonSerializer.Deserialize<DTORateRequest>(requestBody);
    }
    catch (JsonException)
    {
        context.Response.StatusCode = 400; // Bad Request
        await context.Response.WriteAsync("Invalid JSON.");
        return;
    }

    if (rateRequest == null)
    {
        context.Response.StatusCode = 400; // Bad Request
        await context.Response.WriteAsync("Invalid request.");
        return;
    }

    // Map valid request DTO to domain object
    var rateRequestDetails = RateRequestFactory.MapFromDTO(rateRequest);

    // Get a list of rates
    var rateFactory = new RateFactory(rateRequestDetails);
    var rates = rateFactory.GetMockRates();
    var rateResponse = DTORateResponseFactory.BuildDTORateResponse(rates);

    // Serialize the list of rates to JSON
    var response = JsonSerializer.Serialize(rateResponse);

    // Return the JSON response
    context.Response.ContentType = "application/json";
    await context.Response.WriteAsync(response);
});

app.Run();