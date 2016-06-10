using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEE_BUS.DataContracts;

namespace TEE_BUS.Utilities
{
    public static class Conversor
    {
        //----------------------------------------BANDEIRA----------------------------------------------
        internal static Bandeira BandeiraServicoParaBus(TEEService.Bandeira bandeiraServico)
        {
            Bandeira bandeiraBUS = null;

            if(bandeiraServico != null)
            {
                bandeiraBUS = new Bandeira();

                bandeiraBUS.BandeiraID = bandeiraServico.BandeiraID;
                bandeiraBUS.BandeiraString = bandeiraServico.BandeiraString;
            }

            return bandeiraBUS;
        }

        internal static TEEService.Bandeira BandeiraBusParaServico(Bandeira bandeiraBUS)
        {
            TEEService.Bandeira bandeiraServico = null;

            if(bandeiraBUS != null)
            {
                bandeiraServico = new TEEService.Bandeira();

                bandeiraServico.BandeiraID = bandeiraBUS.BandeiraID;
                bandeiraServico.BandeiraString = bandeiraBUS.BandeiraString;
            }

            return bandeiraServico;
        }

        internal static List<Bandeira> BandeiraListaServicoParaBus(List<TEEService.Bandeira> bandeirasServico)
        {
            return new List<Bandeira>(bandeirasServico.Select(b => BandeiraServicoParaBus(b)));
        }

        //----------------------------------------CLIENTE----------------------------------------------

        internal static Cliente ClienteServicoParaBus(TEEService.Cliente clienteServico)
        {
            Cliente clienteBUS = null;

            if(clienteServico != null)
            {
                clienteBUS = new Cliente();

                clienteBUS.ClienteID = clienteServico.ClienteID;
                clienteBUS.Cnpj = clienteServico.Cnpj;
                clienteBUS.Endereco = clienteServico.Endereco;
                clienteBUS.Nome = clienteServico.Nome;
                clienteBUS.RazaoSocial = clienteServico.RazaoSocial;
            }

            return clienteBUS;
        }

        internal static TEEService.Cliente ClienteBusParaServico(Cliente clienteBUS)
        {
            TEEService.Cliente clienteServico = null;

            if (clienteBUS != null)
            {
                clienteServico.ClienteID = clienteBUS.ClienteID;
                clienteServico.Cnpj = clienteBUS.Cnpj;
                clienteServico.Endereco = clienteBUS.Endereco;
                clienteServico.Nome = clienteBUS.Nome;
                clienteServico.RazaoSocial = clienteBUS.RazaoSocial;
            }

            return clienteServico;
        }

        //----------------------------------------FABRICA----------------------------------------------

        internal static TEEService.Fabrica FabricaBusParaServico(Fabrica fabricaBUS)
        {
            TEEService.Fabrica fabricaServico = null;

            if(fabricaBUS != null)
            {
                fabricaServico = new TEEService.Fabrica();

                fabricaServico.ClienteID = fabricaBUS.ClienteID;
                fabricaServico.Cnpj = fabricaBUS.Cnpj;
                fabricaServico.DistribuidoraID = fabricaBUS.DistribuidoraID;
                fabricaServico.Endereco = fabricaBUS.Endereco;
                fabricaServico.FabricaID = fabricaBUS.FabricaID;
            }

            return fabricaServico;
        }

        internal static Fabrica FabricaServicoParaBus(TEEService.Fabrica fabricaServico)
        {
            Fabrica fabricaBUS = null;

            if (fabricaServico != null)
            {
                fabricaBUS = new Fabrica();

                fabricaBUS.ClienteID = fabricaServico.ClienteID;
                fabricaBUS.Cnpj = fabricaServico.Cnpj;
                fabricaBUS.DistribuidoraID = fabricaServico.DistribuidoraID;
                fabricaBUS.Endereco = fabricaServico.Endereco;
                fabricaBUS.FabricaID = fabricaServico.FabricaID;
            }

            return fabricaBUS;
        }

