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
<<<<<<< HEAD

    public class MediaRepository : BaseRepository
    {
        DbSet<Media> MediaSet;

        public MediaRepository(PainTrackerPTContext db) : base(db)
        {
            MediaSet = db.Set<Media>();
=======
    public class MediaRepository : BaseRepository
    {
        private DbSet<Media> _mediaSet;

        public MediaRepository(PainTrackerPTContext db) : base(db)
        {
            _mediaSet = db.Set<Media>();
>>>>>>> 6cffa594ce4f0cbe2ec4cfbca324ebf850db754f
        }

        public void Create(Media media)
        {
<<<<<<< HEAD
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
=======
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
>>>>>>> 6cffa594ce4f0cbe2ec4cfbca324ebf850db754f
        }

        public void Update(Media media)
        {
<<<<<<< HEAD
            Media ExisitingMedia = MediaSet.Find(media.id);
            MediaSet.Update(media);
=======
            Media existingMedia = _mediaSet.Find(media.id);
            _mediaSet.Update(media);
>>>>>>> 6cffa594ce4f0cbe2ec4cfbca324ebf850db754f
            this.Save();
        }
    }
}
