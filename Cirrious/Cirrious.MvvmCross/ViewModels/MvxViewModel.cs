// MvxViewModel.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using System.Runtime.Serialization;

namespace Cirrious.MvvmCross.ViewModels
{
    [DataContract]
    public abstract class MvxViewModel
        : MvxNavigatingObject
          , IMvxViewModel
    {
        protected MvxViewModel()
        {
            RequestedBy = MvxRequestedBy.Unknown;
        }

        public MvxRequestedBy RequestedBy { get; set; }

        public void Init(IMvxBundle parameters)
        {
            InitFromBundle(parameters);
        }

        public void ReloadState(IMvxBundle state)
        {
            ReloadFromBundle(state);
        }

        public virtual void Start()
        {
        }

        public void SaveState(IMvxBundle state)
        {
            SaveStateToBundle(state);
        }

        protected virtual void InitFromBundle(IMvxBundle parameters)
        {
        }

        protected virtual void ReloadFromBundle(IMvxBundle state)
        {
        }

        protected virtual void SaveStateToBundle(IMvxBundle bundle)
        {
        }
    }
}