        internal static List<Fabrica> FabricaListaServicoParaBus(List<TEEService.Fabrica> fabricasServico)
        {
            return new List<Fabrica>(fabricasServico.Select(f => FabricaServicoParaBus(f)));
        }

        //----------------------------------------TIPO DE CONTRATO----------------------------------------------

        internal static TEEService.TipoContrato TipoContratoBusParaServico(TipoContrato contratoBUS)
        {
            TEEService.TipoContrato contratoServico = null;

            if (contratoBUS != null)
            {
                contratoServico = new TEEService.TipoContrato();

                contratoServico.TipoContratoID = contratoBUS.TipoContratoID;
                contratoServico.TipoContratoString = contratoBUS.TipoContratoString;
            }

            return contratoServico;
        }

        internal static TipoContrato TipoContratoServicoParaBus(TEEService.TipoContrato contratoServico)
        {
            TipoContrato contratoBUS = null;

            if (contratoServico != null)
            {
                contratoBUS = new TipoContrato();

                contratoBUS.TipoContratoID = contratoServico.TipoContratoID;
                contratoBUS.TipoContratoString = contratoServico.TipoContratoString;
            }

            return contratoBUS;
        }

        internal static List<TipoContrato> TipoContratoListaServicoParaBus(List<TEEService.TipoContrato> contratosServico)
        {
            return new List<TipoContrato>(contratosServico.Select(c => TipoContratoServicoParaBus(c)));
        }
    }

    //----------------------------------------DISTRIBUIDORA----------------------------------------------

    internal static TEEService.Distribuidora DistribuidoraBusParaServico(Distribuidora distribuidoraBUS)
    {
        TEEService.Distribuidora distribuidoraServico = null;

        if(distribuidoraBUS != null)
        {
            distribuidoraServico = new TEEService.Distribuidora();

            distribuidoraServico.Cnpj = distribuidoraBUS.Cnpj;
            distribuidoraServico.DistribuidoraID = distribuidoraBUS.DistribuidoraID;
            distribuidoraServico.Nome = distribuidoraBUS.Nome;
        }

        return distribuidoraService;
    }

    internal static Distribuidora DistribuidoraServicoParaBus(TEEService.Distribuidora distribuidoraServico)
    {
        Distribuidora distribuidoraBUS = null;

        if(distribuidoraServico != null)
        {
            distribuidoraBUS = new Distribuidora();

            distribuidoraBUS.Cnpj = distribuidoraServico.Cnpj;
            distribuidoraBUS.DistribuidoraID = distribuidoraServico.DistribuidoraID;
            distribuidoraBUS.Nome = distribuidoraServico.Nome;
        }

        return distribuidoraBUS;
    }

    internal static List<Distribuidora> DistribuidoraListaServicoParaBus(List<TEEService.Distribuidora> distribuidorasServico)
    {
        return new List<Distribuidora>(distribuidorasServico.Select(d => DistribuidoraServicoParaBus(d)));
    }

    //----------------------------------------TIPO SUB GRUPO----------------------------------------------
    internal static TEEService.TipoSubGrupo TipoSubGrupoBusParaServico(TipoSubGrupo subGrupoBUS)
    {
        TEEService.TipoSubGrupo subGrupoServico = null;

        if (subGrupoBUS != null)
        {
            subGrupoServico = new TEEService.TipoSubGrupo();

            subGrupoServico.TipoSubGrupoID = subGrupoBUS.TipoSubGrupoID;
            subGrupoServico.TipoSubGrupoString = subGrupoBUS.TipoSubGrupoString;
        }

        return subGrupoServico;
    }

    internal static TipoSubGrupo TipoSubGrupoServicoParaBus(TEEService.TipoSubGrupo subGrupoServico)
    {
        TipoSubGrupo subGrupoBUS = null;

        if (subGrupoServico != null)
        {
            subGrupoBUS = new TipoSubGrupo();

            subGrupoBUS.TipoSubGrupoID = subGrupoServico.TipoSubGrupoID;
            subGrupoBUS.TipoSubGrupoString = subGrupoServico.TipoSubGrupoString;
        }

        return subGrupoBUS;
    }

