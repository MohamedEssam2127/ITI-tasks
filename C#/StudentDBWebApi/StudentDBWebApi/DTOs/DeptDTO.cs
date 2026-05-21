namespace StudentDBWebApi.DTOs
{
    public class DeptDTO
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public List<string> StudentNames { get; set; } = new List<string>();
        public int Count { get; set; }
        public string Message { get; set; }
    }
}
