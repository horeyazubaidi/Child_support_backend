namespace GazaChildSupport.Controllers
{
    public class UserResponse
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
      
        public string PhoneNumber { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}