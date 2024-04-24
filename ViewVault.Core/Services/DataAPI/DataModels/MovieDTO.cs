namespace ViewVault.Core.Services.Contracts;

    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class MovieDTO
    {
        public int Id { get; set; }

        public string Title { get; set; }

        [JsonPropertyName("release_date")]
        public string ReleaseDate { get; set; }

        public string Director { get; set; }

        [JsonPropertyName("poster_path")]
        public string Poster { get; set; }

        public int Runtime { get; set; }

        [JsonPropertyName("vote_count")]
        public int TotalVotes { get; set; }

        [JsonPropertyName("vote_average")]
        public double AverageVote { get; set; }

        public ICollection<GenreDTO> Genres { get; set; }

        [JsonPropertyName("spoken_languages")]
        public ICollection<LanguageDTO> Languages { get; set; }
    }