    internal static List<TipoSubGrupo> TipoSubGrupoListaServicoParaBus(List<TEEService.TipoSubGrupo> subGruposServico)
    {
        return new List<TipoSubGrupo>(subGruposServico.Select(s => TipoSubGrupoServicoParaBus(s)));
    }

    //----------------------------------------TARIFAS----------------------------------------------
    internal static TEEService.Tarifa TarifaBusParaServico(Tarifa tarifaBUS)
    {
        TEEService.Tarifa tarifaServico = null;

        if(tarifaBUS != null)
        {
            tarifaServico = new TEEService.Tarifa();

            tarifaServico.TarifaID = tarifaBUS.TarifaID;
            tarifaServico.DistribuidoraID = tarifaBUS.DistribuidoraID;
            tarifaServico.TipoContratoID = tarifaBUS.TipoContratoID;
            tarifaServico.TipoSubGrupoID = tarifaBUS.TipoSubGrupoID;
            tarifaServico.DataReferencia = tarifaBUS.DataReferencia;
            tarifaServico.PotenciaMin = tarifaBUS.PotenciaMin;
            tarifaServico.PotenciaMax = tarifaBUS.PotenciaMax;
            tarifaServico.ConsumoNaPontaTUSD_TarifaPreco = tarifaBUS.ConsumoNaPontaTUSD_TarifaPreco;
            tarifaServico.ConsumoForaPontaTUSD_TarifaPreco = tarifaBUS.ConsumoForaPontaTUSD_TarifaPreco;
            tarifaServico.ConsumoNaPontaTE_TarifaPreco = tarifaBUS.ConsumoNaPontaTE_TarifaPreco;
            tarifaServico.ConsumoForaPontaTE_TarifaPreco = tarifaBUS.ConsumoForaPontaTE_TarifaPreco;
            tarifaServico.ConsumoUltrapassagemNaPonta_TarifaPreco = tarifaBUS.ConsumoUltrapassagemNaPonta_TarifaPreco;
            tarifaServico.ConsumoUltrapassagemForaPonta_TarifaPreco = tarifaBUS.ConsumoUltrapassagemForaPonta_TarifaPreco;
            tarifaServico.DemandaTUSD_TarifaPreco = tarifaBUS.DemandaTUSD_TarifaPreco;
            tarifaServico.BandeiraID = tarifaBUS.BandeiraID;
        }

        return tarifaServico;
    }

    internal static Tarifa TarifaServicoParaBus(TEEService.Tarifa tarifaServico)
    {
        Tarifa tarifaBUS = null;

        if(tarifaServico != null)
        {
            tarifaBUS = new Tarifa();

            tarifaBUS.TarifaID = tarifaServico.TarifaID;
            tarifaBUS.DistribuidoraID = tarifaServico.DistribuidoraID;
            tarifaBUS.TipoContratoID = tarifaServico.TipoContratoID;
            tarifaBUS.TipoSubGrupoID = tarifaServico.TipoSubGrupoID;
            tarifaBUS.DataReferencia = tarifaServico.DataReferencia;
            tarifaBUS.PotenciaMin = tarifaServico.PotenciaMin;
            tarifaBUS.PotenciaMax = tarifaServico.PotenciaMax;
            tarifaBUS.ConsumoNaPontaTUSD_TarifaPreco = tarifaServico.ConsumoNaPontaTUSD_TarifaPreco;
            tarifaBUS.ConsumoForaPontaTUSD_TarifaPreco = tarifaServico.ConsumoForaPontaTUSD_TarifaPreco;
            tarifaBUS.ConsumoNaPontaTE_TarifaPreco = tarifaServico.ConsumoNaPontaTE_TarifaPreco;
            tarifaBUS.ConsumoForaPontaTE_TarifaPreco = tarifaServico.ConsumoForaPontaTE_TarifaPreco;
            tarifaBUS.ConsumoUltrapassagemNaPonta_TarifaPreco = tarifaServico.ConsumoUltrapassagemNaPonta_TarifaPreco;
            tarifaBUS.ConsumoUltrapassagemForaPonta_TarifaPreco = tarifaServico.ConsumoUltrapassagemForaPonta_TarifaPreco;
            tarifaBUS.DemandaTUSD_TarifaPreco = tarifaServico.DemandaTUSD_TarifaPreco;
            tarifaBUS.BandeiraID = tarifaServico.BandeiraID;
        }

        return tarifaBUS;
    }

