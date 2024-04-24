namespace ViewVault.Infrastructure.Constants
{
    public static class DataConstants
    {
        //Movies' and Actors' constraints

        public const int NamesMinLength = 3;
        public const int NamesMaxLength = 50;

        //Descriptions', Autobiographies' and Comments' constraints

        public const int DescriptionsMinLength = 1;
        public const int DescriptionsMaxLength = 300;

        //Date Formats

        public const string DateOnlyFormat = "yyyy-MM-dd";          //Movie.ReleasedOn + Actor.Birth
        public const string DateTimeFormat = "yyyy-MM-dd HH:mm:ss";

        //User role names

        public const string ModeratorRoleName = "Moderator";

        public const string UserRoleName = "User";

    }
}
