using System;
using System.Collections.Generic;
using System.Linq;
namespace File_Reader
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\rupawar\Documents\PointOfInterestCoordinatesList.txt";
            FileOpeartion opeartion = new FileOpeartion();
            string[] lines = opeartion.FileReader(filePath);
            MongoDB db = new MongoDB("Region");
            db.InsertRecord("Point_Of_Intersect_Coordinate", lines);
        }
    }
}
