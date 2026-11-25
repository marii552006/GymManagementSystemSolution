namespace GymManagementSystem.Entities
{
    public class Member:GymUser
    {
    public string? photo { get; set; }
    public ICollection<MemberShip> MemberShips { get; set; } = new HashSet<MemberShip>();
    }
}
