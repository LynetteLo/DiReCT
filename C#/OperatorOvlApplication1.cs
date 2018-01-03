using System;

namespace OperatorOvlApplication1
{

    class Box
    {
        private double length;
        private double breadth;
        private double height;

        public double getVolume()
        {
            return length * breadth * height;
        }
        public void setLength(double len)
        {
            length = len;
        }
        public void setBreadth(double bre)
        {
            breadth = bre;
        }
        public void setHeight(double hei)
        {
            height = hei;
        }
        public static Box operator +(Box b, Box c)
        {
            Box box = new Box();

            box.length = b.length + c.length;

            box.breadth = b.breadth + c.breadth;

            box.height = b.height + c.height;

            return box;
        }
        public static bool operator ==(Box lhs, Box rhs)
        {

            bool status = false;
            if (lhs.length == rhs.length && lhs.height == rhs.height && lhs.breadth == rhs.breadth)
            {
                status = true;
            }
            return status;

        }
        public static bool operator !=(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length != rhs.length || lhs.height != rhs.height || lhs.breadth != rhs.breadth)
            {
                status = true;
            }
            return status;
        }
        public static bool operator <(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length < rhs.length && lhs.height < rhs.height && lhs.breadth < rhs.breadth)
            {
                status = true;
            }
            return status;

        }
        public static bool operator >(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length > rhs.length && lhs.height > rhs.height && lhs.breadth > rhs.breadth)
            {
                status = true;
            }
            return status;
        }
        public static bool operator <=(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length <= rhs.length && lhs.height <= rhs.height && lhs.breadth <= rhs.breadth)
            {
                status = true;
            }
            return status;
        }
        public static bool operator >=(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length >= rhs.length && lhs.height >= rhs.height && lhs.breadth >= rhs.breadth)
            {
                status = true;
            }
            return status;
        }
        public override string ToString()
        {
            return String.Format("({0},{1},{2})", length, breadth, height);
        }

    }
    class Tester
    {
        static void Main(string[] args)
        {
            Box Box1 = new Box();

            Box Box2 = new Box();
            Box Box3 = new Box();

            Box Box4 = new Box();
            double volume =0.0;

            Box1.setLength(6.0);
            Box1.setBreadth(7.0);
            Box1.setHeight(5.0);

            Box2.setLength(12.0);
            Box2.setBreadth(13.0);
            Box2.setHeight(10.0);

            Console.WriteLine("Box 1: {0}", Box1.ToString());
            Console.WriteLine("Box 2: {0}", Box2.ToString());

            volume = Box1.getVolume();
            Console.WriteLine("Volume of Box1 : {0}", volume);

            volume = Box2.getVolume();
            Console.WriteLine("Volume of Box2 : {0}", volume);

            Box3 = Box1 + Box2;
            Console.WriteLine("Box3 : {0}", Box3.ToString());

            volume = Box3.getVolume();
            Console.WriteLine("Volume of Box3 : {0}", volume);

            if (Box1 > Box2)
                Console.WriteLine("Box1 is greater than Box2");
            else
                Console.WriteLine("Box1 is greater than Box2");
            if (Box1 < Box2)
                Console.WriteLine("Box1 is less than Box2");
            else
                Console.WriteLine("Box1 is not less than Box2");
            if (Box1 >= Box2)
                Console.WriteLine("Box1 is greater or equal to Box2");
            else
                Console.WriteLine("Box1 is not greater or equal to Box2");
            if (Box1 <= Box2)
                Console.WriteLine("Box1 is less or equal to Box2");
            else
                Console.WriteLine("Box1 is not less or equal to Box2");
            if (Box1 != Box2)
                Console.WriteLine("Box1 is not equal to Box2");
            else
                Console.WriteLine("Box1 is not greater or equal to Box2");
            Box4 = Box3;
            if (Box3 == Box4)
                Console.WriteLine("Box3 is equal to Box4");
            else
                Console.WriteLine("Box3 is not equal to Box4");
            Console.ReadKey();




        }
    }



}