using AutoMapper;
using AutomapperWebAPIProject.dto;
using AutomapperWebAPIProject.entity;

namespace AutomapperWebAPIProject.mapper {
    // public class CustomResolver : IValueResolver<UserEntity, UserDto, string>
    // {
    //     public string Resolve(UserEntity source, UserDto destination, string destMember, ResolutionContext context)
    //     {
    //         return $"{source.FirstName.ToUpper()} {source.LastName.ToLower()}";
    //     }
    // }
    // public class DateTimeTypeConverter : ITypeConverter<DateTime, string>
    // {
    //     public string Convert(DateTime source, string destination, ResolutionContext context)
    //     {
    //         return source.ToString("yyyy-MM-dd");
    //     }
    // }
    public class UserProfileMapper : Profile {
        public UserProfileMapper()
        {
            // Default mapping when property names are same
            CreateMap<UserEntity, UserDto>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => $"{src.LastName} {src.FirstName}"));
            
            //we can condition to not map if property is null
            // CreateMap<UserEntity, UserDto>()
            //     .ForMember(dest => dest.Name, opt => opt.Condition(src => src.FirstName != null && src.LastName != null));

            //we can ignore property to map
            // CreateMap<UserEntity, UserDto>()
            //     .ForMember(dest => dest.Name, opt => opt.Ignore());


            //we can using after map and assign any value to our property
            // CreateMap<UserEntity, UserDto>()
            //     .AfterMap((src, dest) => dest.Name = dest.Name.ToUpper());


            //we can using CustomResolver for mapping property
            // CreateMap<UserEntity, UserDto>()
            //     .ForMember(dest => dest.Name, opt => opt.MapFrom<CustomResolver>());


            //we can use include more derived source for map properties
            // CreateMap<UserEntity, UserDto>()
            //     .ForMember(dest => dest.Name, opt => opt.MapFrom(src => $"{src.LastName} {src.FirstName}"))
            //     .Include<DerivedSource, UserDto>();
            // CreateMap<DerivedSource, UserDto>();


            //we can use convert for mapping property
            // CreateMap<DateTime, string>().ConvertUsing<DateTimeTypeConverter>();


            // Mapping when property names are different
            //CreateMap<UserEntity, UserDto>()
            //    .ForMember(dest =>
            //    dest.Firstname,
            //    opt => opt.MapFrom(src => src.FirstName))
            //    .ForMember(dest =>
            //    dest.Lastname,
            //    opt => opt.MapFrom(src => src.LastName))
            //    .ReverseMap();
        }
    }
}