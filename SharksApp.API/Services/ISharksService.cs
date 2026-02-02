using SharksApp.API.Dtos;

namespace SharksApp.API.Services
{
    public interface ISharksService
    {
        IEnumerable<SharkResponseDto> GetAll();
        SharkResponseDto GetById(int id);
        void Create(SharkRequestDto dto);
        void Delete(int id);
    }
}
