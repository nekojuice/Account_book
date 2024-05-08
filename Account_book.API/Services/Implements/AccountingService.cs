﻿using Account_book.API.Domain.Request.Get;
using Account_book.API.Repositories.Interfaces;
using Account_book.API.Services.Interfaces;
using Account_book.API.Domain.Entity;
using AutoMapper;
using Account_book.API.Domain.Response;
using Account_book.API.Domain.Request.Post;
using Account_book.API.Domain.Request.Put;

namespace Account_book.API.Services.Implements;

public class AccountingService : IAccountingService
{
    private readonly IAccountingRepository _accountingRepository;
    private readonly IMapper _mapper;
    public AccountingService(IAccountingRepository accountingRepository, IMapper mapper)
    {
        _accountingRepository = accountingRepository;
        _mapper = mapper;
    }

    public async Task<ResultResponse> GetAsync(QueryAccountingRequest? request)
    {
        var entity = _mapper.Map<Accounting>(request);
        var result = await _accountingRepository.GetAsync(entity);
        return ResponseExtension.Query.QuerySuccess(result);
    }

    public async Task<ResultResponse> GetByMemberIdAsync(Guid memberId)
    {
        var result = await _accountingRepository.GetByMemberIdAsync(memberId);
        return ResponseExtension.Query.QuerySuccess(result);
    }

    public async Task<ResultResponse> InsertAsync(InsertAccountingRequest request)
    {
        var entity = _mapper.Map<Accounting>(request);
        var result = await _accountingRepository.InsertAsync(entity);
        if (!result) return ResponseExtension.Command.InsertFail();
        return ResponseExtension.Command.InsertSuccess();
    }

    public async Task<ResultResponse> UpdateAsync(PutAccountingRequest request)
    {
        var entity = _mapper.Map<Accounting>(request);
        var result = await _accountingRepository.UpdateAsync(entity);
        if (!result) return ResponseExtension.Command.UpdateFail();
        return ResponseExtension.Command.UpdateSuccess();
    }

    public async Task<ResultResponse> DeleteAsync(Guid accountingId)
    {
        var result = await _accountingRepository.DeleteAsync(accountingId);
        if (!result) return ResponseExtension.Command.DeleteFail();
        return ResponseExtension.Command.DeleteSuccess();
    }
}
