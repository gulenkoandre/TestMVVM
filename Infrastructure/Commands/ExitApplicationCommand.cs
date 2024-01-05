﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TestMVVM.Infrastructure.Commands.Base;

namespace TestMVVM.Infrastructure.Commands
{
    internal class ExitApplicationCommand : Command
    {
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter) => Application.Current.Shutdown();
        
    }
}
