
namespace AppListarAlunos.RegrasDeNegocios
{
    internal class Alunos
    {
        private string nome;
        private int nota1;
        private int nota2;   
        private double media;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Nota1
        {
            get { return nota1; }
            set { nota1 = value; }
        }

        public int Nota2
        {
            get { return nota2; }
            set { nota2 = value; }
        }

        public double Media
        {
            get { return media; }
            set { media = value; }
        }

        public void CalcularMedia()
        {
            media = nota1 + nota2 / 2;
        }

        public string Situacao()
        {
            string nome = "Reprovado";
            if(media >= 70)
                nome = "Aprovado";
            return nome;    
        }

    }
}
