namespace ViewVault.Core.Services.Contracts;

using System.Text.Json.Serialization;

    public class ActorDTO
    {
        public string FullName { get; set; }

        public string Biography { get; set; }

        public int Gender { get; set; }

        public int Role {  get; set; }

        public string Birth { get; set; }

        [JsonPropertyName("profile_path")]
        public string Photo { get; set; }

        public double Popularity { get; set; }
    }
