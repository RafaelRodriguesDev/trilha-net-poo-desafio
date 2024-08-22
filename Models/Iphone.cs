namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        // Construtor que chama o construtor da classe base com todos os parâmetros
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        // Sobrescrever o método abstrato da classe base
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando aplicativo no Iphone o app {nome}");
        }
    }
}