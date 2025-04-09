using System.Dynamic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace PaintShop;

// 1 - Crie uma classe Wall
public class Wall
{
    
    public double _width;
    public double Width 
    {
        get {return _width;}
        
        set 
        {
            if (value > 0)
            {
                _width = value;
            }
            else if (value <=0 )
            {
                value = 1;  
                _width = value;
            }
        }
    }
    public double _height;
    public double Height
    {
        get {return _height;}

            set { 
                if (value > 0)
                {
                _height = value;
                }
                    else if (_height <=0)
                {
                    value = 1;
                    _height = value;
                }
        }   
    }
    public double ExcludedArea{get;set;}
    public double PaintableArea
    {
        get 
        {
            return (_width * _height) - ExcludedArea;
        }
    }
    
    public Wall(double width, double height)
    {
    Width = width;
    Height = height;
    }
}