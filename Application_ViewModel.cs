using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace TestMVVM
{
    public class Application_ViewModel : INotifyPropertyChanged
    {
        #region = Constructor ========================================================================================================

        public Application_ViewModel()
        {
            ServersList = new ObservableCollection<TradingServersList_Model>
            {
                new TradingServersList_Model {ServerName="АО \"Финам\"", IPDomain="tr1.finam.ru", Port="3900"},
                new TradingServersList_Model {ServerName="AO \"Финам\"", IPDomain="tr2.finam.online", Port="3900"},
                new TradingServersList_Model {ServerName="(HFT) AO \"Финам\"", IPDomain="hft.finam.ru", Port="13900"},
                new TradingServersList_Model {ServerName="(HFT) AO \"Финам\"", IPDomain="hft1.finam.ru", Port="13900"},
                new TradingServersList_Model {ServerName="Demo", IPDomain="tr1-demo5.finam.ru", Port="3939"}
            };
        }

        #endregion

        #region = Fields ==============================================================================================================
        #endregion

        #region = Properties ==========================================================================================================

        /// <summary>
        /// Список серверов
        /// </summary>
        public ObservableCollection<TradingServersList_Model> ServersList { get; set; }

        public TradingServersList_Model TradingServer
        {
            get { return _tradingServer; }
            set 
            {
                _tradingServer = value;

                OnPropertyChanged("TradingServer");
                
            } 
        }
        TradingServersList_Model _tradingServer;

        #endregion

        #region = Events & Methods ====================================================================================================

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        #endregion


    }
}
