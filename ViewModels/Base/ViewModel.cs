using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TestMVVM.ViewModels.Base
{
    /// <summary>
    /// Базовый класс модели представления
    /// </summary>
    internal abstract class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged; //далее в программе это событие можно генерировать вручную

        // но чтобы вручную этого не делать создаем пару методов:

        //первый метод  - ему важно передать имя свойства (в нашем случае PropertyName) и внутри метода генерируем событие
        // также добавляем атрибут для компиллятора [CallerMemberName], теперь этот метод можно вызывать, не указывая в параметрах имя свойства
        // в этом случае компиллятор автоматически подставит в PropertyName имя метода из которого происходит вызов OnPropertyChanged
        protected virtual void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        // второй метод - для удобства создадим еще один метод:
        //его задачей будет обновлять значение Свойства, для которого определено Поле в котором это Свойство хранит свои данные
        //ref T field - это ссылка на Поле Свойства, T value - сюда передаем новое значение которое мы хотим установить,
        // а [CallerMemberName] string PropertyName = null - это имя Свойства, которое либо самостоятельно определяется компиллятором, либо мы указываем его вручную
        // задача данного метода - решить проблему кольцевых изменений свойств, которые могут возникать, 
        //т.е. когда обновление 1го свойства вызывает обновление 2го свойства, 2е - 3го свойства, а 3е - 1го свойства (круг замкнулся) и пошло зацикливание
        protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string PropertyName = null)
        {
            if(Equals(field, value)) return false; // если значение Поля, которое мы хотим обновить уже соответствует значению, которое мы передали, то ни чего не делаем и возвращаем Ложь

            //иначе если значение Свойства действительно изменилось и отличается от Поля, то меняем значение Поля и генерируем событие  OnPropertyChanged 
            field = value;

            OnPropertyChanged(PropertyName); 
            
            return true;
        }
    }
}
