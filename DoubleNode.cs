namespace Lab3_40
{
    internal class DoubleNode
    {
        private DoubleNode? prev;
        private DoubleNode? next;

        private int trainNumber;
        private string stationName = "";
        private string depatureTime = "";

        public int TrainNumber
        {
            get { return trainNumber; }
            set { trainNumber = value; }
        }

        public string StationName
        {
            get { return stationName; }
            set { stationName = value; }
        }

        public string DepatureTime
        {
            get { return depatureTime; }
            set { depatureTime = value; }
        }

        public DoubleNode? Next
        {
            get { return next; }
            set { next = value; }
        }

        public DoubleNode? Prev
        {
            get { return prev; }
            set { prev = value; }
        }

        public DoubleNode() { }

        public DoubleNode(int trainNumber, string stationName, string depatureTime)
        {
            TrainNumber = trainNumber;
            StationName = stationName;
            DepatureTime = depatureTime;
        }

        public DoubleNode(int trainNumber, string stationName, string depatureTime, DoubleNode? prev, DoubleNode? next)
        {
            TrainNumber = trainNumber;
            StationName = stationName;
            DepatureTime = depatureTime;

            Prev = prev;
            Next = next;
        }
    }
}
