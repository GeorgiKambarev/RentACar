namespace RentACar.Models
{
    public class Request
    {
        public Guid Id { get; set; } 
        public Car? SelectedCar { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; } 
        public User? ReqUser { get; set; }
    }
}
