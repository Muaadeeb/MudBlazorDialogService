namespace MudBlazorServer.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public string Item { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
