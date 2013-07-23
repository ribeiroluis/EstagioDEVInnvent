using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramaEstagio
{
    class SubCategoria: Categoria
    {
        List<SubCategoria> ListaSubCategoria = new List<SubCategoria>();
        
        public SubCategoria()
        {
        }

        public int InsereSubCategoria(SubCategoria _novaSubCategoria)
        {
            try
            {
                _novaSubCategoria.IdSubCategoria = ListaSubCategoria.Count + 1;
                ListaSubCategoria.Add(_novaSubCategoria);
                Console.WriteLine("SubCategoria criada com Sucesso..");
                return 1;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
                return 0;
            }
        }

        public int RemoveSubCategoria(int idSubCategoria)
        {
            try
            {
                int i = 0;
                foreach (var item in ListaSubCategoria)
                {
                    if (item.IdSubCategoria == idSubCategoria)
                    {
                        ListaSubCategoria.RemoveAt(i);
                        break;
                    }
                    else
                        i++;

                }
                Console.WriteLine("SubCategoria Excluida com Sucesso..");
                return 1;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
                return 0;
            }
        }

        public int AlteraSubCategoria(int idSubCategoria, SubCategoria _SubCategoriaAlterada)
        {
            try
            {
                int i = 0;
                foreach (var item in ListaSubCategoria)
                {
                    if (item.IdSubCategoria == idSubCategoria)
                    {
                        ListaSubCategoria[i] = _SubCategoriaAlterada;
                        break;
                    }
                    else
                        i++;

                }
                Console.WriteLine("SubCategoria alterada com sucesso..");
                return 1;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
                return 0;
            }
        }

        private int IdSubCategoria { get; set; }
        public string  Nome { get; set; }
    }
}
