﻿using System;
using System.Collections.Generic;

namespace ProjectRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangles = new List<Rectangle>();

            GetRectangles(rectangles);

            for (int i = 0; i < rectangles.Count; i++)
            {
                for (int j = i + 1; j < rectangles.Count; j++)
                {
                    if (Rectangle.IsOverLapping(rectangles[i], rectangles[j]))
                        Console.WriteLine($"Rectangles {i + 1} and {j + 1} are over lapping");
                    else
                        Console.WriteLine($"Rectangles {i + 1} and {j + 1} are over not lapping");
                }

            }
            Console.ReadKey();
        }

        //adding the user input to the list which is a type of rectangle using GetPoint
        private static void GetRectangles(List<Rectangle> rectangles)
        {
            do
            {
                var rectangle = new Rectangle();
                Console.WriteLine("Entering the Coordinates for Topleft Point");
                GetPoint(rectangle.TopLeft);

                Console.WriteLine("Entering the Coordinates for Bottomright Point");
                GetPoint(rectangle.BottomRight);

                if (rectangle.IsValid())
                {
                    rectangles.Add(rectangle);
                }
                else
                {
                    Console.WriteLine("Invalid Rectangle input");
                }

                Console.WriteLine("Do you want to add one more Rectangle ? Y/N");


            } while (Console.ReadLine().ToUpper() == "Y");

        }

        //Getting user inputs
        private static void GetPoint(Point point)
        {
            Console.WriteLine("Enter X");
            point.X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Y");
            point.Y = Convert.ToInt32(Console.ReadLine());
        }
    }
}
