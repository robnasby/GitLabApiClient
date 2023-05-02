using GitLabApiClient.Models.Compare.Requests;

namespace GitLabApiClient.Internal.Queries
{
    internal class CompareQueryBuilder : QueryBuilder<CompareQueryOptions>
    {
        protected override void BuildCore(Query query, CompareQueryOptions options)
        {
            query.Add("from", options.From);
            query.Add("to", options.To);

            if (options.FromProjectId != null)
                query.Add("from_project_id", options.FromProjectId.Value);

            if (options.Straight)
                query.Add("straight", options.Straight);
        }
    }
}
