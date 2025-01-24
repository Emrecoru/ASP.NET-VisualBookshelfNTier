using SoftwareEngineering.VisualBookshelfNTier.DataAccess.Contexts;
using SoftwareEngineering.VisualBookshelfNTier.DataAccess.Interfaces;
using SoftwareEngineering.VisualBookshelfNTier.DataAccess.Repositories;
using SoftwareEngineering.VisualBookshelfNTier.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering.VisualBookshelfNTier.DataAccess.UnitOfWork
{
    public class Uow : IUow
    {
        private readonly BookContext _context;

        public Uow(BookContext context)
        {
            _context = context;
        }

        public IRepository<T> GetRepository<T>() where T : BaseEntity
        {
            return new Repository<T>(_context);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
