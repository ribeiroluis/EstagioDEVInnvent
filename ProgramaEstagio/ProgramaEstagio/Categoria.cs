using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramaEstagio
{
    class Categoria
    {
        List<Categoria> ListaCategoria = new List<Categoria>();
       
        public Categoria()
        {
        }

        public int InsereCategoria(Categoria _novaCategoria)
        {
            try
            {
                _novaCategoria.IdCategoria = ListaCategoria.Count + 1;
                ListaCategoria.Add(_novaCategoria);
                Console.WriteLine("Categoria criada com Sucesso..");
                return 1;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
                return 0;
            }
        }

        public int RemoveCategoria(int idCategoria)
        {
            try
            {
                int i = 0;
                foreach (var item in ListaCategoria)
                {
                    if (item.IdCategoria == idCategoria)
                    {
                        ListaCategoria.RemoveAt(i);
                        break;
                    }
                    else
                        i++;

                }
                Console.WriteLine("Categoria Excluida com Sucesso..");
                return 1;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
                return 0;
            }
        }

        public int AlteraCategoria(int idCategoria, Categoria _categoriaAlterada)
        {
            try
            {
                int i = 0;
                foreach (var item in ListaCategoria)
                {
                    if (item.IdCategoria == idCategoria)
                    {
                        ListaCategoria[i] = _categoriaAlterada;
                        break;
                    }
                    else
                        i++;

                }
                Console.WriteLine("Categoria alterada com sucesso..");
                return 1;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
                return 0;
            }
        }

        private int IdCategoria { get; set; }
        public string  Nome { get; set; }
    }
}
