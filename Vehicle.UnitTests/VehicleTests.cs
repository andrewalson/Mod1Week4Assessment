namespace Vehicle.UnitTests
{
    public class VehicleTests
    {
        [Fact]
        public void WhenCreated_HasCorrectProperties()
        {
            Vehicle megansCar = new Vehicle(4, "Green");

            Assert.Equal(4, megansCar.NumberOfWheels);
            Assert.Equal("Green", megansCar.Color);
            Assert.Equal(0, megansCar.MilesDriven);
        }

        // This test needs some work!
        [Fact]
        public void Summary_ReturnsInfoAboutVehicle()
        {
            Vehicle andysBike = new Vehicle(2, "Blue");

            var expected = "This Blue vehicle has 2 wheels, and has driven 0 miles.";
            Assert.Equal(andysBike.Summary(), expected);
        }

        [Fact]
        public void DriveMethod_AddsFiveMiles_ToIntMilesDriven()
        {
            Vehicle andrewsCar = new Vehicle(4, "Red");
            andrewsCar.Drive();
            Assert.Equal(5, andrewsCar.MilesDriven);
        }

        [Fact]
        public void PaintMethod_SetsStringColor_AsNewColor()
        {
            Vehicle andrewsCar = new Vehicle(4, "Red");
            andrewsCar.Paint("Hot pink");
            Assert.Equal("Hot pink", andrewsCar.Color);
        }
    }
}