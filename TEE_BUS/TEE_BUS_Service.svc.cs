using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using TEE_BUS.DataContracts;
using TEE_BUS.Utilities;

namespace TEE_BUS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : ITEE_BUS_Service1
    {
        //----------------------------Bandeira-------------------------------------------
        [OperationBehavior]
        public Bandeira DetalhesBandeira(int id)
        {
            try
            {
                using (TEEService.TEECRUDServiceClient client = new TEEService.TEECRUDServiceClient())
                {
                    return Conversor.BandeiraServicoParaBus(client.DetalhesBandeira(id));
                }
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        [OperationBehavior]
        public bool CadastrarBandeira(Bandeira bandeira)
        {
            try
            {
                using (TEEService.TEECRUDServiceClient client = new TEEService.TEECRUDServiceClient())
                {
                    return client.CadastrarBandeira(Conversor.BandeiraBusParaServico(bandeira));
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [OperationBehavior]
        public List<Bandeira> TodasBandeiras()
        {
            try
            {
                using (TEEService.TEECRUDServiceClient client = new TEEService.TEECRUDServiceClient())
                {
                    return Conversor.BandeiraListaServicoParaBus(client.TodasBandeiras().ToList());
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        //----------------------------Cliente---------------------------------------------------
        [OperationBehavior]
        public Cliente DetalhesCliente(int id)
        {
            try
            {
                using (TEEService.TEECRUDServiceClient client = new TEEService.TEECRUDServiceClient())
                {
                    return Conversor.ClienteServicoParaBus(client.DetalhesCliente(id));
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [OperationBehavior]
        public bool CadastrarCliente(Cliente _cliente)
        {
            try
            {
                using (TEEService.TEECRUDServiceClient client = new TEEService.TEECRUDServiceClient())
                {
                    return client.CadastrarCliente(Conversor.ClienteBusParaServico(_cliente));
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [OperationBehavior]
        public bool AtualizarCliente(Cliente _cliente)
        {
            try
            {
                using (TEEService.TEECRUDServiceClient client = new TEEService.TEECRUDServiceClient())
                {
                    return client.AtualizarCliente(Conversor.ClienteBusParaServico(_cliente));
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        //----------------------------Fabrica-----------------------------------------------
        [OperationBehavior]
        public bool CadastrarFabrica(Fabrica _fabrica)
        {
            try
            {
                using (TEEService.TEECRUDServiceClient client = new TEEService.TEECRUDServiceClient())
                {
                    return client.CadastrarFabrica(Conversor.FabricaBusParaServico(_fabrica));
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [OperationBehavior]
        public bool AtualizarFabrica(Fabrica _fabrica)
        {
            try
            {
                using (TEEService.TEECRUDServiceClient client = new TEEService.TEECRUDServiceClient())
                {
                    return client.AtualizarFabrica(Conversor.FabricaBusParaServico(_fabrica));
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [OperationBehavior]
        public Fabrica DestalhesDaFabrica(int id)
        {
            try
            {
                using (TEEService.TEECRUDServiceClient client = new TEEService.TEECRUDServiceClient())
                {
                    return Conversor.FabricaServicoParaBus(client.DestalhesDaFabrica(id));
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [OperationBehavior]
        public List<Fabrica> TodasFabricas(int ClienteID)
        {
            try
            {
                using (TEEService.TEECRUDServiceClient client = new TEEService.TEECRUDServiceClient())
                {
                    return Conversor.FabricaListaServicoParaBus(new TEEService.TEECRUDServiceClient().TodasFabricas(ClienteID).ToList());
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        //Deleção de Fabrica
        [OperationBehavior]
        public bool DeletarFabrica(Fabrica _fabrica)
        {
            try
            {
                using (TEEService.TEECRUDServiceClient client = new TEEService.TEECRUDServiceClient())
                {
                    return client.DeletarFabrica(Conversor.FabricaBusParaServico(_fabrica));
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //----------------------------Tipo de Contrato-----------------------------------------------------
        [OperationBehavior]
        public bool CadastrarContrato(TipoContrato _TipoContrato)
        {
            try
            {
                using (TEEService.TEECRUDServiceClient client = new TEEService.TEECRUDServiceClient())
                {
                    return client.CadastrarContrato(Conversor.TipoContratoBusParaServico(_TipoContrato));
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [OperationBehavior]
        public TipoContrato DetalhesContrato(int id)
        {
            try
            {
                using (TEEService.TEECRUDServiceClient client = new TEEService.TEECRUDServiceClient())
                {
                    return Conversor.TipoContratoServicoParaBus(client.DetalhesContrato(id));
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [OperationBehavior]
        public List<TipoContrato> TodosContratos()
        {
            try
            {
                using (TEEService.TEECRUDServiceClient client = new TEEService.TEECRUDServiceClient())
                {
                    return Conversor.TipoContratoListaServicoParaBus(client.TodosContratos().ToList());
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        //----------------------------Distribuidora--------------------------------------------------------
        [OperationBehavior]
        public bool CadastrarDistribuidora(Distribuidora _Distribuidora)
        {
            try
            {
                using (TEEService.TEECRUDServiceClient client = new TEEService.TEECRUDServiceClient())
                {
                    return client.CadastrarDistribuidora(Conversor.DistribuidoraBusParaServico(_Distribuidora));
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [OperationBehavior]
        public Distribuidora DetalhesDistribuidora(int id)
        {
            try
            {
                using (TEEService.TEECRUDServiceClient client = new TEEService.TEECRUDServiceClient())
                {
                    return Conversor.DistribuidoraServicoParaBus(client.DetalhesDistribuidora(id));
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [OperationBehavior]
        public List<Distribuidora> TodasDistribuidoras()
        {
            try
            {
                using (TEEService.TEECRUDServiceClient client = new TEEService.TEECRUDServiceClient())
                {
                    return Conversor.DistribuidoraListaServicoParaBus(client.TodasDistribuidoras().ToList());
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        //----------------------------Tipo de SubGrupo-----------------------------------------------------

        public bool CadastrarSubGrupo(TipoSubGrupo _SubGrupo)
        {
            try
            {
                using (TEEService.TEECRUDServiceClient client = new TEEService.TEECRUDServiceClient())
                {
                    return client.CadastrarSubGrupo(Conversor.TipoSubGrupoBusParaServico(_SubGrupo));
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public TipoSubGrupo DetalhesSubGrupo(int id)
        {
            try
            {
                using (TEEService.TEECRUDServiceClient client = new TEEService.TEECRUDServiceClient())
                {
                    return Conversor.TipoSubGrupoServicoParaBus(client.DetalhesSubGrupo(id));
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<TipoSubGrupo> TodosSubGrupos()
        {
            try
            {
                using (TEEService.TEECRUDServiceClient client = new TEEService.TEECRUDServiceClient())
                {
                    return Conversor.TipoSubGrupoListaServicoParaBus(client.TodosSubGrupos().ToList());
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        //----------------------------Tarifa------------------------------------------------------------
        [OperationBehavior]
        public bool CadastrarTarifa(Tarifa _Tarifa)
        {
            try
            {
                using (TEEService.TEECRUDServiceClient client = new TEEService.TEECRUDServiceClient())
                {
                    return client.CadastrarTarifa(Conversor.TarifaBusParaServico(_Tarifa));
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [OperationBehavior]
        public Tarifa DestalhesDaTarifa(int id)
        {
            try
            {
                using (TEEService.TEECRUDServiceClient client = new TEEService.TEECRUDServiceClient())
                {
                    return Conversor.TarifaServicoParaBus(client.DestalhesDaTarifa(id));
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [OperationBehavior]
        public List<Tarifa> TodasTarifas()
        {
            try
            {
                using (TEEService.TEECRUDServiceClient client = new TEEService.TEECRUDServiceClient())
                {
                    return Conversor.TarifaListaServicoParaBus(client.TodasTarifas().ToList());
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [OperationBehavior]
        public bool AtualizarTarifa(Tarifa _Tarifa)
        {
            try
            {
                using (TEEService.TEECRUDServiceClient client = new TEEService.TEECRUDServiceClient())
                {
                    return client.AtualizarTarifa(Conversor.TarifaBusParaServico(_Tarifa));
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [OperationBehavior]
        public bool DeletarTarifa(Tarifa _Tarifa)
        {
            try
            {
                using (TEEService.TEECRUDServiceClient client = new TEEService.TEECRUDServiceClient())
                {
                    return client.DeletarTarifa(Conversor.TarifaBusParaServico(_Tarifa));
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //----------------------------Usuario------------------------------------------------------------

        public bool CadastrarUsuario(Usuario _Usuario)
        {
            try
            {
                using (TEEService.TEECRUDServiceClient client = new TEEService.TEECRUDServiceClient())
                {
                    return client.CadastrarUsuario(Conversor.UsuarioBusParaServico(_Usuario));
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Usuario VerificaAutenticacao(string email, string senha)
        {
            try
            {
                using (TEEService.TEECRUDServiceClient client = new TEEService.TEECRUDServiceClient())
                {
                    return Conversor.UsuarioServicoParaBus(client.VerificaAutenticacao(email, senha));
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Usuario DestalhesDoUsuario(string email)
        {
            try
            {
                using (TEEService.TEECRUDServiceClient client = new TEEService.TEECRUDServiceClient())
                {
                    return Conversor.UsuarioServicoParaBus(client.DestalhesDoUsuario(email));
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool AtualizarUsuario(Usuario _Usuario)
        {
            try
            {
                using (TEEService.TEECRUDServiceClient client = new TEEService.TEECRUDServiceClient())
                {
                    return client.AtualizarUsuario(Conversor.UsuarioBusParaServico(_Usuario));
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeletarUsuario(Usuario _Usuario)
        {
            try
            {
                using (TEEService.TEECRUDServiceClient client = new TEEService.TEECRUDServiceClient())
                {
                    return client.DeletarUsuario(Conversor.UsuarioBusParaServico(_Usuario));
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Usuario> ListarUsuarios(int ID)
        {
            try
            {
                using (TEEService.TEECRUDServiceClient client = new TEEService.TEECRUDServiceClient())
                {
                    return Conversor.UsuarioListaServicoParaBus(client.ListarUsuarios(ID).ToList());
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        //----------------------------Conta------------------------------------------------------------
        public bool CadastrarConta(Conta _Conta)
        {
            try
            {
                using (TEEService.TEECRUDServiceClient client = new TEEService.TEECRUDServiceClient())
                {
                    return client.CadastrarConta(Conversor.ContaBusParaServico(_Conta));
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Conta DestalhesDaConta(DateTime dataReferencia, int FabricaID)
        {
            try
            {
                using (TEEService.TEECRUDServiceClient client = new TEEService.TEECRUDServiceClient())
                {
                    return Conversor.ContaServicoParaBus(client.DestalhesDaConta(dataReferencia, FabricaID));
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Conta> TodasContas(int FabricaID)
        {
            try
            {
                using (TEEService.TEECRUDServiceClient client = new TEEService.TEECRUDServiceClient())
                {
                    return Conversor.ContaListaServicoParaBus(client.TodasContas(FabricaID).ToList());
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Conta> ConsultaEntreDatas(DateTime dataReferencia1, DateTime dataReferencia2, int FabricaID)
        {
            try
            {
                using (TEEService.TEECRUDServiceClient client = new TEEService.TEECRUDServiceClient())
                {
                    return Conversor.ContaListaServicoParaBus(client.ConsultaEntreDatas(dataReferencia1, dataReferencia2, FabricaID).ToList());
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool AtualizarConta(Conta _Conta)
        {
            try
            {
                using (TEEService.TEECRUDServiceClient client = new TEEService.TEECRUDServiceClient())
                {
                    return client.AtualizarConta(Conversor.ContaBusParaServico(_Conta));
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeletarConta(Conta _Conta)
        {
            try
            {
                using (TEEService.TEECRUDServiceClient client = new TEEService.TEECRUDServiceClient())
                {
                    return client.DeletarConta(Conversor.ContaBusParaServico(_Conta));
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //----------------------------Simulacao------------------------------------------------------------

        public bool GerarSimulacao(int fabricaID)
        {
            try
            {
                using (TEEService.TEECRUDServiceClient client = new TEEService.TEECRUDServiceClient())
                {
                    return client.GerarSimulacao(fabricaID);
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //----------------------------Grafico--------------------------------------------------------------

        public List<Grafico> DadosParaGrafico(int FabricaID)
        {
            try
            {
                using (TEEService.TEECRUDServiceClient client = new TEEService.TEECRUDServiceClient())
                {
                    return Conversor.GraficoListaServicoParaBus(client.DadosParaGrafico(FabricaID));
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
