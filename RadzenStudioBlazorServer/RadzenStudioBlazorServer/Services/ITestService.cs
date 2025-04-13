using RadzenStudioBlazorServer.Models;

namespace RadzenStudioBlazorServer.Services
{
    public interface ITestService
    {
        ICollection<TestModel> Models { get; set; }
        string TestProperty { get; set; }
        Task<string> TestFunction();
    }
}
