namespace PaintShop;

// 3 - Crie uma classe estática PaintUtilities
public static class PaintUtilities
{
    public static int SquareMetersPerLiter {get;set;} = 10;
    public static int BucketSizeLiters {get;set;} = 20;

    
    public static int SquareMetersPerBucket 
    {
        get 
        {
         return SquareMetersPerLiter * BucketSizeLiters;
        }
    }
    
    public static int GetNeededPaintBuckets(double area) 
    {
        double BucketsNeeded = area / SquareMetersPerBucket;
        return (int)Math.Ceiling(BucketsNeeded);
    }

    public static int GetNeededPaintBuckets(Wall wall) {
         return GetNeededPaintBuckets(wall.PaintableArea);
    }

    public static int GetNeededPaintBuckets(Room room) {
         return GetNeededPaintBuckets(room.TotalPaintableArea);
    }

    public static decimal CalculateCost(decimal price, double area) 
    {
    return price * GetNeededPaintBuckets(area);
    }

    public static decimal CalculateCost(decimal price, Wall wall) {
       return price * GetNeededPaintBuckets(wall);
    }

    public static decimal CalculateCost(decimal price, Room room) {
       return price * GetNeededPaintBuckets(room);
    }
}