﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace FiscalBr.Common
{
    public static class Constantes
    {
        public const decimal VZero = 0.00M;
        public const string StructuralError = "|ERRO_NA_ESTRUTURA|";

        public static class ArquivoDigital
        {
            public static class Sped
            {
                public const string ECD = "ECD";
                public const string ECF = "ECF";
                public const string EFDContribuicoes = "EFDContribuicoes";
                public const string EFDFiscal = "EFDFiscal";

                public static class Bloco
                {
                    public static class D
                    {
                        public const string D001 = "D001";

                        public const string D100 = "D100";
                        public const string D300 = "D300";

                        public const string D990 = "D990";
                    }
                }

                public static class TipoInformacao
                {
                    public const string CodeOrNumber = "CODNUM";
                    public const string DateTime = "DATA";
                    public const string NullableDateTime = "NDATA";
                    public const string Decimal = "DECIMAL";
                    public const string NullableDecimal = "NDECIMAL";
                    public const string GenericData = "GENERIC";
                    public const string Hour = "HORA";
                    public const string LiteralEnum = "LENUM";
                    public const string MonthAndYear = "MESANO";
                }
            }

            public const string Dimob = "Dimob";
            public const string Sintegra = "Sintegra";
        }
    }
}
