using System.Collections.Generic;
using GitLabApiClient.Models.Commits.Responses;
using Newtonsoft.Json;

namespace GitLabApiClient.Models.Compare.Responses
{
    public sealed class Compare
    {
        [JsonProperty("commit")]
        public Commit Commit { get; set; }

        [JsonProperty("commits")]
        public IEnumerable<Commit> Commits { get; set; }

        [JsonProperty("diffs")]
        public IEnumerable<Diff> Diffs { get; set; }

        [JsonProperty("compare_timeout")]
        public bool CompareTimeout { get; set; }

        [JsonProperty("compare_same_ref")]
        public bool CompareSameRef { get; set; }

        [JsonProperty("web_url")]
        public string WebUrl { get; set; }

    }
}
