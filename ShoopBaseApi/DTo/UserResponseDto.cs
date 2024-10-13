namespace ShoopBaseApi.DTo
{
    public class UserResponseDto
    {
        public string Message { get; set; } = null!;

        public int Status { get; set; }
        public bool IsSuccess { get; set; }
        public string FristName { get; set; }

        public string LastName { get; set; }
        public string Images { get; set; }
        public long ID_User { get; set; }

    }
}
