using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_and_Inheritance_Task_2
{
    public class Box
    {
        private double _length;
        private double _width;
        private double _height;
     
        public Box(double length, double width, double height) //конструктор
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
            
        }

        public double Length
        {
            get { return this._length; }
            private set 
            {
                if (value <= 0) 
                {  
                    throw new ArgumentException("Length cannot be zero or a negative number!"); 
                }
                this._length = value; 
            }
        }
        public double Width 
        { 
            get { return this._width; }
            private set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or a negative number!");
                }
                this._width = value; 
            }

        }
        public double Height
        { 
            get { return this._height; }
            private set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or a negative number!");
                }
                this._height = value; 
            }
        }

        //след това викаме от темплейта на софтуни методите които смятат повърхността


        public override string ToString()
        {
            return $"Surface Area - {this.SurfaceArea()}{Environment.NewLine}Volume - {this.Volume()}"; //this.SurfaceArea() и this.Volume() са
                                                                                                        //методи от темплейта на софтуни
        }
    }
}
