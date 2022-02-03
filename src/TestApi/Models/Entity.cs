namespace TestApi.Models
{
    public class Entity
    {
        public int Id { get; set; } 
        public string? Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime Created { get; set; }
    }
}
