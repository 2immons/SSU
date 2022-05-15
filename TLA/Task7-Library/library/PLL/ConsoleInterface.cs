using System;
using System.Collections.Generic;
using System.Text;
using Library.BLL;

namespace Library.PLL
{
    public class ConsoleInterface
    {
        private const string AddBook = "ADD";
        private static readonly string[] AddBookArgs = {"NAME", "PAGECOUNT"};

        private const string GetBook = "GET";
        private static readonly string[] GetBookArgs = {"ID"};

        private const string GetBooks = "GETALL";

        private const string UpdateBook = "UPDATE";
        private static readonly string[] UpdateBookArgs = {"ID", "NEW_NAME", "NEW_PAGE_COUNT"};

        private const string DeleteBook = "DELETE";
        private static readonly string[] DeleteBookArgs = {"ID"};

        private const string Hint = "HINT";
        private const string Exit = "EXIT";

        private const string UnknownCommand = "UNKNOWN COMMAND";
        private const string WrongArgument = "Wrong argument(s)";

        private readonly IBookLogic _bookLogic;

        public ConsoleInterface(IBookLogic bookLogic)
        {
            this._bookLogic = bookLogic;
        }

        public void Start()
        {
            Console.WriteLine(GetHint());
            for (;;)
            {
                try
                {
                    Console.Write(">>> ");
                    List<String> arguments = new List<String>(Console.ReadLine().Split(" "));
                    string command = arguments[0].ToUpper();
                    arguments.RemoveAt(0);
                    switch (command)
                    {
                        case AddBook:
                            if (arguments.Count != AddBookArgs.Length)
                            {
                                Console.WriteLine(WrongArgument);
                            }
                            else
                            {
                                Console.WriteLine(_bookLogic.Create(arguments[0], Convert.ToInt32(arguments[1])));
                            }

                            break;
                        case GetBook:
                            if (arguments.Count != GetBookArgs.Length)
                            {
                                Console.WriteLine(WrongArgument);
                            }
                            else
                            {
                                Console.WriteLine(_bookLogic.Find(Convert.ToInt32(arguments[0])));
                            }

                            break;
                        case GetBooks:
                            Console.WriteLine(String.Join("\n", _bookLogic.FindAll()));
                            break;
                        case UpdateBook:
                            if (arguments.Count != UpdateBookArgs.Length)
                            {
                                Console.WriteLine(WrongArgument);
                            }
                            else
                            {
                                Console.WriteLine(_bookLogic.Update(
                                    Convert.ToInt32(arguments[0]),
                                    Convert.ToString(arguments[1]),
                                    Convert.ToInt32(arguments[2])));
                            }

                            break;
                        case DeleteBook:
                            if (arguments.Count != GetBookArgs.Length)
                            {
                                Console.WriteLine(WrongArgument);
                            }
                            else
                            {
                                Console.WriteLine(_bookLogic.Delete(Convert.ToInt32(arguments[0])));
                            }

                            break;
                        case Hint:
                            Console.WriteLine(GetHint());
                            break;
                        case Exit:
                            return;
                        default:
                            Console.WriteLine(UnknownCommand);
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private static String GetHint()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(AddBook).Append(": ").Append(String.Join(", ", AddBookArgs)).Append('\n');
            sb.Append(GetBooks).Append('\n');
            sb.Append(GetBook).Append(": ").Append(String.Join(", ", GetBookArgs)).Append('\n');
            sb.Append(UpdateBook).Append(": ").Append(String.Join(", ", UpdateBookArgs)).Append('\n');
            sb.Append(DeleteBook).Append(": ").Append(String.Join(", ", DeleteBookArgs)).Append('\n');
            ;
            sb.Append(Hint).Append('\n');
            sb.Append(Exit).Append('\n');

            return sb.ToString();
        }
    }
}