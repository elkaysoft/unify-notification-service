namespace Unify.Persistence.Entities
{
    public class BaseEntity
    {
        public long Id { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsDeleted { get; set; }
    }
}
