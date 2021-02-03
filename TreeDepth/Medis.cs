using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDepth
{
    class Medis
    {
        public Saka root { get; set; }
        public int Gylis()
        {
            return HighestDepth(root);
        }
        //Rekursija.Ggražina aukšti(gyli) nuo nurodytos šakos
        private int HighestDepth(Saka saka)
        {
            //patikrina ar madis netuščias ir jei netuščias iškart priskiria aukšti 1
            if (saka == null)
                return 0;
            int deepest =1;

            // suranda sakos gyli ir išsaugo ilgiausią šaką, galima daryti ir su foreach
            for (int i = 0; i < saka.sakos.Count; i++)
            {
                int maxDepth = 1+ HighestDepth(saka.sakos[i]);
                deepest = (maxDepth > deepest) ? maxDepth : deepest;

            }
            return deepest;
        }
        //Sukuria nauja  šaka
        public Saka NaujaSaka(int key)
        {
            Saka temp = new Saka();
            temp.Name = key;
            temp.sakos = new List<Saka>();
            return temp;
        }
               
        
        public class Saka
        {
            public int Name { get; set; }
            public List<Saka> sakos;
        }
    }
}
