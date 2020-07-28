namespace AbstractFactory
{
    class HondaFactory : IVehicleFactory
    {
        public IBike GetBike(string bike)
        {
            switch (bike)
            {
                case "Sports":
                    return new SportsBike();
                default:
                    return null;
            }
        }
    }
}
