using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PainTrackerPT.Models;
using PainTrackerPT.Models.Followups;
using PainTrackerPT.Data.Followups.Repository;


namespace PainTrackerPT.Data.Followups
{

    public class MediaRepository : BaseRepository
    {
        DbSet<Media> MediaSet;

        public MediaRepository(PainTrackerPTContext db) : base(db)
        {
            MediaSet = db.Set<Media>();
        }

        public void Create(Media media)
        {
            this.MediaSet.Add(media);
            db.SaveChanges();
        }

        public void Remove(Guid id)
        {
            Media media = MediaSet.Find(id);
            if (media != null)
            {
                MediaSet.Remove(media);
                this.Save();
            }
        }

        public async Task<IEnumerable<Media>> SelectAll()
        {
            return await MediaSet.ToArrayAsync();

        }

        public async Task<Media> Select(Guid id)
        {
            return MediaSet.Find(id);
        }

        public void Update(Media media)
        {
            Media ExisitingMedia = MediaSet.Find(media.id);
            MediaSet.Update(media);
            this.Save();
        }
    }
}
