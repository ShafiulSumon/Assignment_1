using System;
using Assignment_1.DTOs;
using Assignment_1.Models;
using Assignment_1.Repository;
using Assignment_1.Service.Notification;

namespace Assignment_1.Service;

public class SignupService : ISignupService
{
    private readonly ISignupRepository _signupRepository;
    private readonly INotificationService _notificationService;

    public SignupService(ISignupRepository signupRepository, INotificationService notificationService)
    {
        _signupRepository = signupRepository;
        _notificationService = notificationService;
    }
    public async Task SignupAsync(SignupDTO signupDTO)
    {
        var signupEntity = new SignupEntity
        {
            UserName = signupDTO.Fullname,
            Email = signupDTO.Email,
            Password = HashPassword(signupDTO.Password),
            CreatedAt = DateTime.UtcNow,
        };
        await _signupRepository.SaveSignupAsync(signupEntity);
        await _notificationService.NotificationThroughEmail(signupDTO.Email);
    }

    public async Task<List<SignupDTO>> GetSignupList()
    {
        var signupList = await _signupRepository.GetSignupListAsync();
        var signupDTOList = new List<SignupDTO>();
        foreach (var signup in signupList)
        {
            var signupDTO = new SignupDTO(signup.UserName, signup.Email, signup.Password);
            signupDTOList.Add(signupDTO);
        }
        return signupDTOList;
    }

    private string HashPassword(string password)
    {
        return password;
    }
}
