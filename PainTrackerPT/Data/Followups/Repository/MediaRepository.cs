using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PainTrackerPT.Data.Followups.Repository;
using PainTrackerPT.Models;
using PainTrackerPT.Models.Followups;
using PainTrackerPT.Data.Followups.Repository;

namespace PainTrackerPT.Data.Followups
{

    public class MediaRepository : BaseRepository
    {
        private DbSet<Media> _mediaSet;

        public MediaRepository(PainTrackerPTContext db) : base(db)
        {
            _mediaSet = db.Set<Media>();
        }

        public void Create(Media media)
        {
            this._mediaSet.Add(media);
            db.SaveChanges();
        }

        public async Task<IEnumerable<Media>> SelectAll()
        {
            return await _mediaSet.ToArrayAsync();
        }

        public async Task<Media> Select(Guid mediaId)
        {
            return _mediaSet.Find(mediaId);

        }

        public void Remove(Guid mediaId)
        {
            Media media = _mediaSet.Find(mediaId);
            if (media != null)
            {
                _mediaSet.Remove(media);
                this.Save();
            }
        }

        public void Update(Media media)
        {
            Media existingMedia = _mediaSet.Find(media.id);
            _mediaSet.Update(media);
            this.Save();
        }
    }
}
