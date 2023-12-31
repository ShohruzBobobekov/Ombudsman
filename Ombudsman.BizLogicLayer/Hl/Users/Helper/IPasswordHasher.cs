﻿namespace Ombudsman.BizLogicLayer.Users;

public interface IPasswordHasher
{
    string CreatePasswordHash(string password, string salt);
    bool CheckPassword(string hashedPassword, string password, string salt);
}
