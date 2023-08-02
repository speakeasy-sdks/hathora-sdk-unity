# metricsV1

## Overview

Operations to get metrics by [process](https://hathora.dev/docs/concepts/hathora-entities#process). We store 72 hours of metrics data.

### Available Operations

* [GetMetrics](#getmetrics) - Get metrics for a [process](https://hathora.dev/docs/concepts/hathora-entities#process) using `appId` and `processId`.

## GetMetrics

Get metrics for a [process](https://hathora.dev/docs/concepts/hathora-entities#process) using `appId` and `processId`.

### Example Usage

```unity
using Hathora;
using Hathora.Models.MetricsV1;
using Hathora.Models.Shared;

var sdk = new HathoraSDK();

var res = await sdk.MetricsV1.GetMetricsAsync(new GetMetricsSecurity() {
    Auth0 = "",
}, new GetMetricsRequest() {
    AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
    End = 9255.97F,
    Metrics = new List<MetricName>() {
        Hathora.Models.Shared.MetricName.Cpu,
        Hathora.Models.Shared.MetricName.Memory,
        Hathora.Models.Shared.MetricName.Cpu,
        Hathora.Models.Shared.MetricName.RateEgress,
    },
    ProcessId = "cbfcddd2-0006-43ae-996c-995fff7bed2e",
    Start = 202.18F,
    Step = 368241,
});
```

### Parameters

| Parameter                                                          | Type                                                               | Required                                                           | Description                                                        |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `request`                                                          | [GetMetricsRequest](../../Models/MetricsV1/GetMetricsRequest.md)   | :heavy_check_mark:                                                 | The request object to use for the request.                         |
| `security`                                                         | [GetMetricsSecurity](../../Models/MetricsV1/GetMetricsSecurity.md) | :heavy_check_mark:                                                 | The security requirements to use for the request.                  |


### Response

**[GetMetricsResponse](../../Models/MetricsV1/GetMetricsResponse.md)**

