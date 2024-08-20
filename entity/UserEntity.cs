
namespace AutomapperWebAPIProject.entity {

   public class UserEntity
   {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; } 

        public UserEntity(string id, string firstName, string lastName, int age, string email)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Email = email;
        }
    }
}