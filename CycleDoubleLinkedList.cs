namespace Lab3_40
{
    internal class CycleDoubleLinkedList
    {
        private DoubleNode? head;

        public CycleDoubleLinkedList()
        {
            head = new DoubleNode();

            head.Prev = head;
            head.Next = head;
        }

        public DoubleNode? Head
        {
            get { return head; }
        }

        public void Create(int[] trainNumbers, string[] stationNames, string[] depatureTimes) // Создание списка из массива данных
        {
            DoubleNode p;
            for (int i = 0; i < trainNumbers.Length; i++)
            {
                p = new(trainNumbers[i], stationNames[i], depatureTimes[i], head!.Prev!, head!);
                head!.Prev!.Next = p;
                head.Prev = p;
            }
        }

        public void InsertBeforeFirst(int trainNumber, string stationName, string depatureTime) // Добавляет данные в начало
        {
            if (head != null)
            {
                DoubleNode p = new(trainNumber, stationName, depatureTime, head, head.Next);
                head.Next!.Prev = p;
                head.Next = p;
            }
        }

        public void InsertAfterAll(int trainNumber, string stationName, string depatureTime) // Добавляет данные в конец
        {
            if (head != null)
            {
                DoubleNode p = new(trainNumber, stationName, depatureTime, head!.Prev!, head);
                head!.Prev!.Next = p;
                head.Prev = p;
            }
        }

        public void InsertAfter(int trainNumber, string stationName, string depatureTime, DoubleNode? p) // Добавляет данные после элемента
        {
            if (p != null && head != null)
            {
                DoubleNode q = new(trainNumber, stationName, depatureTime, p!.Next!, p);
                p!.Next!.Prev = q;
                p.Next = q;
            }
        }

        public void DeleteFirst() // Удаляет первый элемент
        {
            if (head != null)
            {
                head.Next = head.Next!.Next;
                head.Next!.Prev = head;
            }
        }

        public void DeleteLast() // Удаляет последний элемент
        {
            if (head != null)
            {
                head.Prev = head.Prev!.Prev;
                head.Prev!.Next = head;
            }
        }

        public void DeleteCurrent(ref DoubleNode? p) // Удаляет текущий элемент (без повторного использования)
        {
            if (p != null && p != head)
            {
                p.Prev!.Next = p.Next;
                p.Next!.Prev = p.Prev;

                p = null;
            }
        }

        public void Destroy() // Уничтожает содержимое списка
        {
            head = null;
        }

        public DoubleNode? Search(int trainNumber) // Поиск по номеру поезда
        {
            DoubleNode? p = null;

            if (head != null)
            {
                p = head.Next;

                while (p != head && p!.TrainNumber != trainNumber)
                {
                    p = p.Next;
                }

                if (p == head)
                {
                    p = null;
                }
            }

            return p;
        }

        public bool IsExist() // Провераяет существует ли список
        {
            return head != null;
        }

        public bool IsEmpty() // Проверяет пуст ли список
        {
            return head != null && head.Next == head;
        }

        public int GetCount() // Возвращает длинну списка
        {
            int count = -1;

            if (head != null)
            {
                count++;
                DoubleNode p = head.Next!;

                while (p != head)
                {
                    count++;
                    p = p.Next!;
                }
            }

            return count;
        }

        public int GetCount(string station) // Возвращает длинну списка только для станции "station"
        {
            int count = -1;

            if (head != null)
            {
                count++;
                DoubleNode p = head.Next!;

                while (p != head)
                {
                    if (p.StationName == station)
                    {
                        count++;
                    }
                    p = p.Next!;
                }
            }

            return count;
        }
    }
}
