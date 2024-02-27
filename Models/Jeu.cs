using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgMaker.Models
{
    internal class Jeu
    {

        public List<Monstre> listDeMonstres = new List<Monstre>();
        public void RandomList() {

            for (int i = 0; i < 10; i++)
            {
                Monstre monstre = new Monstre();
               int random = new Random().Next(1,7);
              
                switch (random)
                {
                    case 1:
                        monstre = new Gobelin();
                        monstre.Initialize();
                        this.listDeMonstres.Add(monstre);
                        break;
                    case 2:
                        monstre = new Gobelin();
                        monstre.Initialize();
                        this.listDeMonstres.Add(monstre);
                        break;
                    case 3:
                        monstre = new Gobelin();
                        monstre.Initialize();
                        this.listDeMonstres.Add(monstre);
                        break;
                    case 4:
                        monstre = new Loup();
                        monstre.Initialize();
                        this.listDeMonstres.Add(monstre);
                        break;
                    case 5:
                        monstre = new Loup();
                        monstre.Initialize();
                        this.listDeMonstres.Add(monstre);
                        break;
                    case 6:
                        monstre = new Orc();
                        monstre.Initialize();
                        this.listDeMonstres.Add(monstre);
                        break;
                    default:
                        break;
                }
            }
            

        }
    }
}
