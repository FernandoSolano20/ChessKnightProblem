namespace ChessKnightProblem.business
{
    public class Horse
    {
        Coordinate sourcePosition = new Coordinate();
        Coordinate instance;
        public Coordinate Coordinate
        {
            get
            {
                instance = new Coordinate();
                return instance;
            }
        }

        public int Answer(int src, int dest)
        {
            if (src >= 0 && src <= 63 && dest >= 0 && dest <= 63)
            {
                var sourceCoordinate = Coordinate;
                sourceCoordinate.DistanceSource = 0;
                sourceCoordinate.ConvertNumberToCoordinates(src);

                var destinationCoordinate = Coordinate;
                destinationCoordinate.DistanceSource = 0;
                destinationCoordinate.ConvertNumberToCoordinates(dest);

                var tree = new Tree(sourceCoordinate, destinationCoordinate);
                return tree.MinMoves();
            }
            System.Console.WriteLine("Opcion no valida");
            return 0;
        }
    }
}
