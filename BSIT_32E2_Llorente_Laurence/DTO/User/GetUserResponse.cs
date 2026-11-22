namespace BSIT_32E2_Llorente_Laurence.DTO.User
{
    public class GetUsersResponse
    {
        public List<GetUserDTO> Users { get; set; }
        public int TotalCount => Users?.Count ?? 0;
    }

    public class GetUserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}