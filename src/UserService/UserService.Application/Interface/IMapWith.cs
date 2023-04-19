using AutoMapper;

namespace UserService.Application.Interface
{
    public interface IMapWith
    {
        public interface IMapWith<T>
        {
            void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType());
        }
    }
}
