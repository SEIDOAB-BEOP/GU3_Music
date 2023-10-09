using System;
using System.Collections.Generic;
using Helpers;

namespace Music
{
    public interface IAlbum
    {
        /// <summary>
        /// Name of the Album
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Year when the Album was released to the market
        /// </summary>
        public int ReleaseYear { get; set; }

        /// <summary>
        /// Seeds an IAlbum with random property values
        /// </summary>
        /// <param name="rnd"></param>
        /// <returns>a reference to the instance implementing IAlbum (this)</returns>
        public IAlbum Seed(csSeedGenerator rnd);

        /// <summary>
        /// Presents a string representation of the instance implementing IAlbum.
        /// NOTE: Use override
        /// </summary>
        /// <returns></returns>
        public string ToString();
    }
}

