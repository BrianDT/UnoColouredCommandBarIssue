// <copyright file="IMainViewModel.cs" company="Visual Software Systems Ltd.">Copyright (c) 2019 All rights reserved</copyright>

namespace Vssl.Samples.ViewModelInterfaces
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Windows.Input;

    /// <summary>
    /// The view model for the main page
    /// </summary>
    public interface IMainViewModel : IBaseViewModel
    {
        /// <summary>
        /// Gets a command the displays the settings
        /// </summary>
        ICommand ShowSettingsCommand { get; }

        /// <summary>
        /// Gets a command that displays info about the app
        /// </summary>
        ICommand AboutCommand { get; }

        /// <summary>
        /// Gets a command that signs out of the app
        /// </summary>
        ICommand SignOutCommand { get; }

        /// <summary>
        /// Gets a value indicating whether a button tap occurred (acts as a toggle)
        /// </summary>
        bool WasTapped { get; }
    }
}
