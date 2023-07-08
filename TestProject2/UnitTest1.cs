using Lab08;
using Lab08.Class;

namespace TestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Library libr = new Library();
            libr.Add("HarryPotter", "Bashar", "Nida", 1000);
            int res = libr.Count;
            Assert.Equal(1, res);

        }
        [Fact]
        public void Borrow() {
         Library library = new Library();
            library.Add("HarryPotter", "Bashar", "Nida", 1000);
            library.Add("2", "Ammar", "Alam", 200);
            Book book = library.Borrow("2");
            Assert.DoesNotContain(book, library);
            
        }
        [Fact]
        public void BorrowBook1()
        {
            Library library = new Library();
            library.Add("HarryPotter", "Bashar", "Nida", 1000);
            library.Add("1", "FIRST", "LAST", 100);
            library.Add("2", "FIRST", "LAST", 200);
            library.Borrow("2");
            int result = library.Count;
            Assert.Equal(2, result);
        }
        [Fact]
        public void BorrowNull()
        {
            Library library = new Library();
            library.Add("HarryPotter", "Bashar", "Nida", 1000);
            library.Add("2", "Ammar", "Alam", 200);

            Book book = library.Borrow("4");
            Assert.Equal(book, null);

        }
        [Fact]
        public void Return()
        {
            Library library = new Library();
            library.Add("HarryPotter", "Bashar", "Nida", 1000);
            library.Add("2", "Ammar", "Alam", 400);
            Book book = library.Borrow("HarryPotter");
            library.Return(book);
            Assert.Contains(book, library);
        }
        [Fact]
        public void ReturnCount()
        {
            Library library = new Library();
            library.Add("HarryPotter", "Bashar", "Nida", 1000);
            library.Add("2", "Ammar", "Alam", 400);
            library.Add("3", "FIRST", "LAST", 100);
            library.Add("The Covenant of Water", "FIRST", "LAST", 600);
            Book book = library.Borrow("2");
            library.Return(book);
            int Total = library.Count;
            Assert.Equal(4, Total);
        }
        [Fact]
        public void Pack()
        {
            Backpack<Book> back = new Backpack<Book>();
            var book = new Book {Title="Peace",Author ="Shaker",Page=260 };
            back.Pack(book);
            int countPack = back.Count();
            Assert.Equal(1, countPack);
        }
        [Fact]
         public void UnPack()
        {
            Backpack<Book> unpack = new Backpack<Book>();
            var book = new Book { Title = "Peace", Author = "Shaker", Page = 260 };
            var book2 = new Book { Title = "AOT", Author = "Armen", Page = 2850 };
            var book3 = new Book { Title = "GOT", Author = "Amer", Page = 5850 };

            unpack.Pack(book);
            unpack.Pack(book2);
            unpack.Pack(book3);
            unpack.Unpack(1);
            int countUnpack = unpack.Count();
            Assert.Equal(2, countUnpack);

        }
    }
}