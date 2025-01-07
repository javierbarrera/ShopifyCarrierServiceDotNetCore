```
   ____                _             ____                  _
  / ___|__ _ _ __ _ __(_) ___ _ __  / ___|  ___ _ ____   _(_) ___ ___
 | |   / _` | '__| '__| |/ _ \ '__| \___ \ / _ \ '__\ \ / / |/ __/ _ \
 | |__| (_| | |  | |  | |  __/ |     ___) |  __/ |   \ V /| | (_|  __/
  \____\__,_|_|  |_|  |_|\___|_|    |____/ \___|_|    \_/ |_|\___\___|
```

# Shopify Carrier Service App, Part 1
This is Part 1 of building a Shopify Carrier Service in .NET.

The current app uses .NET Core minimal APIs and has models to receive rate requests from Shopify, and to output them in the expected response format. The current API response can generate mock rates for testing.

There will be a continued Part 2, where we generate dynamic rates and wire up the Shopify app fundamentals to install/uninstall the app and register the carrier service with a shop.

## Getting Started

- Clone this repository
- Go to the `CarrierService.WebService` folder
- Run `dotnet build`
- Run `dotnet run`

Using Postman, or another HTTP client, make a `POST` to the API endpoint with a payload similar to that used in the Shopify developer documentation.

```
{
    "rate": {
        "origin": {
            "country": "CA",
            "postal_code": "K2P1L4",
            "province": "ON",
            "city": "Ottawa",
            "name": null,
            "address1": "150 Elgin St.",
            "address2": "",
            "address3": null,
            "phone": null,
            "fax": null,
            "email": null,
            "address_type": null,
            "company_name": "Jamie D's Emporium"
        },
        "destination": {
            "country": "CA",
            "postal_code": "K1M1M4",
            "province": "ON",
            "city": "Ottawa",
            "name": "Bob Norman",
            "address1": "24 Sussex Dr.",
            "address2": "",
            "address3": null,
            "phone": null,
            "fax": null,
            "email": null,
            "address_type": null,
            "company_name": null
        },
        "items": [
            {
                "name": "Short Sleeve T-Shirt",
                "sku": "",
                "quantity": 1,
                "grams": 1000,
                "price": 1999,
                "vendor": "Jamie D's Emporium",
                "requires_shipping": true,
                "taxable": true,
                "fulfillment_service": "manual",
                "properties": null,
                "product_id": 48447225880,
                "variant_id": 258644705304
            }
        ],
        "currency": "USD",
        "locale": "en"
    }
}
```