namespace Project01.Application.IsActives
{
    public class UserData
    {
        public bool IsActive { get; set; }
        public DateTime AuthenticatedTime { get; set; }
        
        public DateTime GetPasswordChangeDateAsync { get; set; }
    }
}
