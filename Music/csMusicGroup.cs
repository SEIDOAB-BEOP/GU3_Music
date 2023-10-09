using System;
using System.Collections.Generic;

using Helpers;

namespace Music
{
    public interface IMusicGroup
    {
        /// <summary>
        /// Name of the MusicGroup
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Year when the MusicGroup was formed and started playing together
        /// </summary>
        public int EstablishedYear { get; set; }

        /// <summary>
        /// A list of Members in the MusicGroup
        /// </summary>
        public List<IArtist> Members { get; set; }

        /// <summary>
        /// A list of Albums the MusicGroup has released
        /// </summary>
        public List<IAlbum> Albums { get; set; }

        /// <summary>
        /// Seeds IMusicGroup Name and EstablishedYear with random values
        /// NOTE: Members and Albums are NOT seeded
        /// </summary>
        /// <param name="rnd"></param>
        /// <returns>a reference to the instance implementing IAlbum (this)</returns>
        public IMusicGroup Seed(csSeedGenerator rnd);

        /// <summary>
        /// Presents a string representation of the instance implementing IMusicGroup.
        /// NOTE: Use override
        /// </summary>
        /// <returns></returns>
        public string ToString();
    }
}

