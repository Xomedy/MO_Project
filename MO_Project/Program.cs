using System;
using static System.Console;
using System.Collections.Generic;

namespace MO_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Vertex vrt1 = new Vertex(0.9, 0.3, "", 1);
            List<Vertex> lvp = new List<Vertex> { new Vertex(13, 13), new Vertex(81, 81) };
            List<Vertex> lvc = new List<Vertex> { new Vertex(19, 19), new Vertex(89, 89) };
            Vertex vrt2 = new Vertex(1, 1, "V1", null ,lvc ,lvp);
            WriteLine(vrt2.ToString());
        }
    }
}
