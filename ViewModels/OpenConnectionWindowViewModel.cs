using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMVVM.ViewModels.Base;

namespace TestMVVM.ViewModels
{
    internal class OpenConnectionWindowViewModel : ViewModel
    {
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

        private string _title = "Connection";

        #endregion
    }
}
