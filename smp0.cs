using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

//#region ---процесс дз1---

//try
//{
//    ProcessStartInfo startInfo = new ProcessStartInfo("notepad.exe", @"C:\Users\nekro\Desktop\Text.txt");
//    using Process process = Process.Start(startInfo);

//    process.WaitForExit();

//    Console.WriteLine("Код выхода: " + process.ExitCode);
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Ошибка: {ex.Message}");
//}

//#endregion





//#region ---процесс дз2---
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Диспетчер задач - 5 самых 'прожорливых' процессов");
//        Console.WriteLine("Обновление каждые 3 секунды");
//        Console.WriteLine("Для выхода нажмите клавишу 'q'");
//        Console.WriteLine(new string('=', 60));

//        // Запускаем задачу для отслеживания нажатия клавиши
//        var cancellationTokenSource = new CancellationTokenSource();
//        var keyPressTask = Task.Run(() => WaitForQuitKey(cancellationTokenSource));

//        try
//        {
//            while (!cancellationTokenSource.Token.IsCancellationRequested)
//            {
//                DisplayTopMemoryProcesses();

//                // Ждем 3 секунды или отмены
//                Task.Delay(3000, cancellationTokenSource.Token).Wait(cancellationTokenSource.Token);
//            }
//        }
//        catch (OperationCanceledException)
//        {
//            // Ожидаемое исключение при отмене
//        }

//        Console.WriteLine("\nПрограмма завершена.");
//    }

//    static void DisplayTopMemoryProcesses()
//    {
//        try
//        {
//            // Получаем процессы, сортируем по потреблению памяти (по убыванию) и берем топ-5
//            var topProcesses = Process.GetProcesses()
//                .Where(p =>
//                {
//                    try
//                    {
//                        // Проверяем доступность информации о памяти
//                        return p.WorkingSet64 > 0;
//                    }
//                    catch
//                    {
//                        return false;
//                    }
//                })
//                .OrderByDescending(p =>
//                {
//                    try
//                    {
//                        return p.WorkingSet64;
//                    }
//                    catch
//                    {
//                        return 0L;
//                    }
//                })
//                .Take(5)
//                .ToList();

//            Console.Clear();
//            Console.WriteLine("Диспетчер задач - 5 самых 'прожорливых' процессов");
//            Console.WriteLine("Обновление каждые 3 секунды");
//            Console.WriteLine("Для выхода нажмите клавишу 'q'");
//            Console.WriteLine(new string('=', 60));
//            Console.WriteLine("{0,-8} {1,-35} {2,-15} {3}", "PID", "Имя процесса", "Память (MB)", "Память (Bytes)");
//            Console.WriteLine(new string('-', 80));

//            foreach (var process in topProcesses)
//            {
//                try
//                {
//                    long memoryBytes = process.WorkingSet64;
//                    double memoryMB = memoryBytes / (1024.0 * 1024.0);

//                    Console.WriteLine("{0,-8} {1,-35} {2,-15:F2} {3:N0}",
//                        process.Id,
//                        process.ProcessName.Length > 35 ? process.ProcessName.Substring(0, 32) + "..." : process.ProcessName,
//                        memoryMB,
//                        memoryBytes);
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine("{0,-8} {1,-35} {2,-15} {3}",
//                        process.Id,
//                        "Нет доступа",
//                        "N/A",
//                        ex.Message);
//                }
//            }

//            Console.WriteLine("\nОбновлено: " + DateTime.Now.ToString("HH:mm:ss"));
//            Console.WriteLine("\nДля выхода нажмите 'q'");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine("Ошибка при получении информации о процессах: " + ex.Message);
//        }
//    }

//    static void WaitForQuitKey(CancellationTokenSource cancellationTokenSource)
//    {
//        while (!cancellationTokenSource.Token.IsCancellationRequested)
//        {
//            if (Console.KeyAvailable)
//            {
//                var key = Console.ReadKey(true);
//                if (key.KeyChar == 'q' || key.KeyChar == 'Q' || key.Key == ConsoleKey.Escape)
//                {
//                    cancellationTokenSource.Cancel();
//                    break;
//                }
//            }
//            Thread.Sleep(100);
//        }
//    }
//}
//#endregion