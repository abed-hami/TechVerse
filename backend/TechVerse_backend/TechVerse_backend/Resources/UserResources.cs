namespace TechVerse_backend.Resources
{
    public class UserResources
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Password { get; set; } = null!;

        public string Location { get; set; } = null!;

        public DateOnly DateOfBirth { get; set; }

        public int Balance { get; set; }

        public int Points { get; set; }
    }
}
