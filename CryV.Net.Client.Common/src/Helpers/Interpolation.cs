using System;
using System.Numerics;

namespace CryV.Net.Client.Common.Helpers
{
    public static class Interpolation
    {

        public static float LerpDegrees(float start, float end, float amount)
        {
            var difference = Math.Abs(end - start);
            if (difference > 180)
            {
                if (end > start)
                {
                    start += 360;
                }
                else
                {
                    end += 360;
                }
            }

            var value = (start + (end - start) * amount);
            const int rangeZero = 360;

            if (value >= 0 && value <= 360)
            {
                return value;
            }

            return (value % rangeZero);
        }

        public static float Lerp(float start, float end, float amount)
        {
            amount = Math.Clamp(amount, 0, 1);

            return start + (end - start) * amount;
        }

        public static Vector3 LerpRotation(Vector3 start, Vector3 end, float amount)
        {
            return new Vector3(LerpDegrees(start.X, end.X, amount), LerpDegrees(start.Y, end.Y, amount), LerpDegrees(start.Z, end.Z, amount));
        }

    }
}
