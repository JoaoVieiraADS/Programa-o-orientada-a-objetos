namespace exercicio_1_de_POO
{
    class retangulo
    {
        float altura, largura;

        public void medidasDoRetangulo(float novaAltura, float novaLargura)
        {
            altura = novaAltura;
            largura = novaLargura;
        }

        public float area()
        {
           float area = altura * largura;
            return area;
        }

        public float perimetro()
        {
            float perimetro = (altura * 2) + (largura * 2) ;
            return perimetro;
        }


    }



    internal class Program
    {
        static void Main(string[] args)
        {
            retangulo rt = new retangulo();

            Console.WriteLine("Digite a altura do retangulo");
            float alt = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a largura do retangulo");
            float lar = float.Parse(Console.ReadLine());

            rt.medidasDoRetangulo(alt, lar);

            float area1, perimetro1;

            area1 = rt.area();
            perimetro1 = rt.perimetro();

            Console.WriteLine("Área : " + area1);
            Console.WriteLine("Perímetro : " + perimetro1);
        }
    }
}