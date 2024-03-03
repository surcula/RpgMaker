using RpgMaker.Models.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgMaker.Models.Monstres
{
    public class Loup : Monstre
    {
        public override int Strength { get { return base.Strength + 2; } }
        public override int Endurance { get { return base.Endurance + 1; } }

        public override De arme { get => base.arme; set => base.arme = value; }

        public Loup()
        {
           Initialize();
        }
        protected override void Initialize()
        {
            base.Initialize();
            arme = new De(1, 6);
        }

        public void Morsure()
        {
            Console.WriteLine("Le loup mord !");
        }

        public void Hurlement()
        {
            Console.WriteLine("Le loup hurle !");
        }

    }
}
