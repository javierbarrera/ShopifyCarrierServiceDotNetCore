public interface ILineItem
{
    string Name { get; set; }
    string Sku { get; set; }
    int Quantity { get; set; }
    int Grams { get; set; }
    int Price { get; set; }
    string Vendor { get; set; }
    bool RequiresShipping { get; set; }
    bool Taxable { get; set; }
    string FulfillmentService { get; set; }
    string Properties { get; set; }
    long ProductId { get; set; }
    long VariantId { get; set; }
}