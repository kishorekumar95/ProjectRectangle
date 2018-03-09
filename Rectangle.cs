using System;

namespace ProjectRectangle
{
    public class Rectangle
    {
        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }

        public Rectangle()
        {
            TopLeft = new Point();
            BottomRight = new Point();
        }

        //for validating the user inputs
        public bool IsValid()
        {
            if (TopLeft.Y != BottomRight.Y && TopLeft.X != BottomRight.X)
            {
                return true;
            }
            return false;
        }
        
        //For checking the rectangles are overlapping are not 
        //returns true for overlapping
        public static bool IsOverLapping(Rectangle rectangle1, Rectangle rectangle2)
        {
            if (rectangle1.TopLeft.X > rectangle2.BottomRight.X || rectangle2.TopLeft.X > rectangle1.BottomRight.X)
                return false;
            if (rectangle1.TopLeft.Y < rectangle2.BottomRight.Y || rectangle2.TopLeft.Y < rectangle1.BottomRight.Y)
                return false;
            return true;
        }
    }
}