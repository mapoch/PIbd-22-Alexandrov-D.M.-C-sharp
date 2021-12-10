using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var1_lab1
{
    public class PlaneComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            if (x.GetType() != y.GetType())
            {
                if (x is Plane && y is Plane_bomber) return -1;
                else return 1;
            }

            if (x.GetType().Name.Equals("Plane")) return ComparerPlane((Plane)x, (Plane)y);
            if (x.GetType().Name.Equals("Plane_bomber")) return ComparerBomberPlane((Plane_bomber) x, (Plane_bomber) y);

            return 0;
        }

        private int ComparerPlane(Plane x, Plane y)
        {
            if (x.Max_Speed != y.Max_Speed)
            {
                return x.Max_Speed.CompareTo(y.Max_Speed);
            }
            if (x.Load_Weight != y.Load_Weight)
            {
                return x.Load_Weight.CompareTo(y.Load_Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }

        private int ComparerBomberPlane(Plane_bomber x, Plane_bomber y)
        {
            var res = ComparerPlane(x, y);
            if (res != 0)
            {
                return res;
            }

            if (x.AddColor != y.AddColor)
            {
                return x.AddColor.Name.CompareTo(y.AddColor.Name);
            }
            if (x.Back_state != y.Back_state)
            {
                return x.Back_state.CompareTo(y.Back_state);
            }
            if (x.Bombs_state != y.Bombs_state)
            {
                return x.Bombs_state.CompareTo(y.Bombs_state);
            }
            return 0;
        }
    }
}
