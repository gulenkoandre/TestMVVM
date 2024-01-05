using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMVVM
{
    /*public class ConnectionLogin : INotifyPropertyChanged
    {
        #region========================================================Properties=============================================================
        
        /// <summary>
        /// Номер выбранного пользователем сервера в списке серверов (нумерация с 0)
        /// </summary>
        public byte TradingServerSelected
        {
            get { return _tradingServerSelected; }
            set
            {
                _tradingServerSelected = value;
                OnPropertyChanged("TradingServerSelected");
            }
        }
        private byte _tradingServerSelected;

        public string Login
        {
            get { return _login; }
            set
            {
                _login = value;
                OnPropertyChanged("Login");
            }
        }
        private string _login;

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged("Password");
            }
        }
        private string _password;

        #endregion

        #region========================================================Events & Methods==================================================================

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }

        #endregion
    }*/
}
