namespace CarRentalManagement.Domain
{
    public abstract class BaseDomainModel
    {
        public int Id { get; set; }     //MUSTT be big "I" and small "d". #NOTE
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public string? CreatedBy { get; set; }    // the ? in the string is to tell that CreatedBy can be nullable
        public string? UpdatedBy { get; set; }
    }
}
