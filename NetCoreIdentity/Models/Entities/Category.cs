namespace NetCoreIdentity.Models.Entities
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public decimal Description { get; set; }

        //Relational Properties

        public virtual List<Product> Products { get; set; }
    }
}
