namespace Project01.Application.CustomAuthFilters
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastPasswordChangeDate { get; set; }
    }
}
