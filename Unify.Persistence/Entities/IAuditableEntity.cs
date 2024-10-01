namespace Unify.Persistence.Entities
{
    public interface IAuditableEntity
    {
        public DateTime? DateModified { get; set; }
        public string? ModifiedBy { get; set; }
        public string? ModifiedByIp { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedByIp { get; set; }
    }
}
