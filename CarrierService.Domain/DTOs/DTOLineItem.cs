using System.Text.Json.Serialization;

public class DTOLineItem : ILineItem
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("sku")]
    public string Sku { get; set; }

    [JsonPropertyName("quantity")]
    public int Quantity { get; set; }

    [JsonPropertyName("grams")]
    public int Grams { get; set; }

    [JsonPropertyName("price")]
    public int Price { get; set; }

    [JsonPropertyName("vendor")]
    public string Vendor { get; set; }

    [JsonPropertyName("requires_shipping")]
    public bool RequiresShipping { get; set; }

    [JsonPropertyName("taxable")]
    public bool Taxable { get; set; }

    [JsonPropertyName("fulfillment_service")]
    public string FulfillmentService { get; set; }

    [JsonPropertyName("properties")]
    public string Properties { get; set; }

    [JsonPropertyName("product_id")]
    public long ProductId { get; set; }

    [JsonPropertyName("variant_id")]
    public long VariantId { get; set; }

    public DTOLineItem()
    {
        Name = string.Empty;
        Sku = string.Empty;
        Quantity = 0;
        Grams = 0;
        Price = 0;
        Vendor = string.Empty;
        RequiresShipping = false;
        Taxable = false;
        FulfillmentService = string.Empty;
        Properties = string.Empty;
        ProductId = 0;
        VariantId = 0;
    }
}