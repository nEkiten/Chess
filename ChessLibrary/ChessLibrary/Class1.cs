namespace ChessLibrary
{
    public class Chess
    {
        string fen;

        public Chess(string fen = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1")
        {
            this.fen = fen;
        }

        public Chess Move(string move) //Будет содержать наименование двигаемой фигуры и ее начальное, конечное положение
        {
            Chess nextChess = new Chess(fen);
            return nextChess;
        }

        public char GetFigureAt (int x, int y)
        {
            return '.';
        }


    }
}