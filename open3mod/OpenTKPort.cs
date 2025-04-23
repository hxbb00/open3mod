using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace open3mod
{
    internal static class OpenTKPort
    {
        public static void Transform(ref Vector3 vec, ref Matrix4 mat, out Vector3 result)
        {
            Vector4 vector = new Vector4(vec.X, vec.Y, vec.Z, 1f);
            Vector4.Transform(ref vector, ref mat, out vector);
            result = vector.Xyz;
        }
    }
}
