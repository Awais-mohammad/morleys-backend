namespace morleys_backend.Models.Dto
{
    public class AddUserDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } // Consider using a separate class for secure password handling
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Role { get; set; }
    }

}
