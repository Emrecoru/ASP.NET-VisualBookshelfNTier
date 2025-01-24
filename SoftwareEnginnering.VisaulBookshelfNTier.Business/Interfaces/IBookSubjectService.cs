using SoftwareEngineering.VisualBookshelfNTier.Dtos;
using SoftwareEngineering.VisualBookshelfNTier.Entities;

namespace SoftwareEngineering.VisaulBookshelfNTier.Business.Interfaces
{
    public interface IBookSubjectService : IService<BookSubjectCreateDto, BookSubjectUpdateDto, BookSubjectListDto, BookSubject>
    {
    }
}
