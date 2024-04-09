namespace VirtualizationSample.Models
{
    public class SampleItem
    {
        public int Id { get; set; }
        public string Summary { get; set; }

        public SampleItem(int id)
        {
            Id = id;
            Summary = $"Item id: {id}";
        }
    }
}
