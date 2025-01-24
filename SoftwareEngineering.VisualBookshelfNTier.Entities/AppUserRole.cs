using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering.VisualBookshelfNTier.Entities
{
    public class AppUserRole : BaseEntity
    {
        public int AppUserId { get; set; }

        virtual public AppUser AppUser { get; set; }

        public int AppRoleId { get; set; }

        virtual public AppRole AppRole { get; set; }
    }
}
