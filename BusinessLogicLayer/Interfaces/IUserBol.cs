﻿using GFStore.ApplicationLayer.Dto;
using GFStore.ApplicationLayer.Dto.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GFStore.BusinessLogicLayer.Interfaces
{
    public interface IUserBol
    {
       
        IEnumerable<UserDto> GetAll();
        UserDto GetById(int id);

        UserCreatedResponse CreateUser(UserDto user);

        UserCreatedResponse CreateAdmin(UserDto user);
        void Update(UserDto user, string password = null);
        void Delete(int id);
        AuthenticatedUserResponse Authenticate(string username, string password);
    }
}
