using System;
using System.Collections.Generic;
using System.Text;
using AppCountry.ViewModels;

namespace AppCountry.ViewModel
{
    
    public class MainViewModel
    {
        #region ViewModels
        public CountryViewModel Countries { get; set; }
        #endregion

        #region Constructor
        public MainViewModel()
        {
            this.Countries = new CountryViewModel();
        }
        #endregion
    }
}
