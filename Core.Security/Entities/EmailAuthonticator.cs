using Core.Persistence.Repositories;

namespace Core.Security.Entities;

public class EmailAuthonticator : Entity<int>
{
    public int UserId { get; set; }
    public string? ActivationKey { get; set; }
    public bool IsVerified { get; set; }
    public virtual User User { get; set; } = null!;

    public EmailAuthonticator() { }
    public EmailAuthonticator(int userId,bool isVerified)
    {
        UserId = userId;
        IsVerified = isVerified;
    }
    public EmailAuthonticator(int id, int userId, bool isVerified) : base(id)
    {
        UserId = userId;
        IsVerified = isVerified;
    }
}
