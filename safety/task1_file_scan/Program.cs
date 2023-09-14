using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        Console.Write("Начальная директория для сканирования: ");
        string directory = Console.ReadLine();

        Console.Write("Путь к файлу-образцу: ");
        string sampleFilePath = Console.ReadLine();

        string signature = GetSignature(sampleFilePath);
        Console.WriteLine($"Вычисленная сигнатура файла: {signature}");
        Console.WriteLine();

        if (signature != string.Empty)
        {
            List<string> foundFiles = FindFilesWithSignature(directory, signature);

            if (foundFiles.Count > 0)
            {
                Console.WriteLine($"Детектированные файлы ({foundFiles.Count} шт):");
                foreach (string file in foundFiles)
                    Console.WriteLine(file);
            }
            else
                Console.WriteLine("Файлы с заданной сигнатурой не найдены.");
        }
        else
            Console.WriteLine("Не удалось вычислить сигнатуру файла-образца.");
        Console.ReadLine();
    }

    static string GetSignature(string filePath)
    {
        try
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hash = sha256.ComputeHash(fileStream);
                string signature = BitConverter.ToString(hash); //.Replace("-", "").ToLower();
                return signature;
            }
        }
        catch (Exception error)
        {
            Console.WriteLine($"Ошибка при вычислении сигнатуры файла: {error.Message}");
            return string.Empty;
        }
    }

    static List<string> FindFilesWithSignature(string directory, string signature)
    {
        List<string> foundFiles = new List<string>();

        try
        {
            foreach (string file in Directory.GetFiles(directory))
            {
                string fileSignature = GetSignature(file);
                if (fileSignature == signature)
                    foundFiles.Add(file);
            }

            foreach (string dir in Directory.GetDirectories(directory))
                foundFiles.AddRange(FindFilesWithSignature(dir, signature));
        }
        catch (Exception error)
        {
            Console.WriteLine($"Ошибка при сканировании каталога {directory}: {error.Message}");
        }
        return foundFiles;
    }
}