using ViewVault.Infrastructure.Data.Models.Core;

namespace ViewVault.Core.Services.Contracts;

public class GenreViewModel : IMapFrom<Genre>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
