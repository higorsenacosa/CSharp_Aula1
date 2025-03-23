// Sou o namespace do Sistema e vou ser usado para a aplicação
using System;
namespace Aula1
{
    class Program
    {
        /*
         Este é o método principal da aplicação, onde o programa começa a ser executado.
         E eu sou um comentário de bloco. 
         */
        static void Main(string[] args)
        {
            // Sou um comentário de uma linha
            Console.WriteLine("Vou imprimir o texto colocado entre aspas duplas na tela.");
            // Equivalente ao escreval() do VisuAlg

            /*
             Tipos de variaveis
             Em algumas linguagens de programação, é necessário declarar o tipo de variável que será utilizada.
            Como no VisuAlg :
            algoritmo "arquivo"
            var 
                nomeVariavel : inteiro
            inicio
                nomeVariavel <- 10
                escreval(nomeVariavel)
            fimalgoritmo
             */
            // No C#, basta colocar o tipo da variavel antes do nome dela
            int numeroInteiro;
            numeroInteiro = 10;

            // Posso declarar e atribuir o valor de uma variável na mesma linha
            int inteiro = 20;

            // Existem outros tipos de dados como:
            float real = 10.0f/3f; // Aceita uma quantidade menor de caracteres que o double e na maioria dos casos deve ser colocado o f no final
            double realDuplaPrecisao = 10/3; // Não precisa colocar o f no final
            char caractereUnico = 'a'; // Diferente do VisuAlg, o char é apenas um caractere
            string texto = "Texto"; // Pode usar aspas duplas e um conjunto de """ para textos maiores finalizando com """
            bool verdadeiroOuFalso = true; //Diferente do VisuAlg, o bool só aceita true{verdadeiro} ou false{falso}

            // Podemos mostrar a informação concatenando o texto com a variável numerica
            Console.WriteLine("O valor da variável inteiro é: " + inteiro);
            //Mas um outro jeito de fazer isso é usando o format
            Console.WriteLine($"O valor da variável inteiro é: {inteiro}\n" +
                "Em VisuAlg para formatar era necessário o uso de var:num:dec\n" +
                $"O valor da variável real (Formate dessa forma com :.## para duas casas decimais) é: {real:.##}\n" +
                $"O valor da variável realDuplaPrecisao é: {realDuplaPrecisao}\n" +
                $"O valor da variável caractereUnico é: {caractereUnico}\n" +
                $"O valor da variável texto é: {texto}\n" +
                $"O valor da variável verdadeiroOuFalso é: {verdadeiroOuFalso}");
            /*
             Constantes em VisuAlg era necessário o uso de const conforme o exemplo abaixo:
                algoritmo "arquivo"
                const
                    inteiro = 10
                inicio
                    escreval(inteiro)
                fimalgoritmo
             */
            // No C# basta usar a palavra reservada const com o tipo da variável
            const int CONSTANTE = 10; //IMPORTANTE: Normalmente constante se usa com letras maiúsculas
            Console.WriteLine($"O valor da constante é: {CONSTANTE}");
        }
    }
}
