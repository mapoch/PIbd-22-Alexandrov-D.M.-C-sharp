using System;
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

        public bool SaveData(string filename)
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
                    ITransport plane = null;
                    for (int i = 0; (plane = level.Value.GetNext(i)) != null; i++)
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
                return true;
            }
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            string bufferTextFromFile = "";
            StreamReader sr;
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                sr = new StreamReader(fs, Encoding.UTF8);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    bufferTextFromFile += line + Environment.NewLine;
                }
                sr.Close();
            }
            bufferTextFromFile = bufferTextFromFile.Replace("\r", "");
            var strs = bufferTextFromFile.Split('\n');
            if (strs[0].Contains("HangarsCollection"))
            {
                hangarStages.Clear();
            }
            else
            {
                return false;
            }
            Vehicle plane = null;
            string key = string.Empty;
            for (int i = 1; i < strs.Length; ++i)
            {
                if (strs[i].Contains("Hangar"))
                {
                    key = strs[i].Split(separator)[1];
                    hangarStages.Add(key, new Hangar<Vehicle>(pictureWidth, pictureHeight));
                    continue;
                }
                if (string.IsNullOrEmpty(strs[i]))
                {
                    continue;
                }
                if (strs[i].Split(separator)[0] == "Plane")
                {
                    plane = new Plane(strs[i].Split(separator)[1]);
                }
                else if (strs[i].Split(separator)[0] == "Plane_bomber")
                {
                    plane = new Plane_bomber(strs[i].Split(separator)[1]);
                }
                var result = hangarStages[key] + plane;
                if (result == -1)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
