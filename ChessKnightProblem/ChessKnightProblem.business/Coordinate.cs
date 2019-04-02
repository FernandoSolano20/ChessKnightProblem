namespace ChessKnightProblem.business
{
    public class Coordinate
    {
        private int _positionX;
        private int _positionY;
        private int _distanceSource;
        public int DistanceSource
        {
            get { return _distanceSource; }
            set { _distanceSource = value; }
        }
        public int PositionX
        {
            get { return _positionX; }
            set { _positionX = value; }
        }
        public int PositionY
        {
            get { return _positionY; }
            set { _positionY = value; }
        }

        public Coordinate ConvertNumberToCoordinates(int number)
        {
            int counter = 0;
            for (int index1 = 0; index1 < 8; index1++)
            {
                for (int index2 = 0; index2 < 8; index2++)
                {
                    if (number == counter)
                    {
                        PositionX = index1;
                        PositionY = index2;
                    }
                    counter++;
                }
            }
            return this;
        }
    }
}
