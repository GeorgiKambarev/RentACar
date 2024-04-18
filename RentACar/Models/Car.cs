namespace RentACar.Models
{
    public class Car
    {
        public Guid Id { get; set; }

        public string Brand { get; set; } = null!;

        public string Model { get; set; } = null!;

        public string Year { get; set; } = null!;

        public int Seats { get; set; }

        public string Description { get; set; } = null!;

        public decimal priceForADay { get; set; }
    }
}
