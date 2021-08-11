namespace Atividade_03.Models
{
    public static class Registro
    {
        public static Dados PacienteAtual {get; set;}
        static Registro()
        {
            PacienteAtual = new Dados();
        }
    }
}