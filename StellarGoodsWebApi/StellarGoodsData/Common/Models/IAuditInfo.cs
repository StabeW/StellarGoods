namespace StellarGoodsData.Common.Models
{
    public interface IAuditInfo
    {
        DateTime CreatedOn { get; }

        DateTime? ModifiedOn { get; set; }
    }
}