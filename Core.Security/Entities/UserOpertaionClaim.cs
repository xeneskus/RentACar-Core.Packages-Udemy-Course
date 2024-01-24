using Core.Persistence.Repositories;

namespace Core.Security.Entities;

public class UserOpertaionClaim:Entity<int>
{
    public int UserId { get; set; }
    public int OperationClaimId { get; set; }

    public virtual User User { get; set; }
    public virtual OperationClaim OperationClaim { get; set; }

    public UserOpertaionClaim(int userId, int operationClaimId)
    {
        UserId = userId;
        OperationClaimId = operationClaimId;
    }
    public UserOpertaionClaim(int id, int userId,int operationClaimId) : base(id)
    {
        UserId = userId;
        OperationClaimId = operationClaimId;
    }
}
