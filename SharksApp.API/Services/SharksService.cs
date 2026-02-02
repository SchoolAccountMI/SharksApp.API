using SharksApp.API.Data;
using SharksApp.API.Dtos;
using SharksApp.API.Models;

namespace SharksApp.API.Services
{
    public class SharksService : ISharksService
    {
        private readonly AppDbContext _context;

        public SharksService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<SharkResponseDto> GetAll()
        {
            return _context.Sharks.Select(s => new SharkResponseDto
            {
                Id = s.Id,
                Name = s.Name,
                Species = s.Species,
                LengthInMeters = s.LengthInMeters,
                Habitat = s.Habitat
            }).ToList();
        }

        public SharkResponseDto GetById(int id)
        {
            var shark = _context.Sharks.Find(id);
            if (shark == null) return null;

            return new SharkResponseDto
            {
                Id = shark.Id,
                Name = shark.Name,
                Species = shark.Species,
                LengthInMeters = shark.LengthInMeters,
                Habitat = shark.Habitat
            };
        }

        public void Create(SharkRequestDto dto)
        {
            var shark = new Shark
            {
                Name = dto.Name,
                Species = dto.Species,
                LengthInMeters = dto.LengthInMeters,
                Habitat = dto.Habitat
            };

            _context.Sharks.Add(shark);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var shark = _context.Sharks.Find(id);
            if (shark == null) return;

            _context.Sharks.Remove(shark);
            _context.SaveChanges();
        }
    }
}
