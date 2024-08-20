namespace AutomapperWebAPIProject.dto {
    public class UserDto 
    {
        public required string Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public int Age { get; set; }
        public required string Email { get; set; } 
        public required string Name { get; set; }
        // public required string DerivedProperty { get; set; }
    }
}