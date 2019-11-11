// <copyright file="MainViewModel.cs" company="Visual Software Systems Ltd.">Copyright (c) 2019 All rights reserved</copyright>

namespace Vssl.Samples.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Input;
    using Vssl.Samples.Framework;
    using Vssl.Samples.ViewModelInterfaces;

    /// <summary>
    /// The view model for the main page
    /// </summary>
    public class MainViewModel : BaseViewModel, IMainViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainViewModel" /> class.
        /// </summary>
        public MainViewModel()
        {
            this.ShowSettingsCommand = new DelegateCommandAsync(this.ShowSettings, (p) => { return true; });
            this.AboutCommand = new DelegateCommandAsync(this.About, (p) => { return true; });
            this.SignOutCommand = new DelegateCommandAsync(this.SignOut, (p) => { return true; });
        }

        /// <summary>
        /// Gets a command the displays the settings
        /// </summary>
        public ICommand ShowSettingsCommand { get; private set; }

        /// <summary>
        /// Gets a command that displays info about the app
        /// </summary>
        public ICommand AboutCommand { get; private set; }

        /// <summary>
        /// Gets a command that signs out of the app
        /// </summary>
        public ICommand SignOutCommand { get; private set; }

        /// <summary>
        /// Gets a value indicating whether a button tap occurred (acts as a toggle)
        /// </summary>
        public bool WasTapped { get; private set; }

        /// <summary>
        /// Displays the settings
        /// </summary>
        /// <param name="parameter">An optional parameter</param>
        /// <returns>An awaitable task</returns>
        public async Task ShowSettings(object parameter)
        {
            // Not implemented in this sample
            this.WasTapped = !this.WasTapped;
            this.OnPropertyChanged("WasTapped");
            await Task.CompletedTask;
        }

        /// <summary>
        /// Displays info about the app
        /// </summary>
        /// <param name="parameter">An optional parameter</param>
        /// <returns>An awaitable task</returns>
        public async Task About(object parameter)
        {
            // Not implemented in this sample
            this.WasTapped = !this.WasTapped;
            this.OnPropertyChanged("WasTapped");
            await Task.CompletedTask;
        }

        /// <summary>
        /// Signs out of the app
        /// </summary>
        /// <param name="parameter">An optional parameter</param>
        /// <returns>An awaitable task</returns>
        public async Task SignOut(object parameter)
        {
            // Not implemented in this sample
            this.WasTapped = !this.WasTapped;
            this.OnPropertyChanged("WasTapped");
            await Task.CompletedTask;
        }
    }
}
