﻿using System;

namespace Bit.App.Pages
{
    public partial class OptionsPage : BaseContentPage
    {
        private readonly OptionsPageViewModel _vm;

        public OptionsPage()
        {
            InitializeComponent();
            _vm = BindingContext as OptionsPageViewModel;
            _vm.Page = this;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await _vm.InitAsync();
        }
    }
}
