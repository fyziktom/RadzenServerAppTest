using RadzenStudioBlazorServer.Models;

namespace RadzenStudioBlazorServer.Services
{
    public class TestService : ITestService
    {
        public ICollection<TestModel> Models { get; set; } = new List<TestModel>();
        public string TestProperty { get; set; } = "This is test string...";

        public async Task<string> TestFunction()
        {
            Models.Add(new TestModel()
            {
                Id = Guid.NewGuid().ToString(),
                TestProperty = "Test Model string",
                TestPropertyDouble = 4.2
            });
            Models.Add(new TestModel()
            {
                Id = Guid.NewGuid().ToString(),
                TestProperty = "Test Model string 1",
                TestPropertyDouble = 7.3
            });

            return "This is a test function...";
        }
    }
}
