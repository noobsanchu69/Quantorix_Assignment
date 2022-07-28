namespace crudapplication.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Debit_Card Card { get; set; }
        public long CardNo { get; set; }
    }
}