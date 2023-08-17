﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Pedro Henrique Botelho Lima

namespace SWII6_TP1
{
    public class BookRepositorioCSV
    {
        private static readonly string nomeArquivoCSV = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\books.csv";
        private List<Book> _books = new List<Book>();

        public BookRepositorioCSV()
        {
            using (var file = File.OpenText(BookRepositorioCSV.nomeArquivoCSV))
            {
                while (!file.EndOfStream)
                {
                    var line = file.ReadLine();
                    if (string.IsNullOrEmpty(line))
                    {
                        continue;
                    }
                    var books = line.Split(';');
                    var bookName = books[0];
                    var authors = books[1].Split('/');
                    var bookPrice = Double.Parse(books[2]);
                    var bookQty = int.Parse(books[3]);

                    List<Author> bookAuthors = new List<Author>();

                    foreach (string author in authors)
                    {
                        var authorInfo = author.Split(',');
                        var authorClass = new Author(authorInfo[0], authorInfo[1], Char.Parse(authorInfo[2]));
                        bookAuthors.Add(authorClass);
                    }

                    Book book = new Book(bookName, bookAuthors.ToArray(), bookPrice, bookQty);
                    _books.Add(book);
                }
            }
        }

        public Book[] Books => _books.ToArray();
    }
}
