namespace Project01.Application.IsActive
{
    public class UserCommand
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastPasswordChangeDate { get; set; }
    }
}
