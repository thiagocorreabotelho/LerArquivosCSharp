const string FILE_PATH = "C:\\Correa Devs\\Cursos\\CSharp\\LerArquivoCSharp\\LerArquivosCSharp\\LerAquivoCSharp\\text-file.txt";


//var data = File.ReadAllText(FILE_PATH);
//Console.WriteLine(data);

//var data = File.ReadAllLines(FILE_PATH);
//var count = 0;
//foreach (var line in data)
//{
//    count++;
//    Console.WriteLine($"Linha: {count} - {line}");
//}

using var file = new StreamReader(FILE_PATH);
string? line;

while ((line = file.ReadLine()) != null)
    Console.WriteLine(line);

file.Close();