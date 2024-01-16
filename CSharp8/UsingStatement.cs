using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8
{
    internal class UsingStatement
    {
        public UsingStatement()
        {
            
        }

        public async Task Use()
        {
            // Синхронный Dispose
            using (var sr = new StreamReader(""))
            {

            }

            // Синхронный Dispose, фигуные скобки используются внешние (метода)
            using var sr2 = new StreamReader("");

            // Асинхронный Dispose
            await using (var sr3 = new Dispos())
            {

            }

            // Асинхронный Dispose, фигурные скобки исопльзуются внешние (метода)
            await using var sr4 = new Dispos();

            // Так тоже можно
            var sr5 = new StreamReader("");
            using (sr5)
            {

            }
        }

        class Dispos : IAsyncDisposable
        {
            public async ValueTask DisposeAsync()
            {
                await Task.CompletedTask;
            }
        }
    }
}
