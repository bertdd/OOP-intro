using opslag;
using System.Text.Json;

var track1 = new MusicTrack
{
  Artist = "DJ Bert",
  Title = "Beats by Bert"
};

var track2 = new MusicTrack
{
  Artist = "Bob Dylan",
  Title = "Hurricane"
};

var track3 = new MusicTrack
{
  Artist = "Bob Marley",
  Title = "Jamming"
};

var tracklist = new List<MusicTrack>
{
  track1,
  track2,
  track3
};

foreach (var track in tracklist)
{
  Console.WriteLine($"{track.Artist} {track.Title}");
}

var listInJson = JsonSerializer.Serialize( tracklist );
File.WriteAllText("music.json", listInJson );
