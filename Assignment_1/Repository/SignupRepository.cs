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
        try
        {
            var existingUser = await _context.Signups.FirstOrDefaultAsync(u => u.Email == signupEntity.Email);
            if (existingUser != null)
            {
                Console.WriteLine("This user already existed!");
                throw new Exception("This user already existed! Try with new email");
            }
            _context.Signups.Add(signupEntity);
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public async Task<List<SignupEntity>> GetSignupListAsync()
    {
        return await _context.Signups.ToListAsync();
    }
}
