// DocSection: filtering_get_items_by_string_element_value
List<NameValuePair> params = DeliveryParameterBuilder.params()
  // Gets items whose Article title element equals "Get started with MVC"
  .filterEquals("elements.article_title", "Get started with MVC")
// EndDocSection
