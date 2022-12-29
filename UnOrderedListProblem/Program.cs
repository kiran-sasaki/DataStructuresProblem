namespace UnOrderedListProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();
            string text = "Manchester United is the best football team";
            string[] textlist = text.Split(" ");
            foreach (var data in textlist)
            {
                list.Add(data);
            }
            list.Display();
            list.Search("United");
        }
    }
}
