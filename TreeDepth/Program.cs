using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDepth
{
    class Program
    {
        static void Main(string[] args)
        {
            Medis medis = new Medis();
            medis.root = medis.NaujaSaka(1);
            medis.root.sakos.Add(medis.NaujaSaka(2));
            medis.root.sakos.Add(medis.NaujaSaka(3));
            medis.root.sakos[0].sakos.Add(medis.NaujaSaka(4));
            medis.root.sakos[1].sakos.Add(medis.NaujaSaka(5));
            medis.root.sakos[1].sakos.Add(medis.NaujaSaka(6));
            medis.root.sakos[1].sakos.Add(medis.NaujaSaka(7));
            medis.root.sakos[1].sakos[0].sakos.Add(medis.NaujaSaka(10));
            medis.root.sakos[1].sakos[1].sakos.Add(medis.NaujaSaka(10));
            medis.root.sakos[1].sakos[1].sakos.Add(medis.NaujaSaka(10));
            medis.root.sakos[1].sakos[1].sakos[0].sakos.Add(medis.NaujaSaka(10));

            Console.Write((medis.Gylis()) + "\n");
            Console.ReadKey();
        }
    }
}
