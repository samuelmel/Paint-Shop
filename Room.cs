using System.Dynamic;

namespace PaintShop;

//classe Room
public class Room
{
    public Wall[] walls{get;}
    public double TotalPaintableArea
    {
        get
        {
            double total = 0;
            foreach (var wall in walls)
            {
                total += wall.PaintableArea;
            }
            return total;
        }
    }
    public Room(params Wall[] walls)
    {
        this.walls = walls; 
    }
}