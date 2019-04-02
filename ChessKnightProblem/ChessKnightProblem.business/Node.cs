namespace ChessKnightProblem.business
{
    class Node
    {
        private Coordinate _coordinate;
        private Node _father;
        private Node _son;
        private Node _brother;
        public Coordinate Coordinate
        {
            get { return _coordinate; }
            set { _coordinate = value; }
        }
        public Node Son
        {
            get { return _son; }
            set { _son = value; }
        }
        public Node Brother
        {
            get { return _brother; }
            set { _brother = value; }
        }
        public Node Father
        {
            get { return _father; }
            set { _father = value; }
        }
        public Node(Coordinate coordinate, Node father)
        {
            _coordinate = coordinate;
            _son = null;
            _brother = null;
            _father = father;
        }
    }
}
