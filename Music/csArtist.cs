using System;
using System.Collections.Generic;
using Seido.Utilities.SeedGenerator;

namespace Music
{
    public interface IArtist
    {
        /// <summary>
        /// Firstname of the Artist
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Lastname of the Artist
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Seeds an IArtist instance with random property values
        /// </summary>
        /// <param name="rnd"></param>
        /// <returns>a reference to the instance implementing IAlbum (this)</returns>
        public IArtist Seed(csSeedGenerator rnd);

        /// <summary>
        /// Presents a string representation of the instance implementing IArtist.
        /// NOTE: Use override
        /// </summary>
        /// <returns></returns>
        public string ToString();
    }

    public class csArtist : IArtist
    {
        public string FirstName { get ; set; }
        public string LastName { get; set ; }

        public IArtist Seed(csSeedGenerator rnd)
        {
            throw new NotImplementedException();
        }
    }
}

