
using TreinoPOOHeranca.Models;

Console.WriteLine("Simulador de Celular ");


Nokia nokiaTijolao = new Nokia("(15) 99759-3578", "Nokia Tijolao", "1762716726176", 16);
Iphone iphone3 = new Iphone("(15) 99686-5105", "Iphone3", "82918291829819", 32);

Console.WriteLine($"Dados do Nokia:  {nokiaTijolao.NumeroTelefone } Modelo: {nokiaTijolao.Modelo}");
Console.WriteLine("Estatus: ");
nokiaTijolao.FazerLigacao();


iphone3.InstalarAplicativo("Whatsap");
nokiaTijolao.InstalarAplicativo("Doe+");