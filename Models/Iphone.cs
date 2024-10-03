namespace DesafioPOO.Models
{
    // DONE: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string Imei, int memoria) : base(numero, modelo, Imei, memoria)
        {

        }
        // DONE: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeDoApp)
        {
            Console.WriteLine($"instalando {nomeDoApp} no sistema iPhone!");
        }
    }
}