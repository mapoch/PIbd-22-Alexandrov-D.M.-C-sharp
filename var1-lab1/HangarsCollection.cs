using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var1_lab1
{
    class HangarsCollection
    {
        readonly Dictionary<string, Hangar<Vehicle>> hangarStages;

        public List<string> Keys => hangarStages.Keys.ToList();

        private readonly int pictureWidth;
        private readonly int pictureHeight;

        public HangarsCollection(int pictureWidth, int pictureHeight)
        {
            hangarStages = new Dictionary<string, Hangar<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        public void AddParking(string name)
        {
            if (hangarStages.ContainsKey(name)) return;
            hangarStages.Add(name, new Hangar<Vehicle>(pictureWidth, pictureHeight));
        }

        public void DelParking(string name)
        {
            if (hangarStages.ContainsKey(name)) hangarStages.Remove(name);
        }

        public Hangar<Vehicle> this[string ind]
        {
            get { if (hangarStages.ContainsKey(ind)) return hangarStages[ind];
                else return null;
            }
        }
    }
}
