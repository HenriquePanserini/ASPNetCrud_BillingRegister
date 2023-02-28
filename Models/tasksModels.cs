namespace CRUDRegister.Models
{
    public class tasksModels
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public Int32? Status { get; set; }
    }
}
