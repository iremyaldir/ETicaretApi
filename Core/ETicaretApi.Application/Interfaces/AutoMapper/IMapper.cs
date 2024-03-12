using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApi.Application.Interfaces.AutoMapper
{
    public interface IMapper
    {
        //source and destination
        //AutoMapper automatically maps each property in the source object to a property in the destination object, using profiles.
        //fex: mapper.Map<Product(TDestination, ProductDTO(TSource>(product(source));

        TDestination Map<TDestination, TSource>(TSource source, string? ignore = null);
        IList<TDestination> Map<TDestination, TSource>(IList<TSource> source, string? ignore = null);
        TDestination Map<TDestination>(object source, string? ignore = null);
        IList<TDestination> Map<TDestination>(IList<object> source, string? ignore = null);

    }
}
