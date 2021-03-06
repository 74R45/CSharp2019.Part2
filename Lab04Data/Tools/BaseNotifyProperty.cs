﻿using System.ComponentModel;
using System.Runtime.CompilerServices;
using KMA.ProgrammingInCSharp2019.Kreshchenko.Part2.Lab04Data.Annotations;

namespace KMA.ProgrammingInCSharp2019.Kreshchenko.Part2.Lab04Data.Tools
{
    internal abstract class BaseNotifyProperty : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
