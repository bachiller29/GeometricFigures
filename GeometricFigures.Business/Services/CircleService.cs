using GeometricFigures.Business.Interfaces.Services;
using GeometricFigures.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures.Business.Services
{
    public class CircleService : ICircleService
    {
        public double CircleArea(Circle circle)
        {
            try
            {
                double radio = Double.Parse(circle.radio);
                var area = circle.pi * Math.Pow(radio, 2);
                return area;
            }
            catch (Exception)
            {

                throw new Exception("Error convirtiendo el valor de radio, este numero debe ser decimal");
            }


        }
    }
}
