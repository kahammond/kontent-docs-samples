// DocSection: filtering_get_items_by_taxonomy_term
deliveryClient.items<ContentItem>()
  // Get articles tagged with specific tag
  .containsFilter("elements.tags", ["kentico"])

deliveryClient.items<ContentItem>()
  /// Gets articles tagged with any of the below tags
  .anyFilter("elements.tags", ["football"], ["soccer"])

deliveryClient.items<ContentItem>()
  // Gets articles tagged with all of the below tags
  .allFilter("elements.tags", ["mvc"], ["kontent"], ["headless"])
// EndDocSection
