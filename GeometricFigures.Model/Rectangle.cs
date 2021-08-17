using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GeometricFigures.Model
{
    public class Rectangle : Figure
    {
        public string basis { get; set; }
        public string height { get; set; }

    }
}
