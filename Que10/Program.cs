﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum FilePermission
{
    None = 0,
    Read = 1 << 0,
    Write = 1 << 1,
    Execute = 1 << 2
}

class Program
{
    static void Main(string[] args)
    {

        FilePermission userPermissions = FilePermission.Read | FilePermission.Write;


        bool canRead = userPermissions.HasFlag(FilePermission.Read);
        bool canWrite = userPermissions.HasFlag(FilePermission.Write);
        bool canExecute = userPermissions.HasFlag(FilePermission.Execute);

        Console.WriteLine("User Permissions:");
        Console.WriteLine($"Can Read: {canRead}");
        Console.WriteLine($"Can Write: {canWrite}");
        Console.WriteLine($"Can Execute: {canExecute}");


        FilePermission anotherUserPermissions = FilePermission.Read | FilePermission.Execute;

        Console.WriteLine("\nAnother User Permissions:");
        Console.WriteLine($"Can Read: {anotherUserPermissions.HasFlag(FilePermission.Read)}");
        Console.WriteLine($"Can Write: {anotherUserPermissions.HasFlag(FilePermission.Write)}");
        Console.WriteLine($"Can Execute: {anotherUserPermissions.HasFlag(FilePermission.Execute)}");
        Console.Read();
    }
}