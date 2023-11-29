using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Librerias.Ejercicio1
{
    class Ejercicio1
    {
    public static double CalculateAngle(Vector2 vector1, Vector2 vector2)
        {
            double angleRadians = Math.Atan2(vector2.Y, vector2.X) - Math.Atan2(vector1.Y, vector1.X);

            // Ajusta el ángulo para que esté entre 0 y 2*pi (360 grados)
            if (angleRadians < 0)
            {
                angleRadians += 2 * Math.PI;
            }

            return angleRadians;
        }
    }
}
