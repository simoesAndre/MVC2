using System.Collections.Generic;

namespace Atividade_03.Models
{
    public class Dados
    {
        private static List<Paciente> informacoes = new List<Paciente>();

        public static void Incluir(Paciente PacienteAtual)
        {
            informacoes.Add(PacienteAtual);
        }

        public static List<Paciente> Listar()
        {
            return informacoes;
        }
    }
}