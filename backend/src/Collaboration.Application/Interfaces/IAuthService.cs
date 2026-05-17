using Collaboration.Application.DTOs.Auth;

namespace Collaboration.Application.Interfaces;


public interface IAuthService
{
    Task<string> RegisterAsync(RegisterRequestDto request);

    Task<AuthResponseDto> LoginAsync(LoginRequestDto request);
}