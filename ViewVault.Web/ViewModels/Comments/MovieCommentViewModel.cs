namespace ViewVault.Core.Services.Contracts;


    using System;
    using ViewVault.Infrastructure.Data.Models.Linked;

    public class MovieCommentViewModel : IMapFrom<MovieComment>
    {
        public int Id { get; set; }

        public int MovieId { get; set; }

        public string MovieTitle { get; set; }

        public string UserId { get; set; }

        public string UserUsername { get; set; }

        public int? CommentId { get; set; }

        public string CommentContent { get; set; }

        public DateTime CommentCreatedOn { get; set; }
    }