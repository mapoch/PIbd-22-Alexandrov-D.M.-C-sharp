using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
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

        private readonly char separator = ':';

        public HangarsCollection(int pictureWidth, int pictureHeight)
        {
            hangarStages = new Dictionary<string, Hangar<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        public void AddHangar(string name)
        {
            if (hangarStages.ContainsKey(name)) return;
            hangarStages.Add(name, new Hangar<Vehicle>(pictureWidth, pictureHeight));
        }

        public void DelHangar(string name)
        {
            if (hangarStages.ContainsKey(name)) hangarStages.Remove(name);
        }

        public Hangar<Vehicle> this[string ind]
        {
            get
            {
                if (hangarStages.ContainsKey(ind)) return hangarStages[ind];
                else return null;
            }
        }

        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                sw.Write($"HangarsCollection{Environment.NewLine}");
                foreach (var level in hangarStages)
                {
                    sw.Write($"Hangar{separator}{level.Key}{Environment.NewLine}");
                    foreach (ITransport plane in level.Value)
                    {
                        if (plane != null)
                        {
                            if (plane.GetType().Name == "Plane")
                            {
                                sw.Write($"Plane{separator}");
                            }
                            if (plane.GetType().Name == "Plane_bomber")
                            {
                                sw.Write($"Plane_bomber{separator}");
                            }
                            sw.Write(plane + Environment.NewLine);
                        }
                    }
                }
                sw.Close();
            }
        }

        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            StreamReader sr = new StreamReader(filename, Encoding.UTF8);

            string line = sr.ReadLine();

            if (line.Contains("HangarsCollection"))
            {
                hangarStages.Clear();
            }
            else
            {
                throw new ArgumentException();
            }

            Vehicle plane = null;
            string key = string.Empty;

            while((line = sr.ReadLine()) != null)
            {
                if (line.Contains("Hangar"))
                {
                    key = line.Split(separator)[1];
                    hangarStages.Add(key, new Hangar<Vehicle>(pictureWidth, pictureHeight));
                    continue;
                }
                if (string.IsNullOrEmpty(line))
                {
                    continue;
                }
                if (line.Split(separator)[0] == "Plane")
                {
                    plane = new Plane(line.Split(separator)[1]);
                }
                else if (line.Split(separator)[0] == "Plane_bomber")
                {
                    plane = new Plane_bomber(line.Split(separator)[1]);
                }
                var result = hangarStages[key] + plane;
                if (result == -1)
                {
                    throw new HangarOverflowException();
                }
            }
        }
    }
}
