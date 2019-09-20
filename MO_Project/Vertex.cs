using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace MO_Project
{
    class Vertex
    {
        private double posX;
        private double posY;
        private List<Vertex> parentVertices;
        private List<Vertex> inheritorVertices;
        private string name;
        private int value;
        /// <summary>
        /// Конструктор без параметров, который создает вершину с координатами (0;0),
        /// стандартным именем и весом 1.
        /// </summary>
        public Vertex ()
        {
            posX = 0;
            posY = 0;
            name = "vertex";
            value = 1;
        }
        /// <summary>
        /// Конструктор, который создаёт вершину с координатами (x;y),
        /// стандартным именем и весом 1
        /// </summary>
        /// <param name="x">Координата по оси Х</param>
        /// <param name="y">Координата по оси У</param>
        public Vertex (double x, double y)
        {
            posX = x;
            posY = y;
            name = "vertex";
            value = 1;
        }
    }
}
