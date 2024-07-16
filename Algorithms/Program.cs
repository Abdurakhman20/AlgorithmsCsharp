namespace Program 
{
    public class Program
    {
        static void Main(string[] args)
        {
            Algorithms.DataStructures.Stack<int> stack = new Algorithms.DataStructures.Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            Console.WriteLine(stack.ToString());

        }
    }
}
