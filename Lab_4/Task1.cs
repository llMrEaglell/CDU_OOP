using System;
using System.IO;

namespace Lab_4
{
    public class Task1
    {
        private static readonly string DefaultPathDir = $@"{Directory.GetCurrentDirectory()}\files\";
        private int _sum;
        private int _counter;

        public Task1()
        {
            _sum = 0;
            _counter = 0;
        }

        public void Method()
        {
            try
            {
                isCanOpenResultingFiles();
                for (int i = 10; i < 30; i++)
                {
                    try
                    {
                        using (StreamReader reader = new StreamReader($"{DefaultPathDir}{i}.txt"))
                        {
                            int firstNumber = int.Parse(reader.ReadLine());
                            int secondNumber = int.Parse(reader.ReadLine());
                            _sum += firstNumber * secondNumber;
                            _counter++;
                        }
                    }
                    catch (FileNotFoundException)
                    {
                        appendText(i, "no_file.txt", "not found");
                    }
                    catch (FormatException)
                    {
                        appendText(i, "bad_data.txt", "have not number");
                    }
                    catch (ArgumentNullException)
                    {
                        appendText(i, "bad_data.txt", "have not number");
                    }
                    catch (OverflowException)
                    {
                        appendText(i, "overflow.txt", "so long number");
                    }
                }
                Console.WriteLine(_sum/_counter);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Avg = 0");
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
            }
        }

        private void isCanOpenResultingFiles()
        {
            try
            {
                using (StreamWriter unused = File.CreateText(DefaultPathDir + "no_file.txt"))
                {
                }

                using (StreamWriter unused = File.CreateText(DefaultPathDir + "bad_data.txt"))
                {
                }

                using (StreamWriter unused = File.CreateText(DefaultPathDir + "overflow.txt"))
                {
                }
            }
            catch (UnauthorizedAccessException)
            {
                throw new Exception("Can't create file");
            }
        }

        private void appendText(int numFile, string resultingFile, string text)
        {
            using (FileStream file = new FileStream(DefaultPathDir + resultingFile, FileMode.Append))
            {
                using (StreamWriter stream = new StreamWriter(file))
                {
                    stream.WriteLine($"File {numFile}.txt - {text}");
                }
            }
        }
    }
}