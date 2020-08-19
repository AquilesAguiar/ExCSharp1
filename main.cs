using System;

class MainClass {

    /* Exercicio 3 */
    public static int soma (int num1, int num2) {
      int resultado;
      resultado = num1+num2;
      Console.WriteLine ("Sua soma Foi de {0}", resultado);
      return 0;
  }

  /* Exercicio 3 */
    public static int media (int num1, int num2, int num3, int num4){
      int resultado;
      resultado = (num1+num2+num3+num4)/4;
      Console.WriteLine ("Sua Média é de {0}", resultado);
      return 0;
  }

  public static void Main () {
    
    int somanum1, somanum2;
    int mednum1, mednum2, mednum3, mednum4;

    //Soma
    
    Console.WriteLine("Somando");
    
    //Primeiro número
    Console.Write("Numero de Soma 1 > ");
    somanum1 = int.Parse( Console.ReadLine ());
    //Segundo
    Console.Write("Numero de soma 2 > ");
    somanum2 = int.Parse( Console.ReadLine ());
    //Somando
    soma(somanum1, somanum2);


    Console.WriteLine("Tirando a Média");

    //Média
    
    Console.Write("Numero 1 >");
    mednum1 = int.Parse(Console.ReadLine());
    
    Console.Write("Numero 2 >");
    mednum2 = int.Parse(Console.ReadLine ());
    
    Console.Write("Numero 3 >");
    mednum3 = int.Parse(Console.ReadLine ());
    
    Console.Write("Numero 4 >");
    mednum4 = int.Parse(Console.ReadLine ());
    
    //Calculando a média
    media( mednum1, mednum2, mednum3, mednum4);


  }   //Final da main
}     //Final da classe