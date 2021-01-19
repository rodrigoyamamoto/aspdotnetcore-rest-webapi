using AutoMapper;
using DevIO.API.ViewModels;
using DevIO.Business.Models;

namespace DevIO.API.Configuration
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<Fornecedor, FornecedorViewModel>().ReverseMap();
            CreateMap<Endereco, EnderecoViewModel>().ReverseMap();
            CreateMap<ProdutoViewModel, Produto>();

            CreateMap<Produto, ProdutoViewModel>()
                .ForMember(
                    dest => dest.NomeFornecedor,
                    opt => opt.MapFrom(src => src.Fornecedor.Nome));
        }
    }
}