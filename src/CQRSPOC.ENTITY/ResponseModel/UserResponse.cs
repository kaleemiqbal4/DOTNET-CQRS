namespace CQRSPOC.ENTITY.ResponseModel;

public class UserResponse
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }

    public string Contact { get; set; }
}

public class UserResponseList { 
    public List<UserResponse>  UserResponses {  get; set; }
}