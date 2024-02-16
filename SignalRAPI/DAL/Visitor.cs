namespace SignalRAPI.DAL
{
    public enum ECity
    {
        Manisa = 1,
        İstanbul = 2,
        Ankara = 3,
        İzmir = 4,
        Bursa = 5
    }
    public class Visitor
    {
        public int Id { get; set; }
        public ECity City { get; set; }
        public int CityCount { get; set; }
        public DateTime VisitDate { get; set; }
    }
}
