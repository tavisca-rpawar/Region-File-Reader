using System;
using System.IO;
namespace File_Reader
{
    public class FileOpeartion
    {
        string[] lines;
        public string[] FileReader(string filePath)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(filePath))
                {
                    streamReader.ReadLine();
                    lines = streamReader.ReadToEnd().Split('\n');
                    return lines;
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            return null;
        }
        //public string[] ReadLine()
        //{
        //    //Console.WriteLine("lines" + lines[0]);
        //    return lines;

        //    //foreach (var line in lines)
        //    //{
        //    //    string[] entries = line.Split('|');
        //    //    Region region = new Region();
        //    //    //region.RegionID = long.Parse(entries[0]);
        //    //    //region.RegionName = entries[1];
        //    //    //region.RegionNameLong = entries[2];
        //    //    //region.Latitude = double.Parse(entries[3]);
        //    //    //region.Longitude = double.Parse(entries[4]);
        //    //    //region.SubClassification = entries[5];
        //    //}
        //}
    }
}
