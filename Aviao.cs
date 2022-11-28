using System;
using System.IO;
using System.Collections.Generic;

class Aviao{
  private string Marca;
  private int Capacidade;
  private float ValorDaPassagem;
  private List<Passageiro> Persona;

  public Aviao(){
    Marca = "Marca não informada";
    Capacidade = 0;
    Persona = new List<Passageiro>();
  }

  public Aviao(string Marca, int Capacidade, float valor_pass){
    this.Marca = Marca;
    this.Capacidade = Capacidade;
    this.ValorDaPassagem = valor_pass;
    Persona = new List<Passageiro>();
  }

  public bool EmbarquePassageiro(Passageiro p){
    if (Persona.Count < Capacidade){
      Persona.Add(p);
      return true;
    }
    return false;
  }

  public Passageiro BuscaPassageiro(string nome){
    for (int i = 0; i < Persona.Count; i++){
      Passageiro p = Persona[i];
      if (p.getNome() == nome){
        return p;
      }
    }
    return null;
  }

  public List<Passageiro> getListaPassageiros(){
    return Persona;
  }

  public int QuantidadePassageiros(){
    return Persona.Count;
  }

  public void DesembarquePassageiros(){
    Persona.Clear();
  }
  public void ImprimeRelatorioPassageiros(){
    Console.WriteLine("=====================================================");
    Console.WriteLine("============ Relatório de Passageiros ===============");
    Console.WriteLine("=====================================================");
    for(int i = 0; i < Persona.Count; i++){
      Passageiro p = Persona[i];
      Console.WriteLine($"Passageiro {i + 1}: {p.getNome()}");
      
    }
    Console.WriteLine("=====================================================");

    float vlr_total = Persona.Count * ValorDaPassagem;
    Console.WriteLine("Valor da Passagem: R${0:#.00}, Total: R${1:#.00}",this.ValorDaPassagem, vlr_total);
    Console.WriteLine("=====================================================");

    
  }

  //HTML PART
}