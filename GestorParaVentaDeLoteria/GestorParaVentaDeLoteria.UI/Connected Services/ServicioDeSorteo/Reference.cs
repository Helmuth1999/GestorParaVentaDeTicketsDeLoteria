﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestorParaVentaDeLoteria.UI.ServicioDeSorteo {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioDeSorteo.IServicioDeSorteo")]
    public interface IServicioDeSorteo {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDeSorteo/Listar", ReplyAction="http://tempuri.org/IServicioDeSorteo/ListarResponse")]
        GestorParaVentaDeLoteria.Modelo.Sorteos[] Listar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDeSorteo/Listar", ReplyAction="http://tempuri.org/IServicioDeSorteo/ListarResponse")]
        System.Threading.Tasks.Task<GestorParaVentaDeLoteria.Modelo.Sorteos[]> ListarAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDeSorteo/Agregar", ReplyAction="http://tempuri.org/IServicioDeSorteo/AgregarResponse")]
        void Agregar(GestorParaVentaDeLoteria.Modelo.Sorteos item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDeSorteo/Agregar", ReplyAction="http://tempuri.org/IServicioDeSorteo/AgregarResponse")]
        System.Threading.Tasks.Task AgregarAsync(GestorParaVentaDeLoteria.Modelo.Sorteos item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDeSorteo/ActivarSorteo", ReplyAction="http://tempuri.org/IServicioDeSorteo/ActivarSorteoResponse")]
        void ActivarSorteo(GestorParaVentaDeLoteria.Modelo.SorteosHistorico item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDeSorteo/ActivarSorteo", ReplyAction="http://tempuri.org/IServicioDeSorteo/ActivarSorteoResponse")]
        System.Threading.Tasks.Task ActivarSorteoAsync(GestorParaVentaDeLoteria.Modelo.SorteosHistorico item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDeSorteo/InactivarSorteo", ReplyAction="http://tempuri.org/IServicioDeSorteo/InactivarSorteoResponse")]
        void InactivarSorteo(GestorParaVentaDeLoteria.Modelo.SorteosHistorico item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDeSorteo/InactivarSorteo", ReplyAction="http://tempuri.org/IServicioDeSorteo/InactivarSorteoResponse")]
        System.Threading.Tasks.Task InactivarSorteoAsync(GestorParaVentaDeLoteria.Modelo.SorteosHistorico item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDeSorteo/ConsultarSorteo", ReplyAction="http://tempuri.org/IServicioDeSorteo/ConsultarSorteoResponse")]
        GestorParaVentaDeLoteria.Modelo.Sorteos ConsultarSorteo(int idSorteo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDeSorteo/ConsultarSorteo", ReplyAction="http://tempuri.org/IServicioDeSorteo/ConsultarSorteoResponse")]
        System.Threading.Tasks.Task<GestorParaVentaDeLoteria.Modelo.Sorteos> ConsultarSorteoAsync(int idSorteo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDeSorteo/ListarHistoricoDeSorteo", ReplyAction="http://tempuri.org/IServicioDeSorteo/ListarHistoricoDeSorteoResponse")]
        GestorParaVentaDeLoteria.Modelo.SorteosHistorico[] ListarHistoricoDeSorteo(int idSorteo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDeSorteo/ListarHistoricoDeSorteo", ReplyAction="http://tempuri.org/IServicioDeSorteo/ListarHistoricoDeSorteoResponse")]
        System.Threading.Tasks.Task<GestorParaVentaDeLoteria.Modelo.SorteosHistorico[]> ListarHistoricoDeSorteoAsync(int idSorteo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDeSorteo/ConsultarIdDeSorteoHistorico", ReplyAction="http://tempuri.org/IServicioDeSorteo/ConsultarIdDeSorteoHistoricoResponse")]
        GestorParaVentaDeLoteria.Modelo.SorteosHistorico ConsultarIdDeSorteoHistorico(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDeSorteo/ConsultarIdDeSorteoHistorico", ReplyAction="http://tempuri.org/IServicioDeSorteo/ConsultarIdDeSorteoHistoricoResponse")]
        System.Threading.Tasks.Task<GestorParaVentaDeLoteria.Modelo.SorteosHistorico> ConsultarIdDeSorteoHistoricoAsync(int Id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioDeSorteoChannel : GestorParaVentaDeLoteria.UI.ServicioDeSorteo.IServicioDeSorteo, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioDeSorteoClient : System.ServiceModel.ClientBase<GestorParaVentaDeLoteria.UI.ServicioDeSorteo.IServicioDeSorteo>, GestorParaVentaDeLoteria.UI.ServicioDeSorteo.IServicioDeSorteo {
        
        public ServicioDeSorteoClient() {
        }
        
        public ServicioDeSorteoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioDeSorteoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioDeSorteoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioDeSorteoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public GestorParaVentaDeLoteria.Modelo.Sorteos[] Listar() {
            return base.Channel.Listar();
        }
        
        public System.Threading.Tasks.Task<GestorParaVentaDeLoteria.Modelo.Sorteos[]> ListarAsync() {
            return base.Channel.ListarAsync();
        }
        
        public void Agregar(GestorParaVentaDeLoteria.Modelo.Sorteos item) {
            base.Channel.Agregar(item);
        }
        
        public System.Threading.Tasks.Task AgregarAsync(GestorParaVentaDeLoteria.Modelo.Sorteos item) {
            return base.Channel.AgregarAsync(item);
        }
        
        public void ActivarSorteo(GestorParaVentaDeLoteria.Modelo.SorteosHistorico item) {
            base.Channel.ActivarSorteo(item);
        }
        
        public System.Threading.Tasks.Task ActivarSorteoAsync(GestorParaVentaDeLoteria.Modelo.SorteosHistorico item) {
            return base.Channel.ActivarSorteoAsync(item);
        }
        
        public void InactivarSorteo(GestorParaVentaDeLoteria.Modelo.SorteosHistorico item) {
            base.Channel.InactivarSorteo(item);
        }
        
        public System.Threading.Tasks.Task InactivarSorteoAsync(GestorParaVentaDeLoteria.Modelo.SorteosHistorico item) {
            return base.Channel.InactivarSorteoAsync(item);
        }
        
        public GestorParaVentaDeLoteria.Modelo.Sorteos ConsultarSorteo(int idSorteo) {
            return base.Channel.ConsultarSorteo(idSorteo);
        }
        
        public System.Threading.Tasks.Task<GestorParaVentaDeLoteria.Modelo.Sorteos> ConsultarSorteoAsync(int idSorteo) {
            return base.Channel.ConsultarSorteoAsync(idSorteo);
        }
        
        public GestorParaVentaDeLoteria.Modelo.SorteosHistorico[] ListarHistoricoDeSorteo(int idSorteo) {
            return base.Channel.ListarHistoricoDeSorteo(idSorteo);
        }
        
        public System.Threading.Tasks.Task<GestorParaVentaDeLoteria.Modelo.SorteosHistorico[]> ListarHistoricoDeSorteoAsync(int idSorteo) {
            return base.Channel.ListarHistoricoDeSorteoAsync(idSorteo);
        }
        
        public GestorParaVentaDeLoteria.Modelo.SorteosHistorico ConsultarIdDeSorteoHistorico(int Id) {
            return base.Channel.ConsultarIdDeSorteoHistorico(Id);
        }
        
        public System.Threading.Tasks.Task<GestorParaVentaDeLoteria.Modelo.SorteosHistorico> ConsultarIdDeSorteoHistoricoAsync(int Id) {
            return base.Channel.ConsultarIdDeSorteoHistoricoAsync(Id);
        }
    }
}
