using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

// Pedro Henrique Botelho Lima

namespace SWII6_TP1
{
    public class Startup
    {
        private readonly BookRepositorioCSV _repo = new BookRepositorioCSV();

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting();
        }
        public void Configure(IApplicationBuilder app)
        {
            var builder = new RouteBuilder(app);

            builder.MapRoute("/livro/nome", BookNames);
            builder.MapRoute("/livro/ToString", BookToString);
            builder.MapRoute("/livro/Autores", NameAuthors);
            builder.MapRoute("/livro/ApresentaLivro", ApresentaLivro);
            var rotas = builder.Build();

            app.UseRouter(rotas);
        }

        public Task BookNames(HttpContext context)
        {
            var book = _repo.Books.FirstOrDefault();

            return context.Response.WriteAsync(book.getName());
        }
        public Task BookToString(HttpContext context)
        {
            var book = _repo.Books.FirstOrDefault();

            return context.Response.WriteAsync(book.ToString());

        }
        public Task NameAuthors(HttpContext context)
        {
            var book = _repo.Books.FirstOrDefault();

            return context.Response.WriteAsync(book.getAuthorNames());
        }
        public Task ApresentaLivro(HttpContext context)
        {
            var book = _repo.Books.FirstOrDefault();

            var html = "<html><body>";
            html += "<strong>" + book.getName() + "</strong>";
            html += "<ol>";
            foreach (Author author in book.getAuthors())
            {
                html += "<li>" + author.Name + "</li>";
            }
            html += "</ol>";
            html += "</body></html>";

            return context.Response.WriteAsync(html);
        }
    }
}
