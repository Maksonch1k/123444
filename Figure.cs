using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public abstract class Figure
    {

    
        private string _name;

        public Figure(string name)
        {
            _name = name;
        }

        public string Name => _name;

        public abstract double Area();
        public abstract double Perimeter();

        public virtual void Print()
        {
            Console.WriteLine($"Figure: {_name}");
        }
    }
    


    




    }

