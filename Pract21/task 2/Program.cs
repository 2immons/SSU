namespace Pr27_Task2and3
{

    // В файле input.txt хранится последовательность целых чисел.
    // По входной последовательности построить дерево бинарного поиска и:

    // task 2
    // 8. распечатать узлы k-го уровня дерева;

    // task 3
    // 3. проверить, можно ли удалить какой-то один узел так,
    // чтобы дерево осталось деревом бинарного поиска и стало сбалансированным (указать удаляемый узел);

    public class BinaryTree	//класс, реализующий АТД «дерево бинарного поиска со счетчиком вершин в дереве»
    {
        //вложенный класс, отвечающий за узлы и операции допустимы для дерева бинарного
        //поиска
        private class Node
        {
            public object inf;	//информационное поле
            public int counter;
            public Node left;	//ссылка на левое поддерево
            public Node right;	//ссылка на правое поддерево

            //конструктор вложенного класса, создает узел дерева
            public Node(object nodeInf)
            {
                inf = nodeInf;
                counter = 1;
                left = null;
                right = null;
            }

            //добавляет узел в дерево так, чтобы дерево оставалось деревом бинарного поиска
            public static void Add(ref Node r, object nodeInf)
            {
                if (r == null)
                {
                    r = new Node(nodeInf);
                }
                else
                {
                    r.counter++;
                    if (((IComparable)(r.inf)).CompareTo(nodeInf) > 0)
                    {
                        Add(ref r.left, nodeInf);
                    }
                    else
                    {
                        Add(ref r.right, nodeInf);
                    }
                }
            }

            public static void Preorder(Node r)	//прямой обход дерева
            {
                if (r != null)
                {
                    Console.Write("({0}, {1}) ", r.inf, r.counter);
                    Preorder(r.left);
                    Preorder(r.right);
                }
            }

            public static void Inorder(Node r)	//симметричный обход дерева
            {
                if (r != null)
                {
                    Inorder(r.left);
                    Console.Write("({0}, {1}) ", r.inf, r.counter);
                    Inorder(r.right);
                }
            }

            public static void Postorder(Node r)	//обратный обход дерева
            {
                if (r != null)
                {
                    Postorder(r.left);
                    Postorder(r.right);
                    Console.Write("({0}, {1}) ", r.inf, r.counter);
                }
            }


            public static void Part(ref Node t, int k)
            {
                int x = (t.left == null) ? 0 : t.left.counter;
                if (x > k)
                {
                    Part(ref t.left, k);
                    RotationRigth(ref t);
                    //Console.WriteLine("Ротация вправо");
                }
                if (x < k)
                {
                    Part(ref t.right, k - x - 1);
                    //Console.WriteLine("Ротация влево");
                    RotationLeft(ref t);
                }
                //if (x == k) Console.WriteLine("Выбран элемент ({0}, {1})", t.inf, t.counter); 
            }



            public static void Balancer(ref Node t)
            {
                if (t == null || t.counter == 1) return;
                Part(ref t, t.counter / 2);
                //Preorder(t);
                //Console.WriteLine();
                Balancer(ref t.left);
                Balancer(ref t.right);

            }

            //неявная балансировка дерева бинарного поиска
            public static void InsertRandom(ref Node r, object nodeInf, Random rnd)
            {
                if (r == null)
                {
                    r = new Node(nodeInf);
                }
                else
                {
                    if (rnd.Next() < int.MaxValue / (r.counter + 1))
                    {
                        InsertToRoot(ref r, nodeInf);
                    }
                    else
                    {
                        r.counter++;
                        if (((IComparable)(r.inf)).CompareTo(nodeInf) > 0)
                        {
                            InsertRandom(ref r.left, nodeInf, rnd);
                        }
                        else
                        {
                            InsertRandom(ref r.right, nodeInf, rnd);
                        }
                    }
                }
            }

            //поиск ключевого узла в дереве
            public static void Search(Node r, object key, out Node item)
            {
                if (r == null)
                {
                    item = null;
                }
                else
                {
                    if (((IComparable)(r.inf)).CompareTo(key) == 0)
                    {
                        item = r;
                    }
                    else
                    {
                        if (((IComparable)(r.inf)).CompareTo(key) > 0)
                        {
                            Search(r.left, key, out item);
                        }
                        else
                        {
                            Search(r.right, key, out item);
                        }
                    }
                }
            }

            //самоорганизующийся поиск ключевого узла в дереве
            public static void SearchToRoot(ref Node r, object key)
            {
                if (r != null)
                {
                    if (((IComparable)(r.inf)).CompareTo(key) == 0)
                    {
                        return;
                    }
                    else
                    {
                        if (((IComparable)(r.inf)).CompareTo(key) > 0)
                        {
                            SearchToRoot(ref r.left, key);
                            RotationRigth(ref r);

                        }
                        else
                        {
                            SearchToRoot(ref r.right, key);
                            RotationLeft(ref r);
                        }
                    }
                }
            }

            public static void Count(ref Node r)
            {
                r.counter = 1;
                if (r.left != null) r.counter += r.left.counter;
                if (r.right != null) r.counter += r.right.counter;
            }

            public static void RotationRigth(ref Node t)
            {
                Node x = t.left;
                t.left = x.right;
                x.right = t;

                Count(ref t);
                Count(ref x);

                t = x;


            }

            public static void RotationLeft(ref Node t)
            {
                Node x = t.right;
                t.right = x.left;
                x.left = t;

                Count(ref t);
                Count(ref x);

                t = x;
            }

            public static void InsertToRoot(ref Node t, object item)
            {
                if (t == null)
                {
                    t = new Node(item);
                }
                else
                {
                    t.counter++;
                    if (((IComparable)(t.inf)).CompareTo(item) > 0)
                    {
                        InsertToRoot(ref t.left, item);
                        RotationRigth(ref t);
                    }
                    else
                    {
                        InsertToRoot(ref t.right, item);
                        RotationLeft(ref t);
                    }
                }
            }

            // task 2:
            public static void PrintLevel(Node t, int n, int level)
            {
                if (level == n)
                {
                    Console.Write($"{t.inf}({n}) ");
                    return;
                }
                else
                {
                    n++;
                    if (t.left != null)
                        PrintLevel(t.left, n, level);
                    if (t.right != null)
                        PrintLevel(t.right, n, level);
                }
            }

            // task 3:


        }
        Node tree;		//ссылка на корень дерева

        //свойство позволяет получить доступ к значению информационного поля корня дерева 
        public object Inf
        {
            set { tree.inf = value; }
            get { return tree.inf; }
        }

        public int Counter { get { return tree.counter; } }


        public BinaryTree() => tree = null;

        private BinaryTree(Node r) => tree = r;

        public void Add(object nodeInf) => Node.Add(ref tree, nodeInf);
        public void Preorder() => Node.Preorder(tree);
        public void Inorder() => Node.Inorder(tree);
        public void Postorder() => Node.Postorder(tree);
        public BinaryTree Search(object key)
        {
            Node r;
            Node.Search(tree, key, out r);
            BinaryTree t = new BinaryTree(r);
            return t;
        }
        public void SearchToRoot(object key) => Node.SearchToRoot(ref tree, key);
        public void InsertToRoot(object item) => Node.InsertToRoot(ref tree, item);
        public void Balancer() => Node.Balancer(ref tree);
        public void InsertRandom(object nodeInf)
        {
            Random rnd = new Random();
            Node.InsertRandom(ref tree, nodeInf, rnd);
        }

        // task 2:
        public void PrintLevel(int level) => Node.PrintLevel(tree, 1, level);

        // task 3:

    }


    public class ConsoleDemonstration
    {
        static void Main()
        {
            BinaryTree tree = new();
            using StreamReader sr = new(@"d:\input.txt");

            /*

            32
            15
            20
            -10
            28
            -5
            15
            23
            55
            65
            70
            72
            29
            68

            */

            while (!sr.EndOfStream)
                tree.Add(int.Parse(sr.ReadLine()));
            sr.Close();

            int level = int.Parse(Console.ReadLine());

            Console.WriteLine();

            while (level > 0)
            {
                tree.PrintLevel(level);
                Console.WriteLine();
                level = int.Parse(Console.ReadLine());
            }


        }
    }
}