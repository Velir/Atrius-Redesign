using Sitecore.ContentSearch.SolrProvider.Abstractions;
using Sitecore.ContentSearch.SolrProvider.Pipelines.PopulateSolrSchema;
using SolrNet.Schema;

namespace Thread.Foundation.Search.Schema
{
    public class CustomPopulateHelperFactory : IPopulateHelperFactory
    {
        public ISchemaPopulateHelper GetPopulateHelper(SolrSchema solrSchema)
        {
            return new CustomPopulateHelper(solrSchema);
        }
    }
}