using System;

namespace ProjetoDesconto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Qual o tipo de combustivel? G - gasolina e A - Alcool");
            string combustivel = Console.ReadLine();

            Console.WriteLine("Quantos litros deseja abastecer?");
            float litros = float.Parse(Console.ReadLine());
            float gasolina = float.Parse(Console.ReadLine());


                float percentualdedesconto;
                float precoalcool = 4.9f;
                float precogasolina = 5.3f;
                float valorbruto;
                float valorapagar;
                float totaldodesconto;
                
            switch(combustivel.ToLower()){
                case "a":
                if(litros<=20){
                    percentualdedesconto = 0.03f;
                }else{
                    percentualdedesconto = 0.05f;
                }
                totaldodesconto = (litros * precoalcool) * percentualdedesconto;
                valorbruto = (litros * precoalcool);
                valorapagar = valorbruto - totaldodesconto;
                Console.WriteLine($"Valor a ser pago e de: {valorapagar}");

            break;
                case "a":
                    float resultadodafuncao = ValorASerPago(litros);
                    Console.WriteLine($"O valor a ser pago e de: {resultadodafuncao}");
                break;
                case "g":
                    resultadodafuncao = ValorASerPago(litros,precogasolina,0.04f,0.06f);
                break;
                    if (litros<=20){
                        percentualdedesconto = 0.04f;
                    }else{
                        percentualdedesconto = 0.06f;
                    }
                    totaldodesconto = (litros * 5.3f) * percentualdedesconto;
                    valorbruto = (litros * 5.3f);
                    valorapagar = valorbruto - totaldodesconto;
                    Console.WriteLine($"Valor a ser pago e de: {valorapagar}");
                default:
                    Console.WriteLine("Valor Invalido");
                break;
            }

            float ValorASerPago(float litros, float preco, float perc1, float perc2){
               float percentualdedesconto = 0;
               if(litros <= 20){
                    percentualdedesconto = perc1;
               }else{
                    percentualdedesconto = perc2;
               }
               float totaldodesconto = (litros * preco) * percentualdedesconto;
               float valorbruto = (litros * preco);
               float valorapagar = valorbruto - totaldodesconto;
               return valorapagar;
            }
        }
    }
}
