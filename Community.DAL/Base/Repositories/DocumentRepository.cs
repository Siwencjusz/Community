using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Community.DAL.Base.BaseRepository;
using Community.DAL.Document;

namespace Community.DAL.Base.Repositories
{
    public class DocumentRepository : BaseRepository<Document.Document>,IDocumentRepository
    {
        public DocumentRepository(DbContext context) : base(context)
        {
            
        }
    }
}
