using System;
using System.Threading.Tasks;
using GitLabApiClient.Internal.Http;
using GitLabApiClient.Internal.Paths;
using GitLabApiClient.Internal.Queries;
using GitLabApiClient.Models.Compare.Requests;
using GitLabApiClient.Models.Compare.Responses;

namespace GitLabApiClient
{
    public sealed class CompareClient : ICompareClient
    {
        private readonly GitLabHttpFacade _httpFacade;
        private readonly CompareQueryBuilder _compareQueryBuilder;

        internal CompareClient(GitLabHttpFacade httpFacade, CompareQueryBuilder compareQueryBuilder)
        {
            _httpFacade = httpFacade;
            _compareQueryBuilder = compareQueryBuilder;
        }

        /// <summary>
        /// Compare branches, tags or commits.
        /// </summary>
        /// <param name="projectId">The ID or path of the project owned by the authenticated user.</param>
        /// <param name="from">The "from" commit SHA or branch name.</param>
        /// <param name="to">The "to" commit SHA or branch name.</param>
        /// <param name="options">Additional compare options.</param>
        /// <returns></returns>
        public async Task<Compare> GetAsync(ProjectId projectId, string from, string to, Action<CompareQueryOptions> options)
        {
            var queryOptions = new CompareQueryOptions(from, to);
            options?.Invoke(queryOptions);

            string url = _compareQueryBuilder.Build($"projects/{projectId}/repository/compare", queryOptions);
            return await _httpFacade.Get<Compare>(url);
        }
    }
}
