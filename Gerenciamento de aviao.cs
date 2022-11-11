using System;

class Gerenciamento {
  public static void Main (string[] args) {
//Função que chama a parte gráfica do sistema
  Visual();

  }

public static void Visual()
{
  string opcao;
  bool ativo = true;
  while(ativo){
  Console.WriteLine("===========================");
  Console.WriteLine("= Bem vindo a Aviação 404 =");
  Console.WriteLine("===========================");
  Console.WriteLine();
  Console.WriteLine("- Escolha a opção desejada");
  Console.WriteLine("0 - Sair");
  Console.WriteLine("1 - Adicionar passageiro");
  opcao = Console.ReadLine();
  
  if(opcao == "0"){
    ativo = false;
    Environment.Exit(1);
  }
  if(opcao == "1"){
    
    Console.WriteLine("Passageiro adicionado");
    ativo = false;
  }
  if(opcao == "2"){
    Console.Clear();
  }
    
  }
}


  
}

