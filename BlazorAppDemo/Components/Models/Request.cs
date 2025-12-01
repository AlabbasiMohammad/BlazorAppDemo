namespace BlazorAppDemo.Components.Models
{

    public class Request
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Company { get; set; }
        public string? CustomerComment { get; set; }
        public string? TenantId { get; set; }
        public string? DefaultDomain { get; set; }
        //public List<Country> Countries { get; set; } = new();
        //public string? Classification { get; set; }
        //  public int? MaximumAccommodation { get; set; }
        public DateTime RequestedAt { get; set; } = DateTime.Now;
        // public bool HasTeleporter { get; set; }
        public string? RequestedIp { get; set; } = "";
        public bool TrialRequested { get; set; }

        public bool Completed { get; set; }
    }
}
