namespace RadzenStudioBlazorServer.Models
{
    public class TestModel
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string TestProperty { get; set; } = "Test Model string";
        public double TestPropertyDouble { get; set; } = 4.2;
    }
}
