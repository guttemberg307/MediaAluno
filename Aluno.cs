using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaAlunos
{
    class Aluno
    {
        public string Nome { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        public double Media { get; set; }


        public Aluno()// contrutor vazio 
        {
        }

        public Aluno(string nome, int id, string email, double nota1, double nota2, double nota3)
        {
            Nome = nome; // construtor cheio 
            Id = id;
            Email = email;
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
        }

        public override string ToString()
        {
            return Nome + "," + Id + "," + Email + "," + Nota1 + "," + Nota2 + "," + Nota3;
        }
   
    
    
    }


}
