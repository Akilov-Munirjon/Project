using MediatR;

namespace Project01.Domain.Filters
{
    public class ChangePasswordRequest : IRequest<bool>
    {
        public string CurrentLogin { get; set; }
        public string CurrentPassword { get; set; }
        public string Newlogin { get; set; }
        public string NewPassword { get; set; }

    }
}
