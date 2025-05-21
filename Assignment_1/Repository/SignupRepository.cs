using System;
using Assignment_1.Data;
using Assignment_1.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment_1.Repository;

public class SignupRepository : ISignupRepository
{
    private readonly AppDbContext _context;
    public SignupRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task SaveSignupAsync(SignupEntity signupEntity)
    {
        _context.Signups.Add(signupEntity);
        await _context.SaveChangesAsync();
    }

    public async Task<List<SignupEntity>> GetSignupListAsync()
    {
        return await _context.Signups.ToListAsync();
    }
}
