using System;
using System.ComponentModel.DataAnnotations;

namespace server.Models;

public class Tile
{
    [Key]
    public Guid TileID {get;set;}
    public char Letter {get;set;}
    public int Value {get;set;}

    public Tile(char letter, int value)
    {
        Letter = letter;
        Value = value;
    }
}