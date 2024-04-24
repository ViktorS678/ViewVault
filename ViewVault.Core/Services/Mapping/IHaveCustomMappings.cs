namespace ViewVault.Core.Services.Contracts;


using AutoMapper;

    public interface IHaveCustomMappings
    {
        void CreateMappings(IProfileExpression configuration);
    }

