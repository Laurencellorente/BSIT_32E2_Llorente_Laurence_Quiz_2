namespace BSIT_32E2_Llorente_Laurence.DTO.User
{
    public class GetUserByIDResponse
    {
        public GetUserDTO? User { get; set; }
        public List<GetUserGroupDTO> UserGroups { get; set; } = new();
    }

    public class GetUserGroupDTO
    {
        public int UserId { get; set; }
        public int GroupId { get; set; }
    }
}