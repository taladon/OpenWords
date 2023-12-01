namespace server.Models;

public class GameModel
{
    public Guid Id;
    public Guid Player1;
    public Guid Player2;
    public Guid CurrentPlayer;
    public BoardModel Board;
}