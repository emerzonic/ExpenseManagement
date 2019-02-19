﻿using System;
using ExpenseManagement.Models;
using Microsoft.AspNetCore.Identity;

namespace ExpenseManagement.Service
{
    public interface IRoleService
    {
        void CreateRole(string roleName);
        IdentityRole GetRole(string roleName);
    }
}
