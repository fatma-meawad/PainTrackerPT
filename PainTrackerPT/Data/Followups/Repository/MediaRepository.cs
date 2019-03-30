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

namespace PainTrackerPT.Data.Followups
{
    public class MediaRepository : BaseRepository
    {
        DbSet<Media> mediaSet;

        public MediaRepository(PainTrackerPTContext db) : base(db)
        {
            mediaSet = db.Set<Media>();
        }

        public void Create(Media media)
        {
            this.mediaSet.Add(media);
            db.SaveChanges();
        }

        public async Task<IEnumerable<Media>> SelectAll()
        {
            return await mediaSet.ToArrayAsync();
        }

        public async Task<Media> Select(Guid mediaId)
        {
            return mediaSet.Find(mediaId);
        }

        public void Remove(Guid mediaId)
        {
            Media media = mediaSet.Find(mediaId);
            if (media != null)
            {
                mediaSet.Remove(media);
                this.Save();
            }
        }

        public void Update(Media media)
        {
            Media existingMedia = mediaSet.Find(media.id);
            mediaSet.Update(media);
            this.Save();
        }
    }
}
