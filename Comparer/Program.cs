

namespace Comparer {
    class Program
    {
        static void Main(string[] args)
        {
            //khởi tạo list các instance của box
            List<Box> Boxes = new List<Box>();
            // add các instance vào list
            Boxes.Add(new Box(4, 20, 14));
            Boxes.Add(new Box(12, 12, 12));
            Boxes.Add(new Box(8, 20, 10));
            Boxes.Add(new Box(6, 10, 2));
            Boxes.Add(new Box(2, 8, 4));
            Boxes.Add(new Box(2, 6, 8));
            Boxes.Add(new Box(4, 12, 20));
            Boxes.Add(new Box(18, 10, 4));
            Boxes.Add(new Box(24, 4, 18));
            Boxes.Add(new Box(10, 4, 16));
            Boxes.Add(new Box(10, 2, 10));
            Boxes.Add(new Box(6, 18, 2));
            Boxes.Add(new Box(8, 12, 4));
            Boxes.Add(new Box(12, 10, 8));
            Boxes.Add(new Box(14, 6, 6));
            Boxes.Add(new Box(16, 6, 16));
            Boxes.Add(new Box(2, 8, 12));
            Boxes.Add(new Box(4, 24, 8));
            Boxes.Add(new Box(8, 6, 20));
            Boxes.Add(new Box(18, 18, 12));

       
            Boxes.Sort(new BoxLengthFirst());

            Console.WriteLine("H - L - W");
            Console.WriteLine("==========");
            foreach (Box bx in Boxes)
            {
                Console.WriteLine("{0}\t{1}\t{2}",
                    bx.Height.ToString(), bx.Length.ToString(),
                    bx.Width.ToString());
            }

            Console.WriteLine();
            Console.WriteLine("H - L - W");
            Console.WriteLine("==========");

          
         

        
            Boxes.Sort();

            foreach (Box bx in Boxes)
            {
                Console.WriteLine("{0}\t{1}\t{2}",
                    bx.Height.ToString(), bx.Length.ToString(),
                    bx.Width.ToString());
            }



            BoxLengthFirst LengthFirst = new BoxLengthFirst();

            

            Box BoxA = new Box(2, 6, 8);
            Box BoxB = new Box(10, 12, 14);
            int x = LengthFirst.Compare(BoxA, BoxB);
            Console.WriteLine();
            Console.WriteLine(x.ToString());
        }
    }
    // Xắp xếp với độ ưu tiên length
    public class BoxLengthFirst : Comparer<Box>
    {
        // So sán theo length, height, width
        public override int Compare(Box x, Box y)
        {
            if (x.Length.CompareTo(y.Length) != 0)
            {
                return x.Length.CompareTo(y.Length);
            }
            else if (x.Height.CompareTo(y.Height) != 0)
            {
                return x.Height.CompareTo(y.Height);
            }
            else if (x.Width.CompareTo(y.Width) != 0)
            {
                return x.Width.CompareTo(y.Width);
            }
            else
            {
                return 0;
            }
        }
    }

    // xắp xếp với độ ưu tiên height trước
    public class BoxComp : IComparer<Box>
    {
        // So sán theo length, height, width
        public int Compare(Box x, Box y)
        {
            if (x.Height.CompareTo(y.Height) != 0)
            {
                return x.Height.CompareTo(y.Height);
            }
            else if (x.Length.CompareTo(y.Length) != 0)
            {
                return x.Length.CompareTo(y.Length);
            }
            else if (x.Width.CompareTo(y.Width) != 0)
            {
                return x.Width.CompareTo(y.Width);
            }
            else
            {
                return 0;
            }
        }
    }

    //IComparable là là một interface trong C# cho phép sắp xếp các đối tượng của một lớp hoặc struct thông qua một thuộc tính hoặc phương thức của lớp đó
    //Nó giúp định nghĩa một phương thức CompareTo() cho phép so sánh hai đối tượng của cùng một lớp để xác định đối tượng nào lớn hơn hay nhỏ hơn.
    // Box là class chính để sử dụng thao tác xắp xếp
    public class Box : IComparable<Box>
    {

        public Box(int h, int l, int w)
        {
            this.Height = h;
            this.Length = l;
            this.Width = w;
        }
        public int Height { get; private set; }
        public int Length { get; private set; }
        public int Width { get; private set; }

        public int CompareTo(Box other)
        {
            // Compares Height, Length, and Width.
            if (this.Height.CompareTo(other.Height) != 0)
            {
                return this.Height.CompareTo(other.Height);
            }
            else if (this.Length.CompareTo(other.Length) != 0)
            {
                return this.Length.CompareTo(other.Length);
            }
            else if (this.Width.CompareTo(other.Width) != 0)
            {
                return this.Width.CompareTo(other.Width);
            }
            else
            {
                return 0;
            }
        }
    }
}