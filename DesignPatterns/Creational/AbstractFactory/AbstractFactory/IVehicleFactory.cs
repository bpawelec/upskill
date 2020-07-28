namespace AbstractFactory
{
    public interface IVehicleFactory
    {
        IBike GetBike(string bike);
    }
}
