using FluentValidation;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class AccountController : ControllerBase         
{
    private readonly IAccountService _accountService;

    public AccountController(IAccountService accountService)
    {
        _accountService=accountService;
    }
    [HttpPost]
    public async Task<Account> CreateNewAccount(Account account)
    {
        Account accountresult = new Account()
        {
            Email = account.Email,
            Password = account.Password,
            IsBlocked= account.IsBlocked,
            //Visibility= account.Visibility
        };
        return await _accountService.CreateNewAccount(accountresult);
    }

        
    
    [HttpPut("update")]
    public async Task<Account> UpdateAccountByEmail(Account account,string email)
    {
        var result = await _accountService.UpdateAccountByEmail(account,email); 
        return result;   
    }

    [HttpGet("getall")]
    public async Task<List<Account>> GetAll()
    {
       var allAccounts= await _accountService.GetAllAccounts();  
       return allAccounts;
    }
    [HttpGet("getbyemail")]
    public async Task<Account> GetAccountByEmail(string email)
    {
        var result = await _accountService.GetAccountByEmail(email);
        return result;
    }
    [HttpDelete("deleteaccount")]
    public async Task<Account> ChangeVisibilityOfAccount(string email)
    {
        var visibility=await _accountService.DeleteAccountByEmail(email);
        return visibility;
    }
    
    [HttpPut("blockaccount")]
    public async Task<Account> BlockAccountByEmail(string email)
    {
        var blocking=await _accountService.BlockAccountByEmail(email);
        return blocking;
    }

}