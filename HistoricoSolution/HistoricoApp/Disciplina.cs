﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoricoApp
{
    class Disciplina
    {
        private string nome;
        private string semestre;
        private int media;
        private bool aprovado;
        public Disciplina(string nome, string semestre, int media, bool aprovado)
        {
            this.nome = nome;
            this.semestre = semestre;
            if(media >= 0 && media <= 100) this.media = media;
            this.aprovado = aprovado;
        }
        public int GetMedia() { return media; }
        public override string ToString()
        {

            string a;
            if (aprovado) a = "Aprovado";
            else a = "Reprovado";
            return $"{nome} - {semestre} - {media} - {a}";
        }
    }
}
