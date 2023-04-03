namespace OdontoProject.API.Dto
{
    public class OdontoCareDTO
    {
        public string Name { get; set; }
        public List<string> Procedures { get; set; } = new List<string>();
    }
}
