﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace Account_book.API.Domain.Entity;

public partial class Member
{
    /// <summary>
    /// PK 會員編號
    /// </summary>
    public Guid MemberId { get; set; }

    /// <summary>
    /// 會員名稱
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 會員帳號 為電子信箱
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// 登入用密碼
    /// </summary>
    public string Password { get; set; }
}