using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TestMVVM.Infrastructure.Commands.Base
{
    internal abstract class Command : ICommand //содержимое класса ниже - это минимум, который необходим, чтобы команда хоть как-то заработала в наследниках
    {
        public event EventHandler CanExecuteChanged //это событие генерируется, когда команда переходит из одного состояние в другое
                                                     //т.е. когда функция CanExecute меняет возвращаемое значение на противоположное
                                                     //это событие можно вызывать когда мы хотим сами 
                                                     //или можем передать управление вызовом события системе WPF, тогда пишется тело события:
        {
            add => CommandManager.RequerySuggested += value; //добавляем обработчик события, которое кто-то пытался вызвать в CanExecuteChanged
            
            remove => CommandManager.RequerySuggested -= value; //убираем обработчик события
            
        }


        public abstract bool CanExecute(object parameter); //если эта функция возвращает ложь, то команду выполнить нельзя,
                                                           //а если команду выполнить нельзя, то элемент к которому прявязана команда отключается автоматически
                                                           //т.е. когда мы описываем команды, мы можем с их помощью контролировать активность визуальных элементов на экране
                                                           //если мы хотим выключить возможность работы с каким-то визуальным элементом, мы у команды просто в этом методе 
                                                           //должны возвращать false
                                                           // делаем абстрактным, его реализацией займется наследник

        public abstract void Execute(object parameter); //это то, что должно быть выполнено самой командой, т.е. логика команды, которую она должна выполнять
                                                        // делаем абстрактным, его реализацией займется наследник

    }
}
