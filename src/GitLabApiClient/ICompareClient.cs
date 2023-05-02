using System;
using System.Threading.Tasks;
using GitLabApiClient.Internal.Paths;
using GitLabApiClient.Models.Compare.Requests;
using GitLabApiClient.Models.Compare.Responses;

namespace GitLabApiClient
{
    public interface ICompareClient
    {
        Task<Compare> GetAsync(ProjectId projectId, string from, string to, Action<CompareQueryOptions> options = null);
    }
}
