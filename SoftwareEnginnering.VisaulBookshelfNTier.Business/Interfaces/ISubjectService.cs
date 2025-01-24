using SoftwareEngineering.VisualBookshelfNTier.Dtos;
using SoftwareEngineering.VisualBookshelfNTier.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering.VisaulBookshelfNTier.Business.Interfaces
{
    public interface ISubjectService : IService<SubjectCreateDto, SubjectUpdateDto, SubjectListDto, Subject>
    {
    }
}
