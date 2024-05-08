﻿using Account_book.API.Domain.Entity;
using Account_book.API.Domain.Request.Get;
using Account_book.API.Domain.Request.Post;
using AutoMapper;

namespace Account_book.API.Domain.AutoMapperProfile;

public class MemberProfile : Profile
{
    public MemberProfile() 
    {
        CreateMap<QueryMemberRequest, Member>();
        CreateMap<InsertMemberRequest, Member>();
    }
}
