using System.IO;

public class Journal
{
    public List<Entry> _entries;

    public void AddEntry(Entry newEntry)
    {

    }
    public void DisplayAll()
    {

    }
    public void SaveToFile(string file)
    {
        /*string file = "entries.txt";

        using(StreamWriter outputFile = new StreamWriter(file))
        {
            foreach ( Entry e in entries)
            {
                outputFile.WriteLine(e._entries);
            }
        }*/
    }
    public void LoadFromFile(string file)
    {

    }

}
