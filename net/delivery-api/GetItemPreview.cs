// DocSection: delivery_api_get_item_preview
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
using KenticoCloud.Delivery;

// Initializes a delivery client for previewing content
IDeliveryClient client = DeliveryClientBuilder
    .WithOptions(builder => builder
        .WithProjectId("975bf280-fd91-488c-994c-2f04416e5ee3")
        .UsePreviewApi("<YOUR_PREVIEW_API_KEY>")
        .Build())
    .Build();

// Generate strongly typed models via https://github.com/Kentico/cloud-generators-net
DeliveryItemResponse<object> response = await client.GetItemAsync<object>("on_roasts");

var items = response.Items;
// EndDocSection