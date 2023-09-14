using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        Console.Write("Введите начальную директорию для сканирования: ");
        string startDirectory = Console.ReadLine();

        Console.Write("Введите путь к файлу-образцу для вычисления его сигнатуры: ");
        string sampleFilePath = Console.ReadLine();

        string signature = GetSignature(sampleFilePath);
        Console.WriteLine($"Полученная сигнатура файла: {signature}");

        if (signature != string.Empty)
        {
            List<string> foundFiles = FindFilesWithSignature(startDirectory, signature);

            if (foundFiles.Count > 0)
            {
                Console.WriteLine("Найденные файлы с заданной сигнатурой:");
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
                byte[] hashBytes = sha256.ComputeHash(fileStream);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ошибка при вычислении сигнатуры файла: {e.Message}");
            return null;
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

            foreach (string subdirectory in Directory.GetDirectories(directory))
                foundFiles.AddRange(FindFilesWithSignature(subdirectory, signature));
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ошибка при сканировании каталога {directory}: {e.Message}");
        }
        return foundFiles;
    }
}