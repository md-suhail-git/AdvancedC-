class Program
{
    class LinkedListNode
    {
        //single linked list
        public int data;
        public LinkedListNode next;
        public LinkedListNode(int x)
        {
            data = x;
            next = null;
        }

        class LinkedList
        {
            LinkedListNode head;
            int count;
            public LinkedList()
            {
                head = null;
                count = 0;
            }
            public void addfrontdata(int data)
            {
                LinkedListNode node=new LinkedListNode(data);
                node.next = head;
                head=node;
                count++;
            }
            public void PrintList()
            {
                LinkedListNode runner =head;
                while (runner != null)
                {
                    Console.WriteLine(runner.data);
                    runner =runner.next;
                }
            }
        }
        public static void Main(String[] args)
        {
            LinkedList l=new LinkedList();
            l.addfrontdata(3);
            l.addfrontdata(4);
            l.addfrontdata(5);
            l.addfrontdata(6);
            l.addfrontdata(7);
            l.addfrontdata(8);
            l.addfrontdata(9);
            l.addfrontdata(10);
            l.PrintList();

        }

    }
}