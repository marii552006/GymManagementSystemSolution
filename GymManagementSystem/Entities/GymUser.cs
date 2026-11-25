using GymManagementSystem.Entities.Enums;

namespace GymManagementSystem.Entities
{
    public class GymUser : BaseEntity
    {
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;
        public DateTime DateOfBirth { get; set; } = default!;
        public Gender Gender { get; set; }
        public Address Address { get; set; } = default!;
    }
}
