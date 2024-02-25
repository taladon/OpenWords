using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
namespace server.Models
{
    //wwf2 board is 15 x 15
    public class BoardModel
    {
        [Key]
        public Guid BoardID {get;set;}
        [NotMapped]
        public BoardCell[,] Board {get;set;}
        public string BoardJson{get;set;}

        void InitBoard()
        {
            Board = new BoardCell[15,15];
            string line = string.Empty;
            StreamReader infile = new StreamReader("board.cfg");
            int col = 0;
            while ((line = infile.ReadLine()) != null)
            {
                var sp = line.Split(',');
                for (int i = 0; i <=15; i++)
                {
                    Board[col,i].Multiplier = (MULT_TYPE)Convert.ToInt16(sp[i]);
                }
                col +=1;
            }
            infile.Close();
        }
        public BoardModel()
        {
             InitBoard();
        }
    }
}