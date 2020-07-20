// DocSection: cm_api_v2_get_taxonomy_group
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
// Using ES6 syntax
import { ManagementClient } from '@kentico/kontent-management';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

client.getTaxonomy()
    .byTaxonomyCodename("personas_222")
    //.byTaxonomyID("dbff8416-c4c7-45d2-b497-a4a71a5cbe30")
    //.byTaxonomyExternalID("Tax-Group-124")
    .toObservable()
    .subscribe((response) => {
        console.log(response);
    },
    (error) => {
        console.log(error);
    });
// EndDocSection