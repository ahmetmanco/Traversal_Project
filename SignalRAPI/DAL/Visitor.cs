namespace SignalRAPI.DAL
{
    public enum ECity
    {
        İstanbul = 1,
        Ankara = 2,
        İzmir = 3,
        Bursa = 4,
        Manisa = 5,
        Antalya = 6
    }
    public class Visitor
    {
        public int Id { get; set; }
        public ECity City { get; set; }
        public int CityVisitCount { get; set; }
        public DateTime VisitDate { get; set; }
    }
}
