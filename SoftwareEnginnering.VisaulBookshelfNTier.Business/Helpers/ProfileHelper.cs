using AutoMapper;
using SoftwareEngineering.VisaulBookshelfNTier.Business.Mappings.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering.VisaulBookshelfNTier.Business.Helpers
{
    public static class ProfileHelper
    {
        public static List<Profile> GetProfiles()
        {
            return new List<Profile>
            {
                new AuthorProfile(),
                new BookProfile(),
                new BookAuthorProfile(),
                new BookSubjectProfile(),
                new BookshelfProfile(),
                new SubjectProfile(),
                new LanguageProfile(),
                new BookTranslatorProfile(),
                new TranslatorProfile(),
                new BookLanguageProfile(),
                new AppUserProfile(),
                new AppRoleProfile(),
            };

       
        }
    }
}
