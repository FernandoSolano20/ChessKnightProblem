using System.Collections.Generic;
using System.Linq;

namespace ChessKnightProblem.business
{
    class Tree
    {
        private Node _destinationCoordiante;
        private List<Node> _treeNodes = new List<Node>();
        Position position;
        Coordinate dest;
        public Tree(Coordinate source, Coordinate destination)
        {
            position = new Position();
            var _root = new Node(source, null);
            _destinationCoordiante = new Node(destination, null);
            dest = _destinationCoordiante.Coordinate;
            InsertNodeQueue(_root);
        }
        public int MinMoves()
        {
            int[] operationsX = { 2, 2, -2, -2, 1, 1, -1, -1 };
            int[] operationsY = { -1, 1, 1, -1, 2, -2, 2, -2 };
            while (position.positionQueue.Any())
            {
                var nodeQueue = position.positionQueue.Dequeue();
                _treeNodes.Add(nodeQueue);
                var positions = nodeQueue.Coordinate;
                if (positions.PositionX != dest.PositionX || positions.PositionY != dest.PositionY)
                {
                    for (int index = 0; index < 8; index++)
                    {
                        int x = positions.PositionX + operationsX[index];
                        int y = positions.PositionY + operationsY[index];
                        if (ValideCoordinate(x, y) && IsVisted(x, y))
                        {
                            CreateCordinate(x, y, positions, nodeQueue);
                        }
                    }
                }
                else
                {
                    return positions.DistanceSource;
                }
            }
            return 0;
        }
        private void CreateCordinate(int posX, int posY, Coordinate positions, Node nodeQueue)
        {
            var coordinateSon = new Coordinate
            {
                PositionX = posX,
                PositionY = posY,
                DistanceSource = positions.DistanceSource + 1
            };
            var node = InsertNode(coordinateSon, nodeQueue);
            InsertNodeQueue(node);
        }
        private void InsertNodeQueue(Node node)
        {
            position.positionQueue.Enqueue(node);
        }
        private Node InsertNode(Coordinate pData, Node pNode)
        {
            Node _work;
            if (pNode.Son == null)
            {
                var temporalNode = new Node(pData, pNode);
                pNode.Son = temporalNode;
                return temporalNode;
            }
            else
            {
                _work = pNode.Son;
                while (_work.Brother != null)
                {
                    _work = _work.Brother;
                }
                var temporalNode = new Node(pData, pNode);
                _work.Brother = temporalNode;
                return temporalNode;
            }
        }
        private bool IsVisted(int x, int y)
        {
            foreach (Node node in _treeNodes)
            {
                var coor = node.Coordinate;
                if (coor.PositionX == x && coor.PositionY == y)
                {
                    return false;
                }
            }
            return true;
        }
        private bool ValideCoordinate(int x, int y)
        {
            if (x >= 0 && x < 8 && y >= 0 && y < 8)
            {
                return true;
            }
            return false;
        }
    }
}
