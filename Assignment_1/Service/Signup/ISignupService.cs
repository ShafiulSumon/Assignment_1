using System;
using Assignment_1.DTOs;

namespace Assignment_1.Service;

public interface ISignupService
{
    Task SignupAsync(SignupDTO signupDTO);
    Task<List<SignupDTO>> GetSignupList();
}
