﻿using Account_book.API.Domain.Request.Get;
using Account_book.API.Services.Interfaces;
using Account_book.API.Domain.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Account_book.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AccountingController : ControllerBase
{
    private readonly IAccountingService _accountingService;
    public AccountingController(IAccountingService accountingService)
    {
        _accountingService = accountingService;
    }

    [HttpGet]
    public async Task<IEnumerable<Accounting>> Get([FromQuery] Guid memberId)
    {
        var result = await _accountingService.GetByMemberIdAsync(memberId);
        return result;
    }
}