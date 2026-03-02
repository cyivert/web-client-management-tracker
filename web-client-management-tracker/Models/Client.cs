namespace web_client_management_tracker.Models
{
    public class Client
    {
        public int Id { get; set; }                                             // Unique identifier for the client
        public string Name { get; set; } = string.Empty;                        // Client's full name
        public string Email { get; set; } = string.Empty;                       // Client's email address
        public string Goal { get; set; } = string.Empty;                        // Client's goal or objective
        public DateTime StartDate { get; set; } = DateTime.Today;               // Date when the client started working with the service
    }
}
