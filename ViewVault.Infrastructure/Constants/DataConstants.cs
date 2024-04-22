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

        //Others

        public const string DateOnlyFormat = "yyyy-MM-dd";
        public const string DateTimeFormat = "yyyy-MM-dd HH:mm:ss";

    }
}
