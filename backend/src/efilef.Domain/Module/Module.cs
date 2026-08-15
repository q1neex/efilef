namespace efilef.Domain.Module
{
    public class Module
    {
        public Guid Id { get; set; }

        public string Title { get; set; } = null!;

        public string Description { get; set; } = null!;

        public List<Issue> Issues { get; set; } = [];

        public int NumberOfIssues => Issues.Count;

    }
    public class File
    {
        public Guid Id { get; set; }

        public string Path { get; set; } = default!;


    }
}
