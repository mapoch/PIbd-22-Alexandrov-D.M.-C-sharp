using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var1_lab1
{
    class HangarsCollection
    {
        readonly Dictionary<string, Hangar<Vehicle>> formationStages;

        public List<string> Keys => formationStages.Keys.ToList();

        private readonly int pictureWidth;
        private readonly int pictureHeight;

        public HangarsCollection(int pictureWidth, int pictureHeight)
        {
            formationStages = new Dictionary<string, Hangar<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        public void AddParking(string name)
        {
            if (formationStages.ContainsKey(name)) return;
            formationStages.Add(name, new Hangar<Vehicle>(pictureWidth, pictureHeight));
        }

        public void DelParking(string name)
        {
            if (formationStages.ContainsKey(name)) formationStages.Remove(name);
        }

        public Hangar<Vehicle> this[string ind]
        {
            get { if (formationStages.ContainsKey(ind)) return formationStages[ind];
                else return null;
            }
        }
    }
}
