namespace NhsWebDemo.Models
{
    public class LocalUserMapModel
    {
        public int Id { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
        public string Title { get; set; }
        public string PointTime { get; set; }
        public bool IsComplete { get; set; }
        public bool IsLate  { get; set; }
        public bool IsTravel { get; set; }
        public bool LastLocation { get; set; }
        public int ZIndex { get; set; }
    }
}
