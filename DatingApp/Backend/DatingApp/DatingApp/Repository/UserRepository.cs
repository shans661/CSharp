using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using DatingApp.API;
using DatingApp.API.Helpers;
using DatingApp.DTOs;
using DatingApp.Interfaces;
using DatingDatingApp.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DataBaseContext m_Context;
        private readonly IMapper m_Mapper;
        public UserRepository(DataBaseContext context, IMapper mapper)
        {
            m_Context = context;
            m_Mapper = mapper;
        }

        public async Task<PagedList<MemberDTO>> GetAllMembersAsync(UserParams userParams)
        {
            var minAge = DateTime.Now.AddYears(-userParams.MinAge - 1);
            var maxAge = DateTime.Now.AddYears(-userParams.MaxAge);

            //Filter the data skip current user and opposite gender
            var query = m_Context.User.Where(x => x.UserName != userParams.CurrentUserName
            && x.Gender == userParams.Gender
            && x.DateOfBirth <= minAge
            && x.DateOfBirth >= maxAge)
                .ProjectTo<MemberDTO>(m_Mapper.ConfigurationProvider).AsNoTracking();

            //Shorthand switch operation
            query = userParams.OrderBy switch
            {
                "created" => query.OrderByDescending(x => x.Created),
                _ => query.OrderByDescending(x => x.LastActive)
            };
               
            return await PagedList<MemberDTO>.CreateAsync(query, userParams.PageNumber, userParams.PageSize);
        }

        public async Task<IEnumerable<AppUser>> GetAllUsersAsync()
        {
            return await m_Context.User.ToListAsync();
        }

        public async Task<MemberDTO> GetMemberByNameAsync(string username)
        {
            var member = await m_Context.User.ProjectTo<MemberDTO>(m_Mapper.ConfigurationProvider).
            FirstOrDefaultAsync(x => x.UserName == username);

            return member;
        }

        public async Task<AppUser> GetUserByIdAsync(int id)
        {
            return await m_Context.User.
            Include(x => x.Photos).
            FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<AppUser> GetUserByNameAsync(string username)
        {
            return await m_Context.User.
            Include(x => x.Photos).
            FirstOrDefaultAsync(x => x.UserName == username);
        }

        public async Task<bool> SaveAllAsync()
        {
            return await m_Context.SaveChangesAsync() > 0;
        }

        public void Update(AppUser user)
        {
            m_Context.Entry(user).State = EntityState.Modified;
        }
    }
}