    internal static List<Tarifa> TarifaListaServicoParaBus(List<TEEService.Tarifa> tarifasServico)
    {
        return new List<Tarifa>(tarifasServico.Select(t => TarifaServicoParaBus(t)));
    }

    //----------------------------------------USUARIOS----------------------------------------------
    internal static Usuario UsuarioServicoParaBus(TEEService.Usuario usuarioServico)
    {
        Usuario usuarioBUS = null;

        if(usuarioServico != null)
        {
            usuarioBUS = new Usuario();

            usuarioBUS.Email = usuarioServico.Email;
            usuarioBUS.ClienteID = usuarioServico.ClienteID;
            usuarioBUS.Cpf = usuarioServico.Cpf;
            usuarioBUS.Nome = usuarioServico.Nome;
            usuarioBUS.Senha = usuarioServico.Senha;
            usuarioBUS.Ativo = usuarioServico.Ativo;
            usuarioBUS.DataRegistro = usuarioServico.DataRegistro;
            usuarioBUS.Tipo = usuarioServico.Tipo;
        }

        return usuarioBUS;
    }

    internal static TEEService.Usuario UsuarioBusParaServico(Usuario usuarioBUS)
    {
        TEEService.Usuario usuarioServico = null;

        if(usuarioBUS != null)
        {
            usuarioServico = new TEEService.Usuario();

            usuarioServico.Email = usuarioBUS.Email;
            usuarioServico.ClienteID = usuarioBUS.ClienteID;
            usuarioServico.Cpf = usuarioBUS.Cpf;
            usuarioServico.Nome = usuarioBUS.Nome;
            usuarioServico.Senha = usuarioBUS.Senha;
            usuarioServico.Ativo = usuarioBUS.Ativo;
            usuarioServico.DataRegistro = usuarioBUS.DataRegistro;
            usuarioServico.Tipo = usuarioBUS.Tipo;
        }

        return usuarioServico;
    }

    internal static List<Usuario> UsuarioListaServicoParaBus(List<TEEService.Usuario> usuariosServico)
    {
        return new List<Usuario>(usuariosServico.Select(u => UsuarioServicoParaBus(u)));
    }

