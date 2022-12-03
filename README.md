# Leitura de arquivos c#

Fala pessoal, neste repositório vamos falar um pouco sobre algumas formas de como ler os arquivos em c#.
Primeiro vamos falar sobre o **ReadAllText**.

> O ReadAllText nada mais é abrir o _local_ do arquivo de **texto** e faz a leitura de todas as cadeias de caracteres que existe no mesmo.

## Exemplo ReadAllText
```csharp
    cont string SEU_CAMINHO = "C:\\diretorio\\Cursos\\CSharp\\LerArquivoCSharp\\LerArquivosCSharp\\LerAquivoCSharp\\text-file.txt";
    var data = File.ReadAllText(SEU_CAMINHO);
```
![image](https://user-images.githubusercontent.com/99252640/205442524-f000417f-f0ff-454f-8c35-c2c89fb938bc.png)

Link da documentação da Microsoft sobre o ReadAllText = https://learn.microsoft.com/pt-br/dotnet/api/system.io.file.readalltext?view=net-7.0

----

Agora vamos falar sobre **ReadAllLines** e para quem ainda não sabe o ReadAllLines é diferente do nosso amigo ReadAllText, pois o mesmo ele cria um array que vai fazer a leitura por linhas em forma de lista.

> Abre um arquivo de texto, lê todas as linhas do arquivo em uma matriz de cadeia de caracteres e o fecha.

## Exemplo ReadAllLines
```csharp
    cont string SEU_CAMINHO = "C:\\diretorio\\Cursos\\CSharp\\LerArquivoCSharp\\LerArquivosCSharp\\LerAquivoCSharp\\text-file.txt";
    var data = File.ReadAllLines(SEU_CAMINHO);
    var count = 0;
    
    foreach(var line in data){
         count ++;
         Console.WriteLine($"Linha: {count} - {line}");
    }
```
![image](https://user-images.githubusercontent.com/99252640/205442917-efb90c7e-34ff-405f-95eb-c67335802268.png)

Link da documentação da Microsoft sobre o ReadAllLines: https://learn.microsoft.com/pt-br/dotnet/api/system.io.file.readalllines?view=net-7.0


----

Para finalizar vamos falar sobre o StreamReader que nada mais é que uma classe que podemos utilizar propriedades para manipular e ler nossos arquivos diretamente no c#.

> Definição MS: Implementa um TextReader que lê caracteres de um fluxo de bytes em uma codificação especifica.

## Exemplo StreamReader
```csharp
    cont string SEU_CAMINHO = "C:\\diretorio\\Cursos\\CSharp\\LerArquivoCSharp\\LerArquivosCSharp\\LerAquivoCSharp\\text-file.txt";
    using var file = new StreamReader(SEU_CAMINHO);
    string? line;
    
    while((line = file.ReadLine()) != null)
       Console.WriteLine(line);
       
    file.Close();
    
    ![image](https://user-images.githubusercontent.com/99252640/205443169-59f3c390-18db-4664-80b9-38041d40f0ab.png)

    
    foreach(var line in data){
         count ++;
         Console.WriteLine($"Linha: {count} - {line}");
    }
```
