
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TestMVVM
{
    public class TradingServersList_Model : INotifyPropertyChanged
    {
        #region = Constructor ===================================================================================
        #endregion

        #region = Fields ========================================================================================
        #endregion

        #region = Properties ====================================================================================

        /// <summary>
        /// Наименование сервера
        /// </summary>
        public string ServerName
        {
            get
            {return _serverName;}

            set
            {
                _serverName = value;
                OnPropertyChanged("ServerName");
            }
            
        }
        string _serverName;

        /// <summary>
        /// IP-адресс или Доменное имя сервера
        /// </summary>
        public string IPDomain
        {
            get
            {
                return _ipDomain;
            }

            set
            {
                _ipDomain = value;
                OnPropertyChanged("IPDomain");
            }

        }
        string _ipDomain;

        /// <summary>
        /// Порт для данного IP/Domain
        /// </summary>
        public string Port
        {
            get
            {
                return _port;
            }

            set
            {
                _port = value;
                OnPropertyChanged("Port");
            }

        }
        string _port;

        #endregion

        #region = Events and Methods ============================================================================

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        #endregion

    }
}
