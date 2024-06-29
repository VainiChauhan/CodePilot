namespace CodePilot.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string SampleInput { get; set; }
        public string SampleOutput { get; set; }
        public string Language { get; set; }
    }
}
