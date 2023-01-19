namespace MudBlazorServer.Models
{
    public class Server
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Location { get; set; } = null!;
        public string IpAddress { get; set; } = null!;
    }
}
