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
        TEEService.Distribuidora distribuidoraService = null;

        if(distribuidoraBUS != null)
        {
            distribuidoraService.Cnpj = distribuidoraBUS.Cnpj;
            distribuidoraService.DistribuidoraID = distribuidoraBUS.DistribuidoraID;
            distribuidoraService.Nome = distribuidoraBUS.Nome;
        }

        return distribuidoraService;
    }
}
