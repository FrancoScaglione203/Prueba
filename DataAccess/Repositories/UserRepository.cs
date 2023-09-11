﻿using Microsoft.EntityFrameworkCore;
using Prueba.DataAccess.Repositories.Interfaces;
using Prueba.DTOs;
using Prueba.Entities;

namespace Prueba.DataAccess.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {

        public UserRepository(ApplicationDbContext context) : base(context)
        {

        }


        public async Task<User?> AuthenticateCredentials(AuthenticateDto dto)
        {
            return await _context.Users.SingleOrDefaultAsync(x => x.Email == dto.Email && x.Password == dto.Password);
        }
    }
}
