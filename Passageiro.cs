using System;

class Passageiro{
  private string nome;
  private int cpf;
  private string email;
  private string celular;
  private int idade;

  public Passageiro(){
    nome = "<Nome não Informado>";
    cpf = 0;
    email = "<e-mail não informado>";
    celular = "<Celular não informado>";
    idade = 0;
  }

  public Passageiro(string nome, string email, string celular){
    this.nome = nome;
    cpf = 0;
    this.email = email;
    this.celular = celular;
    idade = 0;
  }

  public Passageiro(string nome, int cpf, int idade, string celular, string email){
    this.nome = nome.ToUpper();
    this.email = email.ToUpper();

    if(cpf>= 0 || cpf < 7){
      this.cpf = cpf;
    }else{
      Console.WriteLine("Por favor inserir um número de CPF válido.");
      this.cpf = 0;
    }
    if(idade >= 18){
      this.idade = idade;
    }
    else{ Console.WriteLine("Você não poderá viajar sem a companhia de um adulto");
        }
    if(celular.Length == 9){
      this.celular = celular;
    }
    else{
      Console.WriteLine("Por favor inserir um número de celular válido");
    }
    
  }

  public string getNome(){
    return nome;
  }

  public void setNome(string n){
    nome = n.ToUpper();
  }

  public int getCPF(){
    return cpf;
  }

  public void setCPF(int c){
    if(c >= 0 || c < 7){
      this.cpf = c;
    }else{
      Console.WriteLine("Por favor inserir um número de CPF válido.");
   };
  }
  
  public int getIdade(){
    return idade;
  }
  
  public void setIdade(int i){
    if(idade >= 18){
      this.idade = i;
    }
    else{ Console.WriteLine("Você não poderá viajar sem a companhia de um adulto");
        }
  }
  
  public string getCelular(){
    return celular;
  }

  public void setCelular(string s){
    if(celular.Length == 9){
      this.celular = s;
    }
    else{
      Console.WriteLine("Por favor inserir um número de celular válido");
    }
  }
  
  public string getEmail(){
    return email;
  }
  
  public void setEmail(string e){
    email = e.ToUpper();
  }
}