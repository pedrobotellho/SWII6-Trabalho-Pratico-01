using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Pedro Henrique Botelho Lima

namespace SWII6_TP1
{
    public class TestBook
    {
        public TestBook()
        {
            var books = new BookRepositorioCSV().Books;

            foreach (Book book in books)
            {

                Console.WriteLine("Título: " + book.getName());
                Console.WriteLine("Autores: " + book.getAuthorNames());
                Console.WriteLine("Preço: $" + book.getPrice());
                Console.WriteLine("Quantidade disponível: " + book.getQty());

                book.setPrice(15.99);
                book.setQty(40);

                Console.WriteLine("Novo preço: $" + book.getPrice());
                Console.WriteLine("Nova quantidade disponível: " + book.getQty());

                Console.WriteLine(book.ToString());
                Console.WriteLine("\n\n\n\n");
            }
        }
    }
}
