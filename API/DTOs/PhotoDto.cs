namespace API.DTOs
{
    public class PhotoDto
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public bool IsMain { get; set; }
        // gf PhotoManagementChallenge
        public bool IsApproved { get; set; }
    }
}