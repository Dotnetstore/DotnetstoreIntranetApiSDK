namespace SDK;

public static class ApiEndpoints
{
    private const string ApiBase = "/api";
    
    public static class Organization
    {
        public static class Users
        {
            private const string UserBase = $"{ApiBase}/users";
        
            public const string GetAll = UserBase;
            public const string Create = UserBase;
        }
        
        public static class UserRoles
        {
            private const string UserRoleBase = $"{ApiBase}/user-roles";
        
            public const string GetAll = UserRoleBase;
            public const string Create = UserRoleBase;
        }
    }
}