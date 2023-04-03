namespace OdontoProject.API.Entity
{
    public class OdontoCare
    {
        public Guid UserId { get; set; }
        public List<Guid> Procedures { get; set; }
    }
}
