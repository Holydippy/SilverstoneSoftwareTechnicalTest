namespace BlazorTestingApp.Client.Utils
{
    public class MemoryStorageUtility
    {
        public MemoryStorageUtility()
        {
            
        }
        public Dictionary<string, object> Storage { get; set; } = new();
    }
}
