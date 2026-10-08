using System.ComponentModel.DataAnnotations;
using System.Data;

class Song
{
    public string Title{get;private set;}
    public string Author{get;private set;}
    public int Year{get;private set;}
    public double Length{get;private set;}
}
class Logyc
{    
    public List<Song> songs = new List<Song>();
    public List<Song> album = new List<Song>();

    public bool IsValid(Song song)
    {
        int maxCharTitle = song.Title.Length;
        int maxCharAuthor = song.Author.Length;
        if (maxCharTitle > 100)
        {
            return false;
        }
        else if(maxCharAuthor > 100)
        {
            return false;
        }
        else if (song.Year < 0)
        {
            return false;
        }
        else if (song.Length < 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public double GetLength(Song song)
    {
       return song.Length;
    }
    public string GetArtist(string title)
    {
        foreach (var s in songs)
        {
            if(s.Title == title)
            {
                return s.Author;
            }
        }
        return "";
    }
    public string FindSong(string author)
    {
        foreach(var s in songs)
        {
            if(s.Author == author)
            {
                return s.Author;
            }
        }
        return "";
    }
}