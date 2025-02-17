﻿namespace FiscalBr.Test.Sped.BlocoK
{
    public class BlocoKRegistro001Test
    {
        private const string K001ComDados = $"|K001|0|";
        private const string K001SemDados = $"|K001|1|";

        public static readonly object[][] ArrayParaEscreverRegK001ComDadosDaEFDFiscalV9EAbaixo =
        {
            new object[] {
                CodigoVersaoLeiaute.V2,
                new DateTime(2009, 01, 01),
                IndMovimento.BlocoComDados
            },
            new object[] {
                CodigoVersaoLeiaute.V3,
                new DateTime(2010, 01, 01),
                IndMovimento.BlocoComDados
            },
            new object[] {
                CodigoVersaoLeiaute.V4,
                new DateTime(2011, 01, 01),
                IndMovimento.BlocoComDados
            },
            new object[] {
                CodigoVersaoLeiaute.V5,
                new DateTime(2012, 01, 01),
                IndMovimento.BlocoComDados
            },
            new object[] {
                CodigoVersaoLeiaute.V6,
                new DateTime(2012, 07, 01),
                IndMovimento.BlocoComDados
            },
            new object[] {
                CodigoVersaoLeiaute.V7,
                new DateTime(2013, 01, 01),
                IndMovimento.BlocoComDados
            },
            new object[] {
                CodigoVersaoLeiaute.V8,
                new DateTime(2014, 01, 01),
                IndMovimento.BlocoComDados
            },
            new object[] {
                CodigoVersaoLeiaute.V9,
                new DateTime(2015, 01, 01),
                IndMovimento.BlocoComDados
            }
        };

        public static readonly object[][] ArrayParaEscreverRegK001SemDadosDaEFDFiscalV9EAbaixo =
        {
            new object[] {
                CodigoVersaoLeiaute.V2,
                new DateTime(2009, 01, 01),
                IndMovimento.BlocoSemDados
            },
            new object[] {
                CodigoVersaoLeiaute.V3,
                new DateTime(2010, 01, 01),
                IndMovimento.BlocoSemDados
            },
            new object[] {
                CodigoVersaoLeiaute.V4,
                new DateTime(2011, 01, 01),
                IndMovimento.BlocoSemDados
            },
            new object[] {
                CodigoVersaoLeiaute.V5,
                new DateTime(2012, 01, 01),
                IndMovimento.BlocoSemDados
            },
            new object[] {
                CodigoVersaoLeiaute.V6,
                new DateTime(2012, 07, 01),
                IndMovimento.BlocoSemDados
            },
            new object[] {
                CodigoVersaoLeiaute.V7,
                new DateTime(2013, 01, 01),
                IndMovimento.BlocoSemDados
            },
            new object[] {
                CodigoVersaoLeiaute.V8,
                new DateTime(2014, 01, 01),
                IndMovimento.BlocoSemDados
            },
            new object[] {
                CodigoVersaoLeiaute.V9,
                new DateTime(2015, 01, 01),
                IndMovimento.BlocoSemDados
            }
        };

        public static readonly object[][] ArrayParaEscreverRegK001ComDadosDaEFDFiscalV10EAcima =
        {
            new object[] {
                CodigoVersaoLeiaute.V10,
                new DateTime(2016, 01, 01),
                IndMovimento.BlocoComDados,
                K001ComDados
            },
            new object[] {
                CodigoVersaoLeiaute.V11,
                new DateTime(2017, 01, 01),
                IndMovimento.BlocoComDados,
                K001ComDados
            },
            new object[] {
                CodigoVersaoLeiaute.V12,
                new DateTime(2018, 01, 01),
                IndMovimento.BlocoComDados,
                K001ComDados
            },
            new object[] {
                CodigoVersaoLeiaute.V13,
                new DateTime(2019, 01, 01),
                IndMovimento.BlocoComDados,
                K001ComDados
            },
            new object[] {
                CodigoVersaoLeiaute.V14,
                new DateTime(2020, 01, 01),
                IndMovimento.BlocoComDados,
                K001ComDados
            },
            new object[] {
                CodigoVersaoLeiaute.V15,
                new DateTime(2021, 01, 01),
                IndMovimento.BlocoComDados,
                K001ComDados
            },
            new object[] {
                CodigoVersaoLeiaute.V16,
                new DateTime(2022, 01, 01),
                IndMovimento.BlocoComDados,
                K001ComDados
            },
            new object[] {
                CodigoVersaoLeiaute.V17,
                new DateTime(2023, 01, 01),
                IndMovimento.BlocoComDados,
                K001ComDados
            }
        };

        public static readonly object[][] ArrayParaEscreverRegK001SemDadosDaEFDFiscalV10EAcima =
        {
            new object[] {
                CodigoVersaoLeiaute.V10,
                new DateTime(2016, 01, 01),
                IndMovimento.BlocoSemDados,
                K001SemDados
            },
            new object[] {
                CodigoVersaoLeiaute.V11,
                new DateTime(2017, 01, 01),
                IndMovimento.BlocoSemDados,
                K001SemDados
            },
            new object[] {
                CodigoVersaoLeiaute.V12,
                new DateTime(2018, 01, 01),
                IndMovimento.BlocoSemDados,
                K001SemDados
            },
            new object[] {
                CodigoVersaoLeiaute.V13,
                new DateTime(2019, 01, 01),
                IndMovimento.BlocoSemDados,
                K001SemDados
            },
            new object[] {
                CodigoVersaoLeiaute.V14,
                new DateTime(2020, 01, 01),
                IndMovimento.BlocoSemDados,
                K001SemDados
            },
            new object[] {
                CodigoVersaoLeiaute.V15,
                new DateTime(2021, 01, 01),
                IndMovimento.BlocoSemDados,
                K001SemDados
            },
            new object[] {
                CodigoVersaoLeiaute.V16,
                new DateTime(2022, 01, 01),
                IndMovimento.BlocoSemDados,
                K001SemDados
            },
            new object[] {
                CodigoVersaoLeiaute.V17,
                new DateTime(2023, 01, 01),
                IndMovimento.BlocoSemDados,
                K001SemDados
            }
        };

        [Theory]
        [MemberData(nameof(ArrayParaEscreverRegK001ComDadosDaEFDFiscalV9EAbaixo))]
        [MemberData(nameof(ArrayParaEscreverRegK001SemDadosDaEFDFiscalV9EAbaixo))]
        public void Escrever_Registro_K001_EFDFiscal_V09_E_Abaixo(
            CodigoVersaoLeiaute codVer,
            DateTime dataDec,
            IndMovimento indMov
            )
        {
            var reg = new EFDFiscal.BlocoK.RegistroK001
            {
                IndMov = indMov
            };

            var resultadoAtual = Common.Sped.EscreverCamposSped.EscreverCampos(
                reg,
                codVer,
                dataDec,
                true
                );

            Assert.Null(resultadoAtual);
        }

        [Theory]
        [MemberData(nameof(ArrayParaEscreverRegK001ComDadosDaEFDFiscalV10EAcima))]
        [MemberData(nameof(ArrayParaEscreverRegK001SemDadosDaEFDFiscalV10EAcima))]
        public void Escrever_Registro_K001_EFDFiscal_V10_E_Acima(
            CodigoVersaoLeiaute codVer,
            DateTime dataDec,
            IndMovimento indMov,
            string resultadoEsperado
            )
        {
            var reg = new EFDFiscal.BlocoK.RegistroK001
            {
                IndMov = indMov
            };

            var resultadoAtual = Common.Sped.EscreverCamposSped.EscreverCampos(
                reg,
                codVer,
                dataDec,
                true
                );

            Assert.NotNull(resultadoAtual);
            Assert.Equal(resultadoEsperado, resultadoAtual);
        }
    }
}
