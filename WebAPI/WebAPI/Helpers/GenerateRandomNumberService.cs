namespace WebAPI.Helpers
{
    public class GenerateRandomNumberService
    {
        public int CurrentValue { get; set; }

        public void Generate()
        {
            var random = new Random();
            CurrentValue = random.Next(10, 100);
        }
    }
}
