using System.ComponentModel.DataAnnotations;

namespace server.Models;

public class BoardCell
{
    [Key]
    public Guid BoardCellID {get;set;}
    public MULT_TYPE Multiplier {get;set;}
    public Tile CurentTile {get;set;}

}