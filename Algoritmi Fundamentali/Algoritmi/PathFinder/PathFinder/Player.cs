namespace PathFinder
{
    public static class Player
    {
        // pozitia curenta a jucatorului si pozitia destinatiei
        public static Point position, destinationPosition;
        public static Image image = Image.FromFile("../../../Resources/player.png"); // imaginea jucatorului
        public static Form1 form;
        public static PictureBox destination; // picturebox-ul care reprezinta destinatia jucatorului
        // calea reprezentata prin mai multe puncte, pe care trebuie sa o faca jucatorul pentru a ajunge la destinatie
        public static List<Point> path;

        public static void Init(Form1 f)
        {
            form = f;
            path = new List<Point>();
            // apelam metoda pentru a adauga imaginea pe pozitia curenta a jucatorului (pozitia 0, 0)
            ChangePosition(position);
        }

        public static void ChangePosition(Point newPosition)
        {
            // intai, stergem imaginea de pe pozitia curenta
            form.display[position.Y, position.X].pictureBox.Image = null;
            // apoi o adaugam pe noua pozitie
            form.display[newPosition.Y, newPosition.X].pictureBox.Image = image;
            position = newPosition;
        }
        public static void ChangeDestination(MapTile newDestination)
        {
            // sa nu uitam sa stergem culoarea aurie de fundal a destinatiei curente
            if (destination != null)
                destination.BackColor = Color.ForestGreen;

            // si apoi o adaugam la destinatia noua
            newDestination.pictureBox.BackColor = Color.Gold;
            destinationPosition = new Point(newDestination.column, newDestination.line);
            destination = newDestination.pictureBox;

            // reinitializam matricea pentru a incepe din nou de la 0
            // ca apoi sa putem apela din nou algoritmul lui Lee si acesta sa functioneze
            form.InitializeMatrixWithWalls();
            FindPathLee();
        }

        public static void GoToDestination()
        {
            // daca nu avem niciun punct la care trebuie sa mergem, inseamna ca am ajuns la destinatie
            if (path.Count == 0)
                return;
            // luam urmatorul punct din lista, il stergem din lista, si schimbam pozitia jucatorului la acel punct
            Point nextPosition = path[0];
            path.RemoveAt(0);
            ChangePosition(nextPosition);
        }

        public static void FindPathLee()
        {
            form.InitializeMatrixWithWalls();
            path = new List<Point>();
            MapTile start = new MapTile(position.Y, position.X, 1);
            form.matrix[start.line, start.column] = start.value;

            Queue<MapTile> queue = new Queue<MapTile>();
            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                MapTile current = queue.Dequeue();

                if (current.line - 1 >= 0 && form.matrix[current.line - 1, current.column] == 0) // sus
                {
                    MapTile next = new MapTile(current.line - 1, current.column, current.value + 1);
                    form.matrix[next.line, next.column] = next.value;
                    queue.Enqueue(next);
                }
                if (current.column - 1 >= 0 && form.matrix[current.line, current.column - 1] == 0) // stanga
                {
                    MapTile next = new MapTile(current.line, current.column - 1, current.value + 1);
                    form.matrix[next.line, next.column] = next.value;
                    queue.Enqueue(next);
                }
                if (current.line + 1 < form.n && form.matrix[current.line + 1, current.column] == 0) // jos
                {
                    MapTile next = new MapTile(current.line + 1, current.column, current.value + 1);
                    form.matrix[next.line, next.column] = next.value;
                    queue.Enqueue(next);
                }
                if (current.column + 1 < form.m && form.matrix[current.line, current.column + 1] == 0) // dreapta
                {
                    MapTile next = new MapTile(current.line, current.column + 1, current.value + 1);
                    form.matrix[next.line, next.column] = next.value;
                    queue.Enqueue(next);
                }
            }

            int value = form.matrix[destinationPosition.Y, destinationPosition.X];
            if (value == 0)
            {
                return;
            }

            Point point = destinationPosition;
            path.Add(destinationPosition);

            while (value > 1)
            {
                if (point.Y - 1 >= 0 && form.matrix[point.Y - 1, point.X] == value - 1) // sus
                {
                    point = new Point(point.X, point.Y - 1);
                }
                else if (point.X - 1 >= 0 && form.matrix[point.Y, point.X - 1] == value - 1) // stanga
                {
                    point = new Point(point.X - 1, point.Y);
                }
                else if (point.Y + 1 < form.n && form.matrix[point.Y + 1, point.X] == value - 1) // jos
                {
                    point = new Point(point.X, point.Y + 1);
                }
                else if (point.X + 1 < form.m && form.matrix[point.Y, point.X + 1] == value - 1) // dreapta
                {
                    point = new Point(point.X + 1, point.Y);
                }
                value--;
                path.Add(point);
            }
            path.Reverse();
        }
    }
}
