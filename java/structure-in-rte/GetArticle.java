// DocSection: structure_in_rte_retrieve_article
// Tip: Find more about Java/JavaRx SDKs at https://docs.kontent.ai/java
SimpleArticleItem item = client.getItem("my_article", SimpleArticleItem.class);

String description = item.body;
// EndDocSection
