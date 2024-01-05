using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMVVM.Infrastructure.Commands.Base;

namespace TestMVVM.Infrastructure.Commands
{
    internal class LambdaCommand : Command
    {
        #region = Fields ==============================================================================================

        private readonly Action<object> _execute;

        private readonly Func<object, bool> _canExecute;

        #endregion

        #region = Constructor =========================================================================================
        
        public LambdaCommand(Action<object> Execute, Func<object, bool> CanExecute = null)

        //в конструкторе надо получить два делегата
        // один, который будет выполняться методом CanExecute
        // и второй, который будет выполняться методом Execute
        // Action - это встроенный делегат, который ни чего не возвращает (void)
        // Func - это встроенный делегат, возвращает результат метода
        {
            _execute = Execute ?? throw new ArgumentNullException(nameof(Execute)); //ArgumentExceptio генерируется, ксли в метод для параметра передается null значение 
                                                                                // ?? - возвращает левый операнд, если он не равен null, иначе возвращает правый операнд - в нашем случае генерирует исключение
            _canExecute = CanExecute;
        }

        #endregion

        public override bool CanExecute(object parameter) =>_canExecute?.Invoke(parameter) ?? true; //даже если нет делегата, то считаем, что команду всек равно можно выполнить в любом случае (поэтому возвращаем true, даже если левый операнд null)
        
        public override void Execute(object parameter) => _execute(parameter);
        
    }
}
