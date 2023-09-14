using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        // Получаем все текущие процессы
        Process[] processes = Process.GetProcesses();

        Console.WriteLine("Все процессы:");
        Console.WriteLine("==============");

        // Выводим PID и имя всех процессов
        foreach (Process process in processes)
        {
            Console.WriteLine($"PID: {process.Id}, Имя: {process.ProcessName}");
        }

        Console.WriteLine();
        Console.WriteLine("Первые три процесса:");
        Console.WriteLine("==================");

        // Выводим первые три процесса
        for (int i = 0; i < 3; i++)
        {
            Process process = processes[i];
            Console.WriteLine($"PID: {process.Id}, Имя: {process.ProcessName}");
        }
    }
}
