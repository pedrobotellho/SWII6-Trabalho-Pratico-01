using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Pedro Henrique Botelho Lima

namespace SWII6_TP1
{
    public class Book
    {

        private string name { get; set; }
        private Author[] authors { get; set; }
        private double price { get; set; }
        private int qty { get; set; }

        public Book(string name, Author[] authors, double price)
        {
            this.name = name;
            this.authors = authors;
            this.price = price;
            this.qty = 0;
        }
        public Book(string name, Author[] authors, double price, int qty)
        {
            this.name = name;
            this.authors = authors;
            this.price = price;
            this.qty = qty;
        }

        public void setPrice(double price)
        {
            this.price = price;
        }
        public void setQty(int qty)
        {
            this.qty = qty;
        }
        public string getName()
        {
            return this.name;
        }
        public Author[] getAuthors()
        {
            return this.authors;
        }
        public double getPrice()
        {
            return this.price;
        }
        public int getQty()
        {
            return this.qty;
        }




        public override string ToString()
        {

            string authors = "";

            foreach (Author author in this.authors)
            {
                authors += "[name=" + author.Name + ",email=" + author.Email + ",gender=" + author.Gender +"]";

                if (author != this.authors.Last())
                {
                    authors += ",";
                }
            }

            return "Book[" + this.name + ",authors={Authors" + authors + "},price=" + this.price + ",qty=" + this.qty + "]";
        }
        public string getAuthorNames()
        {
            string authorNames = "";

            foreach (Author author in this.authors)
            {
                authorNames += author.Name;

                if (author != this.authors.Last())
                {
                    authorNames += ",";
                }
            }
            return authorNames;

        }
    }
}
