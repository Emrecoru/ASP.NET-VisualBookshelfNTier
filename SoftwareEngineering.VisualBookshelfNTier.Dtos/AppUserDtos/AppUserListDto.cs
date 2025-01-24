using SoftwareEngineering.VisualBookshelfNTier.Dtos.Interfaces;

namespace SoftwareEngineering.VisualBookshelfNTier.Dtos
{
    public class AppUserListDto : IDto
    {
        public int Id { get; set; }

        public string Firstname { get; set; }

        public string Surname { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }
    }
}
