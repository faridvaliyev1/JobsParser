namespace JobsParser.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }

        public Site Site { get; set; }
    }
}
