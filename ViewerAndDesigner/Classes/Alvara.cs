using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewerAndDesigner.Classes
{
    public class AlvaraFuncionamentoDto
    {
        public AlvaraFuncionamentoDto()
        {
            this.DadosFichaCadastral = new List<DadosFichaAlvaraDto>();
            this.DadosFichaCadastralImovel = new List<DadosFichaAlvaraDto>();
            this.DadosFichaFatoGerador = new List<DadosFichaAlvaraDto>();
            this.Observacoes = new List<ObservacaoEconomicoDto>();
            //this.SociosPessoa = new List<SocioPessoaDto>();
            this.AtividadesEconomicasCNAE = new List<DadosAtividadeEconomicaCNAEDto>();
        }
        public long Id { get; set; }
        //Alvará

        public string TituloAlvara { get; set; } // TRAZER A DESCRIÇÃO DO CAMPO TIPOALVARA.DESCRICAO
        public string NumeroAno { get; set; }
        public string Descricao { get; set; }
        public string DataEmissao { get; set; }
        public string DataValidade { get; set; }
        public string SetorResponsavel { get; set; }
        public string Responsavel { get; set; }
        public string RestricoesObservacoes { get; set; }
        public string ObservacaoDocumento { get; set; }

        //Imóvel
        public string TipoImobiliario { get; set; }
        public string InscricaoImobiliaria { get; set; }
        public string DocumentoPrincipalImovel { get; set; }
        public string SituacaoImovel { get; set; }
        public string DescricaoImovel { get; set; }

        //DadosPessoa
        public string PessoaRazaoSocial { get; set; }
        public string PessoaNomeFantasia { get; set; }
        public string PessoaDocumentoCNPJ { get; set; }
        public string PessoaInscricaoEstadual { get; set; }

        //Proprietário Imóvel
        public string ProprietarioImovel { get; set; }
        public string NomeImove { get; set; }
        public string DocPrincpalPropImovel { get; set; }
        public string ResponsavelImovel { get; set; }
        public decimal? PercentualSobreImovel { get; set; }
        public string InicioPosseImovel { get; set; }
        public string FimPosseImovel { get; set; }

        //Endereço Contribuinte
        public string MunicipioContribuinte { get; set; }
        public string EstadoContribuinte { get; set; }
        public string DistritoContribuinte { get; set; }
        public string BairroContribuinte { get; set; }
        public string LogradouroContribuinte { get; set; }
        public string NumeroEndContribuinte { get; set; }
        public string ComplementoEndContribuinte { get; set; }
        public string CepContribuinte { get; set; }
        public string TipoLogradouroContribuinte { get; set; }

        //Endereço Imóvel
        public string MunicipioImovel { get; set; }
        public string EstadoImovel { get; set; }
        public string DistritoImovel { get; set; }
        public string BairroImovel { get; set; }
        public string LogradouroImovel { get; set; }
        public string NumeroEndImovel { get; set; }
        public string ComplementoEndImovel { get; set; }
        public string CepImovel { get; set; }
        public string TipoLogradouro { get; set; }


        //Endereço Economico
        public string MunicipioEconomico { get; set; }
        public string EstadoEconomico { get; set; }
        public string DistritoEconomico { get; set; }
        public string BairroEconomico { get; set; }
        public string LogradouroEconomico { get; set; }
        public string NumeroEndEconomico { get; set; }
        public string ComplementoEndEconomico { get; set; }
        public string CepEconomico { get; set; }
        public string TipoLogradouroEconomico { get; set; }

        //Utilização do Endereço
        public string DescricaoUtilizacaoEndImovel { get; set; }
        public string InicioVigenciaEndImovel { get; set; }
        public string FimVigenciaEndImovel { get; set; }

        //Econômico   
        public string InscricaoMunicipalAtivEconomica { get; set; }
        public string NomeEconomico { get; set; }
        public string DetalhamentoAtivEconomica { get; set; }
        public string DataNascimentoConstituicao { get; set; }
        public string LabelDataNascConstituicao { get; set; }
        public string DetalhamentoEconomico { get; set; }

        //public IEnumerable<SocioPessoaDto> SociosPessoa { get; set; }
        ////Atividade Econômica
        //public IEnumerable<DadosAtividadeEconomicaDto> ListaAtividadeEconomica_Economico { get; set; }
        public IEnumerable<DadosAtividadeEconomicaCNAEDto> AtividadesEconomicasCNAE { get; set; }

        public IEnumerable<DadosFichaAlvaraDto> DadosFichaCadastral { get; set; }
        public IEnumerable<DadosFichaAlvaraDto> DadosFichaCadastralImovel { get; set; }
        public IEnumerable<DadosFichaAlvaraDto> DadosFichaFatoGerador { get; set; }
        public IEnumerable<ObservacaoEconomicoDto> Observacoes { get; set; }

        public string RegimeTributacao { get; set; }

        public string TipoFornecedor { get; set; }

        public string PorteEmpresarial { get; set; }

        //Ficha cadastral econômico
        //Ficha cadastral imobiliária urbana e rural (verificar de aonde é acessado)

        public byte[] ImagemLogoEconomico { get; set; }
    }

    [Serializable]
    public class DadosFichaAlvaraDto : IIdentificavel
    {
        public long Id { get; set; }
        public long? IdCampoXGrupoFichaCadastral { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Valor { get; set; }
    }

    [Serializable]
    public class ObservacaoEconomicoDto : IIdentificavel
    {
        public long Id { get; set; }

        public long IdEconomico { get; set; }

        public long IdUsuarioInclusao { get; set; }

        public DateTime DataObservacao { get; set; }

        public string NomeUsuarioInclusao { get; set; }

        public string Observacao { get; set; }
    }

    [Serializable]
    public class DadosAtividadeEconomicaCNAEDto
    {
        public string Observacao { get; set; }

        public string CNAE { get; set; }

        public string Principal { get; set; }

        public string Descricao { get; set; }

        public DateTime DataInicioAtividade { get; set; }

        public DateTime? DataFimAtividade { get; set; }
    }
}