    //----------------------------------------USUARIOS----------------------------------------------
    internal static TEEService.Conta ContaBusParaServico(Conta contaBUS)
    {
        TEEService.Conta = contaServico = null;

        if(contaBUS != null)
        {
            contaServico = new TEEService.Conta();

            contaServico.dataReferencia = contaBUS.dataReferencia;
            contaServico.TarifaID = contaBUS.TarifaID;
            contaServico.FabricaID = contaBUS.FabricaID;
            contaServico.DistribuidoraID = contaBUS.DistribuidoraID;
            contaServico.TipoContratoID = contaBUS.TipoContratoID;
            contaServico.TipoSubGrupoID = contaBUS.TipoSubGrupoID;
            contaServico.ConsumoNaPontaTUSD_Registrado = contaBUS.ConsumoNaPontaTUSD_Registrado;
            contaServico.ConsumoForaPontaTUSD_Registrado = contaBUS.ConsumoForaPontaTUSD_Registrado;
            contaServico.ConsumoNaPontaTE_Registrado = contaBUS.ConsumoNaPontaTE_Registrado;
            contaServico.ConsumoForaPontaTE_Registrado = contaBUS.ConsumoForaPontaTE_Registrado;
            contaServico.ConsumoUltrapassagemNaPonta_Registrado = contaBUS.ConsumoUltrapassagemNaPonta_Registrado;
            contaServico.ConsumoUltrapassagemForaPonta_Registrado = contaBUS.ConsumoUltrapassagemForaPonta_Registrado;
            contaServico.DemandaTUSD_Registrado = contaBUS.DemandaTUSD_Registrado;
            contaServico.ConsumoNaPontaTUSD_Contratado = contaBUS.ConsumoNaPontaTUSD_Contratado;
            contaServico.ConsumoForaPontaTUSD_Contratado = contaBUS.ConsumoForaPontaTUSD_Contratado;
            contaServico.ConsumoNaPontaTE_Contratado = contaBUS.ConsumoNaPontaTE_Contratado;
            contaServico.ConsumoForaPontaTE_Contratado = contaBUS.ConsumoForaPontaTE_Contratado;
            contaServico.DemandaTUSD_Contratado = contaBUS.DemandaTUSD_Contratado;
            contaServico.ConsumoNaPontaTUSD_Faturado = contaBUS.ConsumoNaPontaTUSD_Faturado;
            contaServico.ConsumoForaPontaTUSD_Faturado = contaBUS.ConsumoForaPontaTUSD_Faturado;
            contaServico.ConsumoNaPontaTE_Faturado = contaBUS.ConsumoNaPontaTE_Faturado;
            contaServico.ConsumoForaPontaTE_Faturado = contaBUS.ConsumoForaPontaTE_Faturado;
            contaServico.ConsumoUltrapassagemNaPonta_Faturado = contaBUS.ConsumoUltrapassagemNaPonta_Faturado;
            contaServico.ConsumoUltrapassagemForaPonta_Faturado = contaBUS.ConsumoUltrapassagemForaPonta_Faturado;
            contaServico.DemandaTUSD_Faturado = contaBUS.DemandaTUSD_Faturado;
            contaServico.ConsumoNaPontaTUSD_TarifaPreco = contaBUS.ConsumoNaPontaTUSD_TarifaPreco;
            contaServico.ConsumoForaPontaTUSD_TarifaPreco = contaBUS.ConsumoForaPontaTUSD_TarifaPreco;
            contaServico.ConsumoNaPontaTE_TarifaPreco = contaBUS.ConsumoNaPontaTE_TarifaPreco;
            contaServico.ConsumoForaPontaTE_TarifaPreco = contaBUS.ConsumoForaPontaTE_TarifaPreco;
            contaServico.ConsumoUltrapassagemNaPonta_TarifaPreco = contaBUS.ConsumoUltrapassagemNaPonta_TarifaPreco;
            contaServico.ConsumoUltrapassagemForaPonta_TarifaPreco = contaBUS.ConsumoUltrapassagemForaPonta_TarifaPreco;
            contaServico.DemandaTUSD_TarifaPreco = contaBUS.DemandaTUSD_TarifaPreco;
            contaServico.ConsumoNaPontaTUSD_Valor = contaBUS.ConsumoNaPontaTUSD_Valor;
            contaServico.ConsumoForaPontaTUSD_Valor = contaBUS.ConsumoForaPontaTUSD_Valor;
            contaServico.ConsumoNaPontaTE_Valor = contaBUS.ConsumoNaPontaTE_Valor;
            contaServico.ConsumoForaPontaTE_Valor = contaBUS.ConsumoForaPontaTE_Valor;
            contaServico.ConsumoUltrapassagemNaPonta_Valor = contaBUS.ConsumoUltrapassagemNaPonta_Valor;
            contaServico.ConsumoUltrapassagemForaPonta_Valor = contaBUS.ConsumoUltrapassagemForaPonta_Valor;
            contaServico.DemandaTUSD_Valor = contaBUS.DemandaTUSD_Valor;
            contaServico.SubTotal = contaBUS.SubTotal;
            contaServico.ValorTotal = contaBUS.ValorTotal;
            contaServico.BandeiraID = contaBUS.BandeiraID;
        }

        return contaServico;
    }

