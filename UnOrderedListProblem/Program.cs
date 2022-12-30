namespace UnOrderedListProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            //LinkedList<int> list = new LinkedList<int>();
            //string text = "Manchester United is the best football team";
            //string[] textlist = text.Split(" ");
            //foreach (var data in textlist)
            //{
            //    list.Add(data);
            //}
            //list.Display();
            //list.Search("United");

            List<int> number = new List<int> { 1, 6, 7, 5, 9, 8 };
            number.Sort();
            LinkedList<int> list = new LinkedList<int>();
            foreach (int i in number)
            {
                list.Add(i);
            }
            list.Display();
        }
    }
}
