using SoftwareEngineering.VisualBookshelfNTier.Dtos.Interfaces;

namespace SoftwareEngineering.VisualBookshelfNTier.Dtos
{
    public class AppUserLoginDto : IDto
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
