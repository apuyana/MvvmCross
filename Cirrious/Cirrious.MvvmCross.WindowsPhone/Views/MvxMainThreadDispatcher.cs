// MvxMainThreadDispatcher.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

#region using

using System;
using System.Windows.Threading;
using Cirrious.MvvmCross.Interfaces.Views;
using System.Windows;

#endregion

namespace Cirrious.MvvmCross.WindowsPhone.Views
{
    public class MvxMainThreadDispatcher : IMvxMainThreadDispatcher
    {
        private readonly Dispatcher _uiDispatcher;

        public MvxMainThreadDispatcher(Dispatcher uiDispatcher)
        {
            _uiDispatcher = uiDispatcher;
        }

        #region IMvxMainThreadDispatcher Members

        public bool RequestMainThreadAction(Action action)
        {
            bool execute = (action != null) && (Deployment.Current.Dispatcher != null);
            if (execute)
            {
                Deployment.Current.Dispatcher.BeginInvoke(action);
            }

            return execute;
        }

        #endregion
    }
}