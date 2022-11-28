using System;
using System.IO;
using System.Text;

class Gerenciamento
{
    Aviao meu_aviao;

    public bool CarregarDadosPassageiros(string nome_arquivo)
    {
        string[] linhas = File.ReadAllLines(nome_arquivo);

        foreach (string linha in linhas)
        {
            string[] dados = linha.Split(";");
            string nome = dados[0];
            int cpf = int.Parse(dados[1]);
            int idade = int.Parse(dados[2]);
            string celular = dados[3];
            string email = dados[4];
            
            meu_aviao.EmbarquePassageiro(new Passageiro(nome, cpf, idade, celular, email));
        }
        return true;
    }

    public bool GravarDadosPassageiros(string nome_arquivo)
    {
        using (StreamWriter writer = new StreamWriter(nome_arquivo))
        {
            foreach (Passageiro p in meu_aviao.getListaPassageiros())
            {
                string linha = string.Format("{0};{1};{3};{4}", p.getNome(), p.getCPF(), p.getEmail(), p.getCelular(), p.getIdade());
                writer.WriteLine(linha);
            }
        }
        return true;
    }

    public Gerenciamento()
    {
        meu_aviao = new Aviao("Latão", 72, 199.90f);
    }



    public void MenuInicial()
    {
        string opcao = "";

        while (opcao != "0")
        {
            Console.Clear();
            Console.WriteLine("======================================================");
            Console.WriteLine("===                Opcões do Sistema              ===");
            Console.WriteLine("======================================================");
            Console.WriteLine("0 - Sair.");
            Console.WriteLine("1 - Adicionar Passageiro ao Avião");
            Console.WriteLine("2 - Apresentar Relatório de Passageiros.");
            Console.WriteLine("3 - Carregar dados.");
            Console.WriteLine("4 - Gravar dados.");
            Console.WriteLine("======================================================");
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada: ");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "0":
                    return;
                case "1":
                    Console.WriteLine("Informe o nome do passageiro:");
                    string nome = Console.ReadLine();
                    int cpf = int.Parse(Console.ReadLine());
                    string email = Console.ReadLine();
                    string celular = Console.ReadLine();
                    int idade = int.Parse(Console.ReadLine());
                    meu_aviao.EmbarquePassageiro(new Passageiro(nome, cpf, idade, celular, email));
                    Console.WriteLine("\nPassageiro Embarcado! Pressione qualquer tecla para continuar.");
                    Console.ReadKey();
                    break;
                case "2":
                    meu_aviao.ImprimeRelatorioPassageiros();
                    Console.WriteLine("\nRelatório Apresentado! Deseja salvar em HTML? (S/N).");
                    //RELATORIO HTML
                    break;
                case "3":
                    bool realizar_acao = true;
                    if (meu_aviao.QuantidadePassageiros() > 0)
                    {
                        Console.WriteLine("Os dados atuais serão substituídos, deseja continuar? (S/N)");
                        string resp = Console.ReadLine();
                        if(resp.ToUpper() =="S")
                        {
                          meu_aviao.DesembarquePassageiros();
                          realizar_acao = true;
                        }
                      else{
                          realizar_acao = false;
                      }
                    }
                if(realizar_acao)
                {
                  //A faazer
                 // CarregarDadosPassageiros("")
                }
                else
                {
                  Console.WriteLine("\nDados Não Carregados! Pressione alguma tecla para continuar");
                }
                Console.ReadKey();
                break;
              default:
                Console.WriteLine("Opcão Inválida! Pressione qualquer tecla para continuar.");
                Console.ReadKey();
                break;
            }
          opcao="";
        }
    }
  public static void Main(string[] args)
  {
    Gerenciamento meu_gerenciador = new Gerenciamento();
    meu_gerenciador.MenuInicial();
  }

}





