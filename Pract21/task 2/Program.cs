namespace Pr27_Task2
{
    // В файле input.txt хранится последовательность целых чисел.
    // По входной последовательности построить дерево бинарного поиска и:

    // 8. распечатать узлы k-го уровня дерева;

    public class BinaryTree
    {
        //вложенный класс, отвечающий за узлы и операции допустимы для дерева бинарного поиска
        public class Node
        {
            public object inf; //информационное поле
            public Node left; //ссылка на левое поддерево
            public Node right; //ссылка на правое поддерево

            //конструктор вложенного класса, создает узел дерева
            public Node(object nodeInf)
            {
                inf = nodeInf;
                left = null;
                right = null;
            }

            //добавляет узел в дерево так, чтобы дерево оставалось деревом бинарного поиска
            public static void Add(ref Node r, object nodeInf)
            {
                if (r == null)
                    r = new Node(nodeInf);
                else
                {
                    if (((IComparable)(r.inf)).CompareTo(nodeInf) > 0)
                        Add(ref r.left, nodeInf);
                    else
                        Add(ref r.right, nodeInf);
                }
            }
            public static void PreOrderWrite(Node r) //прямой обход дерева
            {
                if (r != null)
                {
                    Console.Write($"{r.inf} ");
                    PreOrderWrite(r.left);
                    PreOrderWrite(r.right);
                }
            }
            public static void InOrderWrite(Node r) //симметричный обход дерева (по возрастанию)
            {
                if (r != null)
                {
                    InOrderWrite(r.left);
                    Console.Write($"{r.inf} ");
                    InOrderWrite(r.right);
                }
            }
            public static void PostOrderWrite(Node r) //обратный обход дерева
            {
                if (r != null)
                {
                    PostOrderWrite(r.left);
                    PostOrderWrite(r.right);
                    Console.Write($"{r.inf} ");
                }
            }
            public static void PrintTreeLevel(Node r, int level)
            {
                if (r != null)
                {
                    if (Height(r) == level)
                        Console.Write($"{r.inf} ");
                    PreOrderWrite(r.left);
                    PreOrderWrite(r.right);
                }

            }

            public static int Height(Node r)
            {
                if (r == null) 
                    return 0;
                //находим высоту правой и левой ветки, и из них берем максимальную
                return 1 + Math.Max(Height(r.left), Height(r.right));
            }

            public static object GetMinValue(Node r)
            {
                if (r.left != null)
                    return GetMinValue(r.left);
                else
                    return r.inf;
            }

            //поиск ключевого узла в дереве
            public static void Search(Node r, object key, out Node item)
            {
                if (r == null)
                    item = null;
                else
                    if (((IComparable)(r.inf)).CompareTo(key) == 0)
                    item = r;
                else
                {
                    if (((IComparable)(r.inf)).CompareTo(key) > 0)
                        Search(r.left, key, out item);
                    else
                        Search(r.right, key, out item);
                }
            }

            //методы Del и Delete позволяют удалить узел в дереве так, чтобы дерево при этом
            //оставалось деревом бинарного поиска
            private static void Del(Node t, ref Node tr)
            {
                if (tr.right != null)
                    Del(t, ref tr.right);
                else
                {
                    t.inf = tr.inf;
                    tr = tr.left;
                }
            }
            public static void Delete(ref Node t, object key)
            {
                if (t == null)
                    throw new Exception("Данное значение в дереве отсутствует");
                else
                {
                    if (((IComparable)(t.inf)).CompareTo(key) > 0)
                    {
                        Delete(ref t.left, key);
                    }
                    else
                    {
                        if (((IComparable)(t.inf)).CompareTo(key) < 0)
                        {
                            Delete(ref t.right, key);
                        }
                        else
                        {
                            if (t.left == null)
                            {
                                t = t.right;
                            }
                            else
                            {
                                if (t.right == null)
                                {
                                    t = t.left;
                                }
                                else
                                {
                                    Del(t, ref t.left);
                                }
                            }
                        }
                    }
                }
            }
        }
        //конец вложенного класса

        Node tree; //ссылка на корень дерева
                   //свойство позволяет получить доступ к значению информационного поля корня дерева
        public object Inf
        {
            set { tree.inf = value; }
            get { return tree.inf; }
        }
        public BinaryTree() //открытый конструктор
        {
            tree = null;
        }
        private BinaryTree(Node r) //закрытый конструктор
        {
            tree = r;
        }
        public void Add(object nodeInf) => Node.Add(ref tree, nodeInf); //добавление узла в дерево
        public void Delete(object key) => Node.Delete(ref tree, key); //удаление ключевого узла в дереве

        //организация различных способов обхода дерева
        public void PreOrderWrite() => Node.PreOrderWrite(tree);
        public void InOrderWrite() => Node.InOrderWrite(tree);
        public void PostOrderWrite() => Node.PostOrderWrite(tree);

        //поиск ключевого узла в дереве
        public BinaryTree Search(object key)
        {
            Node.Search(tree, key, out Node r);
            return new BinaryTree(r);
        }

        // поиск минимального значения
        public object GetMinValue() => Node.GetMinValue(tree);
        public void PrintTreeLevel(int level) => Node.PrintTreeLevel(tree, level);
    }

    public class ConsoleDemonstration
    {
        static void Main()
        {
            BinaryTree tree = new();
            using StreamReader sr = new(@"D:\GitHub\SSU\Pract21\task1\bin\Debug\net6.0\input.txt");
            
            /*
            
            9
            5
            1
            10
            -2
            3
            6
            8
            -8
            -1

            */

            while (!sr.EndOfStream)
                tree.Add(int.Parse(sr.ReadLine()));

            sr.Close();
            tree.InOrderWrite();
            int level = 1;
            Console.WriteLine("\nAnswer:");
            tree.PrintTreeLevel(level);
        }
    }
}