    internal static Conta ContaServicoParaBus(TEEService.Conta contaServico)
    {
        Conta = contaBUS = null;

        if(contaServico != null)
        {
            contaBUS = new Conta();

            contaBUS.dataReferencia = contaServico.dataReferencia;
            contaBUS.TarifaID = contaServico.TarifaID;
            contaBUS.FabricaID = contaServico.FabricaID;
            contaBUS.DistribuidoraID = contaServico.DistribuidoraID;
            contaBUS.TipoContratoID = contaServico.TipoContratoID;
            contaBUS.TipoSubGrupoID = contaServico.TipoSubGrupoID;
            contaBUS.ConsumoNaPontaTUSD_Registrado = contaServico.ConsumoNaPontaTUSD_Registrado;
            contaBUS.ConsumoForaPontaTUSD_Registrado = contaServico.ConsumoForaPontaTUSD_Registrado;
            contaBUS.ConsumoNaPontaTE_Registrado = contaServico.ConsumoNaPontaTE_Registrado;
            contaBUS.ConsumoForaPontaTE_Registrado = contaServico.ConsumoForaPontaTE_Registrado;
            contaBUS.ConsumoUltrapassagemNaPonta_Registrado = contaServico.ConsumoUltrapassagemNaPonta_Registrado;
            contaBUS.ConsumoUltrapassagemForaPonta_Registrado = contaServico.ConsumoUltrapassagemForaPonta_Registrado;
            contaBUS.DemandaTUSD_Registrado = contaServico.DemandaTUSD_Registrado;
            contaBUS.ConsumoNaPontaTUSD_Contratado = contaServico.ConsumoNaPontaTUSD_Contratado;
            contaBUS.ConsumoForaPontaTUSD_Contratado = contaServico.ConsumoForaPontaTUSD_Contratado;
            contaBUS.ConsumoNaPontaTE_Contratado = contaServico.ConsumoNaPontaTE_Contratado;
            contaBUS.ConsumoForaPontaTE_Contratado = contaServico.ConsumoForaPontaTE_Contratado;
            contaBUS.DemandaTUSD_Contratado = contaServico.DemandaTUSD_Contratado;
            contaBUS.ConsumoNaPontaTUSD_Faturado = contaServico.ConsumoNaPontaTUSD_Faturado;
            contaBUS.ConsumoForaPontaTUSD_Faturado = contaServico.ConsumoForaPontaTUSD_Faturado;
            contaBUS.ConsumoNaPontaTE_Faturado = contaServico.ConsumoNaPontaTE_Faturado;
            contaBUS.ConsumoForaPontaTE_Faturado = contaServico.ConsumoForaPontaTE_Faturado;
            contaBUS.ConsumoUltrapassagemNaPonta_Faturado = contaServico.ConsumoUltrapassagemNaPonta_Faturado;
            contaBUS.ConsumoUltrapassagemForaPonta_Faturado = contaServico.ConsumoUltrapassagemForaPonta_Faturado;
            contaBUS.DemandaTUSD_Faturado = contaServico.DemandaTUSD_Faturado;
            contaBUS.ConsumoNaPontaTUSD_TarifaPreco = contaServico.ConsumoNaPontaTUSD_TarifaPreco;
            contaBUS.ConsumoForaPontaTUSD_TarifaPreco = contaServico.ConsumoForaPontaTUSD_TarifaPreco;
            contaBUS.ConsumoNaPontaTE_TarifaPreco = contaServico.ConsumoNaPontaTE_TarifaPreco;
            contaBUS.ConsumoForaPontaTE_TarifaPreco = contaServico.ConsumoForaPontaTE_TarifaPreco;
            contaBUS.ConsumoUltrapassagemNaPonta_TarifaPreco = contaServico.ConsumoUltrapassagemNaPonta_TarifaPreco;
            contaBUS.ConsumoUltrapassagemForaPonta_TarifaPreco = contaServico.ConsumoUltrapassagemForaPonta_TarifaPreco;
            contaBUS.DemandaTUSD_TarifaPreco = contaServico.DemandaTUSD_TarifaPreco;
            contaBUS.ConsumoNaPontaTUSD_Valor = contaServico.ConsumoNaPontaTUSD_Valor;
            contaBUS.ConsumoForaPontaTUSD_Valor = contaServico.ConsumoForaPontaTUSD_Valor;
            contaBUS.ConsumoNaPontaTE_Valor = contaServico.ConsumoNaPontaTE_Valor;
            contaBUS.ConsumoForaPontaTE_Valor = contaServico.ConsumoForaPontaTE_Valor;
            contaBUS.ConsumoUltrapassagemNaPonta_Valor = contaServico.ConsumoUltrapassagemNaPonta_Valor;
            contaBUS.ConsumoUltrapassagemForaPonta_Valor = contaServico.ConsumoUltrapassagemForaPonta_Valor;
            contaBUS.DemandaTUSD_Valor = contaServico.DemandaTUSD_Valor;
            contaBUS.SubTotal = contaServico.SubTotal;
            contaBUS.ValorTotal = contaServico.ValorTotal;
            contaBUS.BandeiraID = contaServico.BandeiraID;

        }

        return contaBUS;
    }

