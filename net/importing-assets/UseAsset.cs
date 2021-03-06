// DocSection: importing_assets_use_asset
// Tip: Find more about .NET SDKs at https://docs.kontent.ai/net
// Using Management API v1
// Upsert a language variant which references the asset using external ID
CafeModel stronglyTypedElements = new CafeModel
{
    Picture = AssetIdentifier.ByExternalId("brno-cafe-image"),
};

ContentItemIdentifier itemIdentifier = ContentItemIdentifier.ByExternalId("ext-cafe-brno");
LanguageIdentifier languageIdentifier = LanguageIdentifier.ByCodename("en-US");
ContentItemVariantIdentifier identifier = new ContentItemVariantIdentifier(itemIdentifier, languageIdentifier);

ContentItemVariantModel<CafeModel> variantResponse = await client.UpsertContentItemVariantAsync<CafeModel>(identifier, stronglyTypedElements);
// EndDocSection