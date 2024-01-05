using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TestMVVM.Infrastructure.Commands;
using TestMVVM.ViewModels.Base;

namespace TestMVVM.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region = Constructor ==========================================================================================================

        public MainWindowViewModel()
        {
            #region Commands

            ExitApplicationCommand = new LambdaCommand(OnExitApplicationCommandExecuted, CanExitApplicationCommandExecute);

            #endregion Commands
        }

        #endregion = Constructor =

        #region = Commands =============================================================================================================

        #region ExitApplicationCommand  Команда на закрытие приложения по пункту меню Exit
        /// <summary>
        /// Команда на закрытие приложения по пункту меню Exit
        /// </summary>
        public ICommand ExitApplicationCommand { get; }

        private bool CanExitApplicationCommandExecute(object p) => true;
        private void OnExitApplicationCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        }

        #endregion ExitApplicationCommand 


        #endregion = Commands =

        #region = Properties ===========================================================================================================

        /// <summary>
        /// Заголовок главного окна
        /// </summary>
        public string Title
        {
            get => _title;
            //set
            //{   //наш сеттер должен был быть таким
            //    //if (Equals(_title, value)) return;
            //    //_title = value;
            //    //OnPropertyChanged();
            //    //но у нас для этого приготовлен метод:

            //    Set(ref _title, value);
            //} 
            //можно еще короче:
            set => Set(ref _title, value);
        
        }

        private string _title="Transaq Connector";

        #endregion = Properties =
    }
}
