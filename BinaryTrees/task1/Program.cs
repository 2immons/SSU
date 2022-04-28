using System;

namespace Task1
{
    // В файле input.txt хранится последовательность целых чисел.
    // По входной последовательности построить дерево бинарного поиска и найти для него:
    // 8. наименьшее из значений листьев;


    public class BinaryTree
    {
        //вложенный класс, отвечающий за узлы и операции допустимы для дерева бинарного поиска
        public class Node
        {
            public object inf; //информационное поле
            public Node left; //ссылка на левое поддерево
            public Node rigth; //ссылка на правое поддерево
                               
            //конструктор вложенного класса, создает узел дерева
            public Node(object nodeInf)
            {
                inf = nodeInf;
                left = null;
                rigth = null;
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
                        Add(ref r.rigth, nodeInf);
                }
            }
            public static void PreOrderWrite(Node r) //прямой обход дерева
            {
                if (r != null)
                {
                    Console.Write($"{r.inf} ");
                    PreOrderWrite(r.left);
                    PreOrderWrite(r.rigth);
                }
            }
            public static void InOrderWrite(Node r) //симметричный обход дерева (по возрастанию)
            {
                if (r != null)
                {
                    InOrderWrite(r.left);
                    Console.Write($"{r.inf} ");
                    InOrderWrite(r.rigth);
                }
            }
            public static void PostOrderWrite(Node r) //обратный обход дерева
            {
                if (r != null)
                {
                    PostOrderWrite(r.left);
                    PostOrderWrite(r.rigth);
                    Console.Write($"{r.inf} ");
                }
            }

            public static object GetMinValue(Node r)
            {
                if (r.left != null)
                    return GetMinValue(r.left);
                else
                    return r.inf;
            }

            public static void PrintTreeLevel(Node r, int level)
            {
                if (r != null)
                {
                    if (Height(r) == level)
                        Console.Write($"{r.inf} ");
                    PrintTreeLevel(r.left, level);
                    PrintTreeLevel(r.rigth, level);
                }

            }

            public static int Height(Node r)
            {
                if (r == null)
                    return 0;
                return 1 + Math.Max(Height(r.left), Height(r.rigth));
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
                        Search(r.rigth, key, out item);
                }
            }

            //методы Del и Delete позволяют удалить узел в дереве так, чтобы дерево при этом
            //оставалось деревом бинарного поиска
            private static void Del(Node t, ref Node tr)
            {
                if (tr.rigth != null)
                    Del(t, ref tr.rigth);
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
                            Delete(ref t.rigth, key);
                        }
                        else
                        {
                            if (t.left == null)
                            {
                                t = t.rigth;
                            }
                            else
                            {
                                if (t.rigth == null)
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

    /*
    
10
-5
2
-7
-34
43
56
34
2
3
7

10 -5 -9 23 -45 3 45 39 1 0 -60

string[] items = sr.ReadToEnd().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int n = int.Parse(items[0]);
        for (int i = 0; i < n; i++)
            tree.Add(items[i]);

    */

    public class ConsoleDemonstration
    {
        static void Main()
        {
            BinaryTree tree = new();
            using StreamReader sr = new(@"D:\GitHub\SSU\Pract21\task1\bin\Debug\net6.0\input.txt");

            while (!sr.EndOfStream)
                tree.Add(int.Parse(sr.ReadLine()));

            sr.Close();
            tree.InOrderWrite();
            Console.WriteLine("\nAnswer:");
            tree.PrintTreeLevel(2);
        }
    }
}