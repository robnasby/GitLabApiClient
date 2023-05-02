namespace GitLabApiClient.Models.Compare.Requests
{
    public sealed class CompareQueryOptions
    {
        public string From { get; set; }
        public int? FromProjectId { get; set; }
        public bool Straight { get; set; }
        public string To { get; set; }

        internal CompareQueryOptions(string from, string to, int? fromProjectId = null, bool straight = false)
        {
            From = from;
            FromProjectId = fromProjectId;
            Straight = straight;
            To = to;
        }
    }
}
