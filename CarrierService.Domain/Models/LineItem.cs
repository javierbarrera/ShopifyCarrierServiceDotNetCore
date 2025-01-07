public class LineItem : ILineItem
{
    public string Name { get; set; }

    public string Sku { get; set; }

    public int Quantity { get; set; }

    public int Grams { get; set; }

    public int Price { get; set; }

    public string Vendor { get; set; }

    public bool RequiresShipping { get; set; }

    public bool Taxable { get; set; }

    public string FulfillmentService { get; set; }

    public string Properties { get; set; }

    public long ProductId { get; set; }

    public long VariantId { get; set; }

    public LineItem()
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