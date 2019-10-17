using Stimulsoft.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ViewerAndDesigner.Properties;

namespace ViewerAndDesigner.Classes
{
    public class ReportData
    {
        public static StiReport RegisterData(DataReportEnum data, StiReport report)
        {
            switch (data)
            {
                case DataReportEnum.Pessoa:
                    RegisterPessoa(report);
                    break;
                case DataReportEnum.Alvara:
                    RegisterAlvara(report);
                    break;
                case DataReportEnum.Multilevel:
                    RegisterMultiLevel(report);
                    break;
                default:
                    break;
            }
            return report;
        }

        private static void RegisterPessoa(StiReport report)
        {
            var dados = Help.RetornarPessoas();
            report.RegBusinessObject("Pessoa", dados);
            report.Dictionary.SynchronizeBusinessObjects(2);
        }

        private static void RegisterAlvara(StiReport report)
        {
            report.RegBusinessObject("Assinaturas", new List<ReponsavelModeloRelatorioDto>());
            report.RegBusinessObject("Cabecalho", new List<CabecalhoDto>());
            report.RegBusinessObject("CodigoAutenticidade", new { Data = string.Empty });


            report.RegBusinessObject("QrCode", new
            {
                Data = string.Empty
            });
            var funcionamento = Newtonsoft.Json.JsonConvert.DeserializeObject<AlvaraFuncionamentoDto>(Resources.alvara);
            report.RegBusinessObject("Dados_Alvara_Funcionamento", funcionamento);

            report.Dictionary.SynchronizeBusinessObjects(2);
        }

        private static void RegisterMultiLevel(StiReport report)
        {
            //report.Dictionary.BusinessObjects.Clear();
            report.RegBusinessObject("Principal", Utils.Get());
            report.RegBusinessObject("Test", Utils.Get());
            report.RegBusinessObject("TestMyObject3", Utils.Get());

            report.Dictionary.SynchronizeBusinessObjects(4);
        }
    }
}