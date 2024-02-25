using System;
using System.Runtime.Serialization;

namespace server.Models;
public class Tilebag
{
    public List<Tile> AvailableTiles;
    public List<Tile> UsedTiles;

    public Tilebag()
    {
       AvailableTiles = new List<Tile>();
       UsedTiles = new List<Tile>();
    }

    public void Init(string tileDefinitions)
    {
        StreamReader infile = new StreamReader(tileDefinitions);
        string line = string.Empty;
        while ((line = infile.ReadLine()) != null)
        {
            string [] sp = line.Split(',');
            int count = Convert.ToInt32(sp[1]);
            for (int i = 0; i < count; i++)
            {
            AvailableTiles.Add
            (
                new Tile
                (
                    sp[0][0], 
                    Convert.ToInt32(sp[1])
                )
            );
            }
        }
        infile.Close();
    }
}