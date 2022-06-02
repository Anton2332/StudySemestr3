using System;

namespace _9
{
    class Rectangle
    {
        string id;
        double width, height, cordinatesx1, cordinatesy1, cordinatesx2, cordinatesy2;

        public Rectangle(string str)
        {
            var strRectangle = str.Split(" ");
            id = strRectangle[0];
            width = Convert.ToDouble(strRectangle[1]);
            height = Convert.ToDouble(strRectangle[2]);
            cordinatesx1 = Convert.ToDouble(strRectangle[3]);
            cordinatesy1 = Convert.ToDouble(strRectangle[4]);
            cordinatesx2 = cordinatesx1 + width;
            cordinatesy2 = cordinatesy1 + height;
        }
        public string ID 
        {
            set { id = value; }
            get { return id; }
        }
        public double Cordinatesx1
        {
            set { cordinatesx1 = value; }
            get { return cordinatesx1; }
        }

        public double Cordinatesx2
        {
            set { cordinatesx2 = value; }
            get { return cordinatesx2; }
        }

        public double Cordinatesy1
        {
            set { cordinatesy1 = value; }
            get { return cordinatesy1; }
        }

        public double Cordinatesy2
        {
            set { cordinatesy2 = value; }
            get { return cordinatesy2; }
        }


    }
    class Program
    {
        

        static public bool intersect1(Rectangle a,Rectangle b)
        {
            if ((a.Cordinatesx1 >= b.Cordinatesx1 && a.Cordinatesy1 >= b.Cordinatesy1) && (a.Cordinatesx2 >= b.Cordinatesx2 && a.Cordinatesy2 >= b.Cordinatesy2))
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            
            var str = Console.ReadLine().Split(" ");
            int n, m;
            n = Convert.ToInt32(str[0]);
            m = Convert.ToInt32(str[1]);
            string str1;
            Rectangle[] rectangles = new Rectangle[n];
            for(int i = 0; i < n; i++)
            {
                str1 = Console.ReadLine();
                rectangles[i] = new Rectangle(str1);
            }
            int k1 = 0, k2 = 0;
            for(int i = 0; i < m; i++)
            {
                str = Console.ReadLine().Split(" ");
                for(int j = 0; j < n; j++)
                {
                    if (str[0] == rectangles[i].ID)
                        k1 = i;

                    if (str[1] == rectangles[i].ID)
                        k2 = i;
                }
                Console.WriteLine(intersect1(rectangles[k1], rectangles[k2]));
            }


        }
    }
}
