using System;
using Assignment_1.Models;

namespace Assignment_1.Repository;

public interface ISignupRepository
{
    Task SaveSignupAsync(SignupEntity signupEntity);
    Task<List<SignupEntity>> GetSignupListAsync();
}
