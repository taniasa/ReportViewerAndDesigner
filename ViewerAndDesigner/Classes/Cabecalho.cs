using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ViewerAndDesigner.Classes
{
    [Serializable]
    public class CabecalhoDto
    {
        [DisplayName("Cabeçalho")]
        public string Cabecalho { get; set; }
        [DisplayName("Brasão")]
        public byte[] Brasao { get; set; }
        [DisplayName("Brasão direito")]
        public byte[] BrasaoDireito { get; set; }

        [DisplayName("Usuário")]
        public string Usuario { get; set; }
        [DisplayName("Data/hora da emissão")]
        public DateTime DataHoraEmissao { get; set; }

        public DadosUGDto DadosUGLogada { get; set; }
    }

    [Serializable]
    public class DadosUGDto
    {
        public string NomeRazaoSocial { get; set; }
        public string DadosMunicipio { get; set; }
        public string EstadoMunicipio { get; set; }
        public string Documento { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public long IdTipoUnidadeGestora { get; set; }
        public string CNPJ { get; set; }

        public EnderecoUGDto Endereco { get; set; }
    }

    [Serializable]
    public class EnderecoUGDto
    {
        public string NomeTipoLogradouro { get; set; }
        public string NomeLogradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string NomeBairro { get; set; }
        public string NomeMunicipio { get; set; }
        public string SiglaUF { get; set; }
        public string CEPFormatado { get; set; }
        public string TipoUtilizacaoEndereco { get; set; }
    }
    [Serializable]

    public class ReponsavelModeloRelatorioDto
    {
        public long Id { get; set; }

        public long IdModeloRelatorio { get; set; }

        public long IdPessoaFisica { get; set; }

        public string NomePessoa { get; set; }

        public long IdAssinatura { get; set; }

        public long? IdTipoAssinatura { get; set; }

        public string TituloAssinatura { get; set; }

        public bool UsuarioLogado { get; set; }

        public bool ResponsavelPadrao { get; set; }

        public string NomeAreaFuncional { get; set; }
    }
}