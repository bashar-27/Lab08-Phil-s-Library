namespace Lab08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var originalColor = Console.ForegroundColor;
           welcome();
            Console.ForegroundColor = originalColor;


            Library libr = new Library();
            libr.Add("HarryPotter", "Bashar", "Nidal", 1000);
            libr.Add("King of Greed", "Ana", "Huang", 500);
            libr.Add("The Covenant of Water ", "Abraham", "Verghese", 350);
            Console.WriteLine("This is all book available in library");
            int i = 1;
            foreach (var item in libr)
            {
                Console.WriteLine($"{i}-{item.Title}");
                i++;
            }
            Console.WriteLine("\n\n---------------------");
            Backpack<Book> backpack = new Backpack<Book>();
             Book book = libr.Borrow("HarryPotter");
            Book book1 = libr.Borrow("King of Greed");

            if(book != null ) {
                backpack.Pack(book);
                Console.WriteLine($"\n**Borrowed Book: {book.Title} by the author {book.Author}**\n");
                Console.WriteLine($"\n**Borrowed Book: {book1.Title} by the author {book1.Author}**\n");

                Console.WriteLine("The library after you borrow some book: ");
                i = 1;
                foreach (var item in libr)
                {
                    Console.WriteLine($"{i}-{item.Title}");
                    i++;
                }
                Console.WriteLine("\n\n---------------------");

                Console.WriteLine($"Lets unpack it and return it :");
                Book bookReturn = backpack.Unpack(0);
                libr.Return(bookReturn);
                 //bookReturn = backpack.Unpack(1);
                //libr.Return(bookReturn);

                i = 1;
                foreach (var item in libr)
                {
                    Console.WriteLine($"{i}-{item.Title}");
                    i++;
                }
            }


        }
        public static void welcome()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t\t\tPhil’s Lending Library\n\n");
        }
    }
}