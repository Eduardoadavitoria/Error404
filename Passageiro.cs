using System;

class Passageiro{
  private string nome;
  private string cpf;
  private string email;
  private string celular;
  private int idade;

  public Passageiro(){
    nome = "<Nome não Informado>";
    cpf = "<CPF não informado>";
    email = "<e-mail não informado>";
    celular = "<Celular não informado>";
    idade = 0;
  }

  public Passageiro(string nome,string cpf, string email, string celular){
    this.nome = nome;
    this.cpf = cpf;
    this.email = email;
    this.celular = celular;
    idade = 0;
  }

  public Passageiro(string nome, string cpf, int idade, string celular, string email){
    this.nome = nome.ToUpper();
    this.email = email.ToUpper();

    if(cpf.Length == 11){
      this.cpf = cpf;
    }else{
      Console.WriteLine("Por favor inserir um número de CPF válido.");
      this.cpf = "";
    }
    if(idade >= 18){
      this.idade = idade;
    }
    else{ Console.WriteLine("Você não poderá viajar sem a companhia de um adulto");
        }
    if(celular.Length <= 12){
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

  public string getCPF(){
    return cpf;
  }

  public void setCPF(string c){
    if(c.Length == 11){
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
    if(s.Length <= 12){
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