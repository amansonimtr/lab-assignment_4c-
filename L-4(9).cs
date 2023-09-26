using System;

[Flags]
public enum FileAccessPermission
{
    None = 0,
    Read = 1,
    Write = 2,
    Execute = 4
}

public class User
{
    public string Username { get; set; }
    public FileAccessPermission Permissions { get; set; }

    public User(string username, FileAccessPermission permissions)
    {
        Username = username;
        Permissions = permissions;
    }

    public bool HasPermission(FileAccessPermission requiredPermission)
    {
        return (Permissions & requiredPermission) == requiredPermission;
    }
}

class Program
{
    static void Main()
    {
        User user1 = new User("User1", FileAccessPermission.Read | FileAccessPermission.Write);
        User user2 = new User("User2", FileAccessPermission.Write | FileAccessPermission.Execute);

        bool hasReadWritePermission = user1.HasPermission(FileAccessPermission.Read | FileAccessPermission.Write);
        Console.WriteLine($"User1 has Read and Write permissions: {hasReadWritePermission}");

        bool hasExecutePermission = user2.HasPermission(FileAccessPermission.Execute);
        Console.WriteLine($"User2 has Execute permission: {hasExecutePermission}");
    }
}
