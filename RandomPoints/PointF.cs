using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPoints
{
    public class PointF
    {
        public float Cx { get; set; }
        public float Cy { get; set; }

        public PointF(float x, float y)
        {
            Cx = x;
            Cy = y;
        }

        public override string ToString()
        {
            return String.Format("({0}, {1})", Cx.ToString("0.0000"), Cy.ToString("0.0000"));
        }

    }
}
