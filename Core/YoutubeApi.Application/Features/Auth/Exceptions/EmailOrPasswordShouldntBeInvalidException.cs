using YoutubeApi.Application.Bases;

namespace YoutubeApi.Application.Features.Auth.Exceptions
{
    public class EmailOrPasswordShouldntBeInvalidException : BaseException
    {
        public EmailOrPasswordShouldntBeInvalidException() : base("E-Mail veya Şifre hatalı!") { }
       
    }
}
