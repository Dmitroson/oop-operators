using System;

namespace FractionLibrary
{
    public class Fraction
    {
        long Numerator, Denominator;

        public Fraction()
        {
            Numerator = 1;
            Denominator = 1;
        }

        public Fraction(long numerator, long denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
            Fix();
        }

        public Fraction(long value)
        {
            Numerator = value;
            Denominator = 1;
        }

        //public Fraction(double value)
        //{

        //}

        public static Fraction operator +(Fraction obj)
        {
            return obj;
        }

        public static Fraction operator -(Fraction obj)
        {
            obj.Numerator = -obj.Numerator;
            return obj;
        }

        public static Fraction operator ++(Fraction obj)
        {
            obj.Numerator += obj.Denominator;
            obj.Simplicity();
            return obj;
        }

        public static Fraction operator --(Fraction obj)
        {
            obj.Numerator -= obj.Denominator;
            obj.Simplicity();
            return obj;
        }

        public static Fraction operator +(Fraction obj1, Fraction obj2)
        {
            long lcm = LCM(obj1.Denominator, obj2.Denominator);
            Fraction result = new Fraction(obj1.Numerator * (lcm / obj1.Denominator) + obj2.Numerator * (lcm / obj2.Denominator), lcm);
            result.Simplicity();
            return result;
        }

        public static Fraction operator +(Fraction obj1, long value)
        {
            Fraction obj2 = new Fraction(value);
            long lcm = LCM(obj1.Denominator, obj2.Denominator);
            Fraction result = new Fraction(obj1.Numerator * (lcm / obj1.Denominator) + obj2.Numerator * (lcm / obj2.Denominator), lcm);
            result.Simplicity();
            return result;
        }

        public static Fraction operator +(long value, Fraction obj1)
        {
            Fraction obj2 = new Fraction(value);
            long lcm = LCM(obj1.Denominator, obj2.Denominator);
            Fraction result = new Fraction(obj1.Numerator * (lcm / obj1.Denominator) + obj2.Numerator * (lcm / obj2.Denominator), lcm);
            result.Simplicity();
            return result;
        }

        public static Fraction operator -(Fraction obj1, Fraction obj2)
        {
            long lcm = LCM(obj1.Denominator, obj2.Denominator);
            Fraction result = new Fraction(obj1.Numerator * (lcm / obj1.Denominator) - obj2.Numerator * (lcm / obj2.Denominator), lcm);
            result.Simplicity();
            return result;
        }

        public static Fraction operator -(Fraction obj1, long value)
        {
            Fraction obj2 = new Fraction(value);
            long lcm = LCM(obj1.Denominator, obj2.Denominator);
            Fraction result = new Fraction(obj1.Numerator * (lcm / obj1.Denominator) - obj2.Numerator * (lcm / obj2.Denominator), lcm);
            result.Simplicity();
            return result;
        }

        public static Fraction operator -(long value, Fraction obj2)
        {
            Fraction obj1 = new Fraction(value);
            long lcm = LCM(obj1.Denominator, obj2.Denominator);
            Fraction result = new Fraction(obj1.Numerator * (lcm / obj1.Denominator) - obj2.Numerator * (lcm / obj2.Denominator), lcm);
            result.Simplicity();
            return result;
        }

        public static Fraction operator *(Fraction obj1, Fraction obj2)
        {
            Fraction result = new Fraction(obj1.Numerator * obj2.Numerator, obj1.Denominator * obj2.Denominator);
            result.Simplicity();
            return result;
        }

        public static Fraction operator *(Fraction obj1, long value)
        {
            Fraction result = new Fraction(obj1.Numerator * value, obj1.Denominator);
            result.Simplicity();
            return result;
        }

        public static Fraction operator *(long value, Fraction obj1)
        {
            Fraction result = new Fraction(obj1.Numerator * value, obj1.Denominator);
            result.Simplicity();
            return result;
        }

        public static Fraction operator /(Fraction obj1, Fraction obj2)
        {
            Fraction result = obj1 * !obj2;
            result.Simplicity();
            return result;
        }

        public static Fraction operator /(Fraction obj1, long value)
        {
            Fraction obj2 = new Fraction(value);
            Fraction result = obj1 * !obj2;
            result.Simplicity();
            return result;
        }

        public static Fraction operator /(long value, Fraction obj1)
        {
            Fraction result = value * !obj1;
            result.Simplicity();
            return result;
        }

        public static Fraction operator !(Fraction obj)
        {
            return new Fraction(obj.Denominator, obj.Numerator);
        }

        public static bool operator ==(Fraction obj1, Fraction obj2)
        {
            if ((double)obj1 == (double)obj2) return true;
            else return false;
        }

        public static bool operator !=(Fraction obj1, Fraction obj2)
        {
            if ((double)obj1 != (double)obj2) return true;
            else return false;
        }

        public static bool operator >(Fraction obj1, Fraction obj2)
        {
            if ((double)obj1 > (double)obj2) return true;
            else return false;
        }

        public static bool operator <(Fraction obj1, Fraction obj2)
        {
            if ((double)obj1 < (double)obj2) return true;
            else return false;
        }

        public static bool operator >=(Fraction obj1, Fraction obj2)
        {
            if ((double)obj1 >= (double)obj2) return true;
            else return false;
        }

        public static bool operator <=(Fraction obj1, Fraction obj2)
        {
            if ((double)obj1 <= (double)obj2) return true;
            else return false;
        }

        public static explicit operator double(Fraction obj)
        {
            return obj.Numerator / obj.Denominator;
        }

        public static long GCD(long value1, long value2)
        {
            if (value2 == 0) return value1;
            return GCD(value2, value1 % value2);
        }

        public static long LCM(long value1, long value2)
        {
            return value1 / GCD(value1, value2) * value2;
        }

        public void Simplicity()
        {
            long gcd = GCD(Numerator, Denominator);
            Numerator /= gcd;
            Denominator /= gcd;
        }

        public void Fix()
        {
            if(((Numerator < 0) && (Denominator < 0)) || ((Numerator > 0) && (Denominator < 0)))
            {
                Numerator = -Numerator;
                Denominator = -Denominator;
            }
        }

        public override string ToString()
        {
            return Numerator + "/" + Denominator;
        }
    }
}