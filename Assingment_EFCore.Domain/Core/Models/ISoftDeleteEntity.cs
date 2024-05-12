namespace Assingment_EFCore.Domain.Core.Models
{
    public interface ISoftDeleteEntity
    {
        public bool IsDeleted { get; set; }
    }
}