# GetInvoicesResponse


## Fields

| Field                                                                                                                | Type                                                                                                                 | Required                                                                                                             | Description                                                                                                          |
| -------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------- |
| `contentType`                                                                                                        | *string*                                                                                                             | :heavy_check_mark:                                                                                                   | N/A                                                                                                                  |
| `getInvoices404ApplicationJSONString`                                                                                | *string*                                                                                                             | :heavy_minus_sign:                                                                                                   | N/A                                                                                                                  |
| `invoices`                                                                                                           | List<[Invoice](../../Models/Shared/Invoice.md)>   !!!                                                                | :heavy_minus_sign:                                                                                                   | Ok                                                                                                                   |
| `statusCode`                                                                                                         | *int*                                                                                                                | :heavy_check_mark:                                                                                                   | N/A                                                                                                                  |
| `rawResponse`                                                                                                        | [HttpResponseMessage](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpresponsemessage?view=net-5.0) | :heavy_minus_sign:                                                                                                   | N/A                                                                                                                  |