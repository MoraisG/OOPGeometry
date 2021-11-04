using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace OOPGeometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo objTriaguloUm = Triangulo.New();

            Console.WriteLine("Insira as medidas do primeiro triângulo");
            objTriaguloUm.LadoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            objTriaguloUm.LadoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            objTriaguloUm.LadoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(String.Format("A área do triangulo é {0}", objTriaguloUm.CalcularArea()));
        }
    }
}
