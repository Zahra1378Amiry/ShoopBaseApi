namespace ShoopBaseApi.DTo
{
    public class ErorrLogDto
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public List<string> Errors { get; set; }
    }
}
