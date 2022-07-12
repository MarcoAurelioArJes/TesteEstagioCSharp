using System.Text.RegularExpressions;

string num = "";
int numeroConvertido = 0;
Regex espacoesECaracteres = new Regex(@"\b\s*[^\d]"); // Retirando espaços e caracteres após o primeiro caracter
Regex pegandoEspacos = new Regex(@"\s*");

try {
    do {
        Console.WriteLine("Insira um número inteiro");
        num = Console.ReadLine();
        num = espacoesECaracteres.Replace(num, "");
        num = pegandoEspacos.Replace(num, "");
        if (num == "") {
            Console.WriteLine("Nenhum número inserido, por favor insira um número");
        } else if (int.TryParse(num, out numeroConvertido) == true) {
            numeroConvertido = Convert.ToInt32(num);
        } else {
            Console.WriteLine("O número deve ser inteiro");
        }

    } while (num == "");

} catch(Exception err) {
   if (err.Message == "Value was either too large or too small for an Int32.") {
        Console.WriteLine("Número muito grande, o número deve ter valores entre {0} e {1}", 2147483647, -2147483648);
        return;
    }
    Console.WriteLine(err.Message);
    return;
}

Console.WriteLine("Número convertido {0}", numeroConvertido);
Console.WriteLine(num);