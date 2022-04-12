using AppListarAlunos.RegrasDeNegocios;
using static System.Console;

//variaveis
Alunos[] alunos = new Alunos[100];
int quantidade = 0;
Boolean errado = false;

//inicio while
while (true)
{
    Clear();
    WriteLine("#####Sistema Para Cadastrar Alunos#####");
    //caso digitar errado aviso 
    if (errado)
    {
        ForegroundColor = ConsoleColor.Red;
        WriteLine("\n#####Voce Digitou Um Numero Invalido#####");
        ForegroundColor = ConsoleColor.White;
    }
    WriteLine("\nAlunos Cadastrados: " + quantidade);
    WriteLine("\n1 - Cadastrar Aluno");
    WriteLine("2 - Listar Alunos");
    WriteLine("3 - Consultar Alunos Por Nome");
    WriteLine("4 - Listar Alunos Aprovados");
    WriteLine("5 - Listar Alunos Reprovados");
    WriteLine("6 - Sair");
    Write("\nSelecione Uma Opção:");
    int opc = Convert.ToInt32(ReadLine());

    //sistema de verificar letras e opçoes
    if (opc == 6)
        break;
    else if (opc == 0 || opc > 6)
    {
        errado = true;
        continue;
    }
    else
        errado = false;


    Clear();
    Alunos aluno = new Alunos();
    //inicio switch
    switch (opc)
    {
        //switch 1
        case 1:
            Write("Digite O Nome Do Aluno:");
            aluno.Nome = ReadLine();
            Write("\nDigite A 1 Nota Do Aluno:");
            aluno.Nota1 = Convert.ToInt32(ReadLine());
            Write("\nDigite A 2 Nota Do Aluno:");
            aluno.Nota2 = Convert.ToInt32(ReadLine());
            aluno.CalcularMedia();
            alunos[quantidade] = aluno;
            quantidade++;
            break;
        //switch 2
        case 2:
            if (quantidade != 0)
            {
                for (int i = 0; i < quantidade; i++)
                {
                    Write("\n" + 1 + i + " - " + alunos[i].Nome + " | Nota 1: " + alunos[i].Nota1 + " | Nota 2: " + alunos[i].Nota2 + " | Media: " + +alunos[i].Media + " | Status: ");

                    if (alunos[i].Media >= 70)
                    {
                        ForegroundColor = ConsoleColor.Green;
                        Write(alunos[i].Situacao());
                        ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        ForegroundColor = ConsoleColor.Red;
                        Write(alunos[i].Situacao());
                        ForegroundColor = ConsoleColor.White;
                    }
                }
            }
            else
                WriteLine("Nenhum aluno cadastrado");

            WriteLine("\nAperte qualquer tecla para continuar");
            ReadKey();
            break;
        //switch 3
        case 3:
            if (quantidade != 0)
            {
                Write("Digite o nome que deseja procurar:");
                string nome = ReadLine();
                Boolean certo = true;
                for (int i = 0; i < quantidade; i++)
                {
                    if (alunos[i].Nome == nome)
                    {
                        WriteLine("\nAluno Encontrado!!! " + nome + " e o numero " + i + 1 + " da lista");
                        Write(alunos[i].Nome + " | Nota 1: " + alunos[i].Nota1 + " | Nota 2: " + alunos[i].Nota2 + " | Media: " + alunos[i].Media + " | Status: ");
                        if (alunos[i].Media >= 70)
                        {
                            ForegroundColor = ConsoleColor.Green;
                            Write(alunos[i].Situacao());
                            ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            ForegroundColor = ConsoleColor.Red;
                            Write(alunos[i].Situacao());
                            ForegroundColor = ConsoleColor.White;
                        }
                        certo = false;
                        break;
                    }
                }
                if (certo)
                    WriteLine("\nO aluno não exista na lista");
            }
            else
                WriteLine("Nenhum aluno cadastrado");

            WriteLine("\nAperte qualquer tecla para continuar");
            ReadKey();
            break;
        //switch 4
        case 4:
            if (quantidade != 0)
            {
                Boolean tem = false;
                for (int i = 0; i < quantidade; i++)
                {
                    if (alunos[i].Media >= 70)
                    {
                        tem = true;
                        Write(alunos[i].Nome + " | Nota 1: " + alunos[i].Nota1 + " | Nota 2: " + alunos[i].Nota2 + " | Media: " + alunos[i].Media + " | Status: ");
                        ForegroundColor = ConsoleColor.Green;
                        Write(alunos[i].Situacao());
                        ForegroundColor = ConsoleColor.White;
                    }
                }
                if (!tem)
                    WriteLine("Nenhum aluno aprovado");
            }
            else
                WriteLine("Nenhum aluno cadastrado");

            WriteLine("\nAperte qualquer tecla para continuar");
            ReadKey();
            break;
        case 5:
            if (quantidade != 0)
            {
                Boolean tem = false;
                for (int i = 0; i < quantidade; i++)
                {
                    if (alunos[i].Media < 70)
                    {
                        tem = true;
                        Write(alunos[i].Nome + " | Nota 1: " + alunos[i].Nota1 + " | Nota 2: " + alunos[i].Nota2 + " | Media: " + alunos[i].Media + " | Status: ");
                        ForegroundColor = ConsoleColor.Red;
                        Write(alunos[i].Situacao());
                        ForegroundColor = ConsoleColor.White;
                    }
                }
                if (!tem)
                    WriteLine("Nenhum aluno reprovado");
            }
            else
                WriteLine("Nenhum aluno cadastrado");

            WriteLine("\nAperte qualquer tecla para continuar");
            ReadKey();
            break;
    }
    //fim switch
}
//fim while