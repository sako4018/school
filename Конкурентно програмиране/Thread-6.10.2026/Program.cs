namespace Thread_6._10._2026
{
    internal class Program
    {
        public void ThreadMethod()
        {
            Console.WriteLine("Thread 3 is different");
        }
        static void Main(string[] args)
        {
            Thread[] threads = new Thread[5];
            for(int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(new Program().ThreadMethod);
                threads[i].Start();
            }
            for(int i = 0; i < threads.Length; i++)
            {
                if(i == 2)
                {
                    threads[2].ThreadMethod();

                }
                else
                {
                    Console.WriteLine(threads[i].Name = "Thread " + i);
                }
            }
        }
    }
}
