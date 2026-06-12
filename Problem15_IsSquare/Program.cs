// See https://aka.ms/new-console-template for more information
var isSquare = IsSquare(new Coordinate(20, 10), new  Coordinate(10, 20), 
    new Coordinate(20, 20), new Coordinate(10, 10));

Console.WriteLine(isSquare ? "Item is square" : "Item is not square");

isSquare = IsSquare(new Coordinate(2, 1), new  Coordinate(10, 20), 
    new Coordinate(5, 6), new Coordinate(10, 10));

Console.WriteLine(isSquare ? "Item is square" : "Item is not square");

return;



int DistanceSquare(Coordinate coordinate1, Coordinate coordinate2)
{
    var xDelta = coordinate1.X - coordinate2.X;
    var yDelta = coordinate1.Y - coordinate2.Y;
    
    return xDelta * xDelta + yDelta * yDelta;
}

bool IsSquare(Coordinate coordinate1, Coordinate coordinate2,
    Coordinate coordinate3, Coordinate coordinate4)
{
    var referenceCoordinate = coordinate1;
    
    var distanceSqrCoordinate2 = DistanceSquare(referenceCoordinate, coordinate2);
    var distanceSqrCoordinate3 = DistanceSquare(referenceCoordinate, coordinate3);
    var distanceSqrCoordinate4 = DistanceSquare(referenceCoordinate, coordinate4);

    if (distanceSqrCoordinate2 == distanceSqrCoordinate3)
    {
        return distanceSqrCoordinate2 + distanceSqrCoordinate3 == distanceSqrCoordinate4;
    }
    
    if (distanceSqrCoordinate3 == distanceSqrCoordinate4)
    {
        return distanceSqrCoordinate3 + distanceSqrCoordinate4 == distanceSqrCoordinate2;
    }
    
    if (distanceSqrCoordinate4 == distanceSqrCoordinate2)
    {
        return distanceSqrCoordinate4 + distanceSqrCoordinate2 == distanceSqrCoordinate3;
    }
    
    return false;
}

public record Coordinate (int X, int Y);