using GeometricFigures.Business.Interfaces.Services;
using GeometricFigures.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures.Business.Services
{
    public class RectangleServices : IRectangleService
    {

        public int RectangleArea(Rectangle rectangle)
        {
            try
            {
                int basis = Int32.Parse(rectangle.basis);
                int height = Int32.Parse(rectangle.height);
                var result = basis * height;
                return result;
            }
            catch (Exception)
            {
                throw new Exception("Error converting basis or height, these numbers must be decimal.");
            }
           
        }
    }
}
