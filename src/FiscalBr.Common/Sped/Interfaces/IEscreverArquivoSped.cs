﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FiscalBr.Common.Sped.Interfaces
{
    public interface IEscreverArquivoSped
    {
        string[] EscreverArquivo(IRegistroSped[] regs);
        string[] EscreverArquivo(IRegistroSped[] regs, CodigoVersaoLeiaute? versao);
        string[] EscreverArquivo(List<IRegistroSped> regs);
        string[] EscreverArquivo(List<IRegistroSped> regs, CodigoVersaoLeiaute? versao);
    }
}
