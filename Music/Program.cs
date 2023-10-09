using Helpers;
namespace Music;
class Program
{
    static void Main(string[] args)
    {
        var rnd = new csSeedGenerator();

        var _greatMusicBands = new List<IMusicGroup>();
        var _greatMusicArtists = new List<IArtist>();
        var _greatMusicAlbums = new List<IAlbum>();

        #region Seed a list of 5 MusicGroups, 20 Artists, 20 Albums
        #endregion

        PresentMusicBands(_greatMusicBands);
        PresentMusicArtists(_greatMusicArtists);
        PresentMusicAlbums(_greatMusicAlbums);

        Console.ReadKey();
    }

    private static void PresentMusicAlbums(List<IAlbum> _greatMusicAlbums)
    {
        Console.WriteLine("\nGreat Music Albums");
        foreach (var item in _greatMusicAlbums)
        {
            Console.WriteLine(item);
        }
    }

    private static void PresentMusicArtists(List<IArtist> _greatMusicArtists)
    {
        Console.WriteLine("\nGreat Music Artists");
        foreach (var item in _greatMusicArtists)
        {
            Console.WriteLine(item);
        }
    }

    private static void PresentMusicBands(List<IMusicGroup> _greatMusicBands)
    {
        Console.WriteLine("\nGreat Music Bands");
        foreach (var item in _greatMusicBands)
        {
            Console.WriteLine(item);
        }
    }
}

/* Exercises
1. Implement IMusicGroup in a class csMusicGroup
2. Implement IArtist in a class csArtist
3. Implement IArtist in a class csArtist
4. Seed a list of 5 MusicGroups, 20 Artists, 20 Albums

5. 
 */

