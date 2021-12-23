using System;
using System.Collections.Generic;
using System.Text;

namespace DIO.Series
{
    class Serie:EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }

        private bool Excluido { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = string.Format("Gênero: {0}{5}Título: {1}{5}Descrição: {2}{5}Ano: {3}{5}Excluído: {4}", this.Genero, this.Titulo, this.Descricao, this.Ano, this.Excluido,Environment.NewLine);

            return retorno;
        }

        public string RetornaTitulo()
        {
            return this.Titulo;
        }

        public int RetornaId()
        {
            return this.Id;
        }

        public bool RetornaExcluido()
        {
            return this.Excluido;
        }

        public void Excluir() {
            this.Excluido = true;
        }
    }
}
