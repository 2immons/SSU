namespace Queens
{
    public class Queen
    {
        private static int boardSize = 8;
        private static int solutionsCount = 0;
        private static int checkingsCount = 0;
        private static List<string> solutions = new();
        private static int[,] board = new int[boardSize, boardSize];

        // установка ферзя в клетку с координатами i, j
        // i - строки
        // j - столбцы
        public static void PlaceQueenAndPaintFields(int i, int j)
        {
            // увеличиваем счетчик количества проверок
            checkingsCount++;

            // цикл по горизонтали с индексом i
            for (int x = 0; x < boardSize; x++)
            {
                // прибавляем +1 к клеткам доски, находящимся с клеткой [i,j] на одной горизонтали, вертикали или диагонали

                board[x, j]++;
                board[i, x]++;

                // проверяем на выход за границу массива
                int diag1 = i - j + x;
                if (0 <= diag1 && diag1 < boardSize)
                    board[diag1, x]++;

                int diag2 = i + j - x;
                if (0 <= diag2 && diag2 < boardSize)
                    board[diag2, x]++;
            }

            // установка ферзя
            board[i, j] = -1;
        }

        // удаление ферзя из клетки с координатами i, j
        public static void RemoveQueen(int i, int j)
        {
            for (int x = 0; x < boardSize; x++)
            {
                // отнимаем -1 от клеток доски, которые находились на одной горизонтали, вертикали или диагонали с ферзем,
                // который был удален из клетки [i,j]

                board[x, j]--;
                board[i, x]--;

                int diag1 = i - j + x;
                if (0 <= diag1 && diag1 < boardSize)
                    board[diag1, x]--;

                int diag2 = i + j - x;
                if (0 <= diag2 && diag2 < boardSize)
                    board[diag2, x]--;
            }

            // даем клетке значение 0, т.к. ранее мы ставили ферзя только в пустую клетку
            board[i, j] = 0;
        }

        public static void AddSolution()
        {
            string currentSolution = string.Empty;
            for (int i = 0; i < boardSize; i++)
                for (int k = 0; k < boardSize; k++)
                    if (board[i, k] == -1)
                        currentSolution += $"{i + 1}-{k + 1} ";
            solutions.Add(currentSolution);
            solutionsCount++;
        }

        public static void PrintSolutions()
        {
            foreach (var item in solutions)
                Console.WriteLine(item);
        }

        // пытается найти свободное место в i горизонтали (не под боем), если не удается - вызывает саму себя для следующей строки i+1 (т.к. идем вверх по доске)
        public static void Solve(int i)
        {
            for (int j = 0; j < boardSize; j++)

                // если клетка не "под боем"
                if (board[i, j] == 0)
                {
                    PlaceQueenAndPaintFields(i, j);

                    // если мы в последней строке, печатаем текущую расстановку ферзей на доске
                    if (i == boardSize - 1)
                        AddSolution();

                    // если не в последней, то идем дальше вверх по доске, вызываем функцию эту же функцию с i+1
                    else
                        Solve(i + 1);

                    RemoveQueen(i, j);
                }
        }

        public static void Main()
        {
            Solve(0);
            PrintSolutions();

            Console.WriteLine($"\nПервое число - вертикаль (буква на доске), второе - горизонталь (цифра на доске)");
            Console.WriteLine("Ответ 1-8 <=> Клетка a8");
            Console.WriteLine($"\nВсего решений: {solutionsCount}");
            Console.WriteLine($"Всего вариантов проверено: {checkingsCount}");
        }
    }
}