    internal static List<Conta> ContaListaServicoParaBus(List<TEEService.Conta> contasServico)
    {
        return new List<Conta>(contasServico.Select(c => ContaServicoParaBus(c)));
    }

    //----------------------------------------GRAFICO----------------------------------------------
    internal static Grafico GraficoServicoParaBus(TEEService.Grafico graficoSerivo)
    {
        Grafico graficoBUS = null;

        if(graficoSerivo != null)
        {
            graficoBUS = new Grafico();

            graficoBUS.DataDaSimulacao = graficoServico.DataDaSimulacao;
            graficoBUS.DataReferencia = graficoServico.DataReferencia;
            graficoBUS.TarifaOrigemID = graficoServico.TarifaOrigemID;
            graficoBUS.TarifaDestinoID = graficoServico.TarifaDestinoID;
            graficoBUS.FabricaID = graficoServico.FabricaID;
            graficoBUS.DistribuidoraID = graficoServico.DistribuidoraID;
            graficoBUS.TipoContratoID = graficoServico.TipoContratoID;
            graficoBUS.TipoSubGrupoID = graficoServico.TipoSubGrupoID;
            graficoBUS.BandeiraID = graficoServico.BandeiraID;
            graficoBUS.ConsumoNaPontaTUSD_Registrado = graficoServico.ConsumoNaPontaTUSD_Registrado;
            graficoBUS.ConsumoForaPontaTUSD_Registrado = graficoServico.ConsumoForaPontaTUSD_Registrado;
            graficoBUS.ConsumoNaPontaTE_Registrado = graficoServico.ConsumoNaPontaTE_Registrado;
            graficoBUS.ConsumoForaPontaTE_Registrado = graficoServico.ConsumoForaPontaTE_Registrado;
            graficoBUS.ConsumoUltrapassagemNaPonta_Registrado = graficoServico.ConsumoUltrapassagemNaPonta_Registrado;
            graficoBUS.ConsumoUltrapassagemForaPonta_Registrado = graficoServico.ConsumoUltrapassagemForaPonta_Registrado;
            graficoBUS.DemandaTUSD_Registrado = graficoServico.DemandaTUSD_Registrado;
            graficoBUS.ConsumoNaPontaTUSD_Contratado = graficoServico.ConsumoNaPontaTUSD_Contratado;
            graficoBUS.ConsumoForaPontaTUSD_Contratado = graficoServico.ConsumoForaPontaTUSD_Contratado;
            graficoBUS.ConsumoNaPontaTE_Contratado = graficoServico.ConsumoNaPontaTE_Contratado;
            graficoBUS.ConsumoForaPontaTE_Contratado = graficoServico.ConsumoForaPontaTE_Contratado;
            graficoBUS.DemandaTUSD_Contratado = graficoServico.DemandaTUSD_Contratado;
            graficoBUS.ConsumoNaPontaTUSD_Faturado = graficoServico.ConsumoNaPontaTUSD_Faturado;
            graficoBUS.ConsumoForaPontaTUSD_Faturado = graficoServico.ConsumoForaPontaTUSD_Faturado;
            graficoBUS.ConsumoNaPontaTE_Faturado = graficoServico.ConsumoNaPontaTE_Faturado;
            graficoBUS.ConsumoForaPontaTE_Faturado = graficoServico.ConsumoForaPontaTE_Faturado;
            graficoBUS.ConsumoUltrapassagemNaPonta_Faturado = graficoServico.ConsumoUltrapassagemNaPonta_Faturado;
            graficoBUS.ConsumoUltrapassagemForaPonta_Faturado = graficoServico.ConsumoUltrapassagemForaPonta_Faturado;
            graficoBUS.DemandaTUSD_Faturado = graficoServico.DemandaTUSD_Faturado;
            graficoBUS.ConsumoNaPontaTUSD_TarifaPreco = graficoServico.ConsumoNaPontaTUSD_TarifaPreco;
            graficoBUS.ConsumoForaPontaTUSD_TarifaPreco = graficoServico.ConsumoForaPontaTUSD_TarifaPreco;
            graficoBUS.ConsumoNaPontaTE_TarifaPreco = graficoServico.ConsumoNaPontaTE_TarifaPreco;
            graficoBUS.ConsumoForaPontaTE_TarifaPreco = graficoServico.ConsumoForaPontaTE_TarifaPreco;
            graficoBUS.ConsumoUltrapassagemNaPonta_TarifaPreco = graficoServico.ConsumoUltrapassagemNaPonta_TarifaPreco;
            graficoBUS.ConsumoUltrapassagemForaPonta_TarifaPreco = graficoServico.ConsumoUltrapassagemForaPonta_TarifaPreco;
            graficoBUS.DemandaTUSD_TarifaPreco = graficoServico.DemandaTUSD_TarifaPreco;
            graficoBUS.ConsumoNaPontaTUSD_Valor = graficoServico.ConsumoNaPontaTUSD_Valor;
            graficoBUS.ConsumoForaPontaTUSD_Valor = graficoServico.ConsumoForaPontaTUSD_Valor;
            graficoBUS.ConsumoNaPontaTE_Valor = graficoServico.ConsumoNaPontaTE_Valor;
            graficoBUS.ConsumoForaPontaTE_Valor = graficoServico.ConsumoForaPontaTE_Valor;
            graficoBUS.ConsumoUltrapassagemNaPonta_Valor = graficoServico.ConsumoUltrapassagemNaPonta_Valor;
            graficoBUS.ConsumoUltrapassagemForaPonta_Valor = graficoServico.ConsumoUltrapassagemForaPonta_Valor;
            graficoBUS.DemandaTUSD_Valor = graficoServico.DemandaTUSD_Valor;
            graficoBUS.SubTotal = graficoServico.SubTotal;
            graficoBUS.ValorTotal = graficoServico.ValorTotal;
            graficoBUS.TipoContratoDestinoID = graficoServico.TipoContratoDestinoID;
        }

        return graficoBUS;
    }

    internal static List<Grafico> GraficoListaServicoParaBus(List<TEEService.Grafico> graficosServico)
    {
        return new List<Grafico>(graficosServico.Select(g => GraficoServicoParaBus(g)));
    }
}
