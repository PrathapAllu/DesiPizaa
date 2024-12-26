namespace DesiPizza;

public class OrderWithStatus
{
    public readonly static TimeSpan PreparationDuration = TimeSpan.FromSeconds(10);
    public readonly static TimeSpan DeliveryDuration = TimeSpan.FromMinutes(1); // Unrealistic, but more interesting to watch

    // Set from DB
    public Order Order { get; set; } = null!;

    // Set from Order
    public string StatusText { get; set; } = null!;

    public bool IsDelivered => StatusText == "Delivered";

    private static LatLong ComputeStartPosition(Order order)
    {
        ArgumentNullException.ThrowIfNull(order.DeliveryLocation);
        // Random but deterministic based on order ID
        var rng = new Random(order.OrderId);
        var distance = 0.01 + rng.NextDouble() * 0.02;
        var angle = rng.NextDouble() * Math.PI * 2;
        var offset = (distance * Math.Cos(angle), distance * Math.Sin(angle));
        return new LatLong(order.DeliveryLocation.Latitude + offset.Item1, order.DeliveryLocation.Longitude + offset.Item2);
    }
}