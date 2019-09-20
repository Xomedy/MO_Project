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
        private List<Vertex> childVertices;
        private string name;
        private int? weight;

        /// <summary>
        /// Конструктор без параметров, который создает вершину с координатами (0;0),
        /// стандартным именем и весом 1.
        /// </summary>
        public Vertex ()
        {
            posX = 0;
            posY = 0;
            name = "vertex";
            weight = 1;
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
            weight = 1;
        }

        /// <summary>
        /// Конструктор, который создаёт вершину с координатами (х;у),
        /// заданным именем и весом
        /// </summary>
        /// <param name="x">Координата по оси Х</param>
        /// <param name="y">Координата по оси У</param>
        /// <param name="name">Имя вершины</param>
        /// <param name="weight">Вес вершины</param>
        public Vertex (double x, double y, string name, int? weight)
        {
            posX = x;
            posY = y;
            this.name = name;
            this.weight = weight;
        }

        /// <summary>
        /// Конструктор, который создаёт вершину с координатами (х;у),
        /// заданным именем, весом, списком вершин потомков и родителей
        /// </summary>
        /// <param name="x">Координата по оси Х</param>
        /// <param name="y">Координата по оси У</param>
        /// <param name="name">Имя вершины</param>
        /// <param name="weight">Вес вершины</param>
        /// <param name="childs">Список вершин-потомков данной вершины.</param>
        /// <param name="parents">Список вершин-родителей данной вершины.</param>
        public Vertex (double x, double y, string name, int? weight, List<Vertex> childs, List<Vertex> parents)
        {
            posX = x;
            posY = y;
            this.name = name;
            this.weight = weight;
            parentVertices = parents;
            childVertices = childs;
        }

        /// <summary>
        /// Координата Х
        /// </summary>
        public double PositionX { get { return posX; } set { posX = value; } }

        /// <summary>
        /// Координата У
        /// </summary>
        public double PositionY { get { return posY; } set { posY = value; } }

        /// <summary>
        /// Имя вершины
        /// </summary>
        public string Name { get { return name; } set { name = value; } }

        /// <summary>
        /// Вес вершины
        /// </summary>
        public int? Weight { get { return weight; } set { weight = value; } }

        /// <summary>
        /// Получить список вершин-родителей данной вершины
        /// </summary>
        public List<Vertex> GetParents { get { return parentVertices; } }

        /// <summary>
        /// Получить список вершин-потомков данной вершины
        /// </summary>
        public List<Vertex> GetChilds { get { return childVertices; } }

        /// <summary>
        /// Добавляет вершину в список вершин-потомков
        /// </summary>
        /// <param name="child">Вершина потомок</param>
        public void AddChildVertex(Vertex child)
        {
            childVertices.Add(child);
        }

        /// <summary>
        /// Добавляет вершину в список вершин-родителей
        /// </summary>
        /// <param name="parent">Вершина родитель</param>
        public void AddParentVertex(Vertex parent)
        {
            parentVertices.Add(parent);
        }

        /// <summary>
        /// Удаляет вершину из списка вершин-потомков
        /// </summary>
        /// <param name="child">Вершина потомок</param>
        public void RemoveChildVertex(Vertex child)
        {
            childVertices.Remove(child);
        }

        /// <summary>
        /// Удаляет вершину из списка вершин-родителей
        /// </summary>
        /// <param name="parent">Вершина родитель</param>
        public void RemoveParentVertex(Vertex parent)
        {
            parentVertices.Remove(parent);
        }

        public override string ToString()
        {
            string outs = $"Координаты вершины (х;у): ({posX.ToString()};{posY.ToString()})" +
                $"\nИмя вершины: {name}";

            if (weight == null)
                outs += $"\nВес вершины: не имеет веса";
            else
                outs += $"\nВес вершины: {weight}";

            List<Vertex> parents = GetParents;
            outs += $"\nВершины-родитель:";
            for (int i = 0; i < parents.Count; i++)
            {
                outs += $"\n      {parents[i].Name}";
            }

            List<Vertex> childs = GetChilds;
            outs += $"\nВершины-потомки:";
            for (int i = 0; i < childs.Count; i++)
            {
                outs += $"\n      {childs[i].Name}";
            }

            return outs;
        }

        public virtual string ToShortString()
        {
            string outs = $"Координаты вершины (х;у): ({posX.ToString()};{posY.ToString()})" +
                $"\nИмя вершины: {name}";

            if (weight == null)
                outs += $"\nВес вершины: не имеет веса";
            else
                outs += $"\nВес вершины: {weight}";

            return outs;
        }
    }
}
