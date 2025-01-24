using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering.VisualBookshelfNTier.Entities
{
    public class AppRole : BaseEntity
    {
        public string Definition { get; set; }

        virtual public List<AppUserRole> AppUserRoles { get; set; }
    }
}
