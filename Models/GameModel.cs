using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace server.Models;

public class GameModel
{
    [Key]
    public Guid Id {get;set;}
    public Guid Player1{get;set;}
    public Guid Player2{get;set;}
    public Guid CurrentPlayer{get;set;}
    public BoardModel Board {get;set;}
    public Tilebag Letterbag {get;set;}
    public int Player1Score{get;set;}
    public int Player2Score{get;set;}
    public List<Tile> Player1Tiles{get;set;}
    public List<Tile> Player2Tiles{get;set;}
}