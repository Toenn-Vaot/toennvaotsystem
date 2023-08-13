using AutoMapper;

namespace ToennVaot.Components.Core.Api.Profiles
{
    /// <summary>
    /// The mapping profile for project models
    /// </summary>
    public class CoreProfile : Profile
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public CoreProfile()
        {
            CreateEnumMapFrom();
            CreateEnumMapTo();
        }

        private void CreateEnumMapFrom()
        {
        }

        private void CreateEnumMapTo()
        {
        }
    }
}
