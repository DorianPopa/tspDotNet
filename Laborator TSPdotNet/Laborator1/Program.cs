using System;
using System.Collections.Generic;
using System.Threading;


namespace Laborator1
{
    class Program
    {
        static object messagesLock = new object();

        static int numberToSearch = 50000;
        static Thread thread1, thread2;
        static List<string> messages;

        static void Main(string[] args)
        {
            messages = new List<string>();

            thread1 = new Thread(new ThreadStart(ThreadProc));
            thread1.Name = "Thread 1";
            thread2 = new Thread(new ThreadStart(ThreadProc));
            thread2.Name = "Thread 2";

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            foreach (string message in messages)
            {
                Console.WriteLine(message);
            }
        }

        static void ThreadProc()
        {
            string message = "Start fir:" + Thread.CurrentThread.Name + " " + DateTime.Now + " " + numberToSearch.ToString();

            lock (messagesLock)
                messages.Add(message);

            int result = 0;
            if (Thread.CurrentThread.Name == "Thread 1" && thread2.ThreadState != ThreadState.Unstarted)
            {
                result = LargestPrimeBiggerThanGivenParam1(numberToSearch);
            }
            else
            {
                result = LargestPrimeBiggerThanGivenParam2(numberToSearch);
            }

            message = "End fir:" + Thread.CurrentThread.Name + " " + DateTime.Now + " " + result.ToString();
            lock (messagesLock)
                messages.Add(message);
        }

        static bool IsPrime(int number)
        {
            if (number % 2 == 0)
                return false;
            else if (number == 1)
                return false;
            else
            {
                for (int i = 3; i * i < number; i += 2)
                    if (number % i == 0)
                        return false;
            }
            return true;
        }

        static int LargestPrimeBiggerThanGivenParam1(int param)
        {
            for(int i = param; i > 0; i--)
            {
                if (IsPrime(i))
                    return i;
            }
            return 0;
        }

        static int LargestPrimeBiggerThanGivenParam2(int param)
        {
            int largestPrimeFound = 0;
            for (int i = 1; i < param; i++)
            {
                if (IsPrime(i))
                    largestPrimeFound = i;
            }
            return largestPrimeFound;
        }
    }
}
