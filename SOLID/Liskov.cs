using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class Liskov
    {
        /// <summary>
        /// 
        /// </summary>
        public class Rectangle
        {
            public virtual int Height{get;set;}
            public virtual int Width { get; set; }
            public int Perim() 
            {
                return 2 * Height + 2 * Width;
            }
        }
        public class Square : Rectangle
        {
            public override int Height { get => base.Height; set => { Width = value; Height = value; } }
            public override int Width { get => base.Width; set => { Width = value; Height = value; } }


        }
        /// <summary>
        /// 
        /// </summary>
        public class Rectangle1
        {
            protected int height;
            protected int width;
            public int Perim()
            {
                return 2 * height + 2 * width;
            }
            public Rectangle1(int height, int width)
            {
                this.height = height;
                this.width = width;
            }
        }
        public class Square1 : Rectangle1
        {
            public Square1(int length ) : base (length, length)
            {
                
            }
        }
    }

}
 