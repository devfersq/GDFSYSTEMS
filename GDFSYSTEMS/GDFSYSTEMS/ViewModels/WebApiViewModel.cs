using GDFSYSTEMS.ViewModels.Base;
using System;

namespace GDFSYSTEMS.ViewModels
{
    public  class WebApiViewModel: BaseViewModel
    {
             public string Title { get; set; }
        public WebApiViewModel()
        {
            try
            {
                Title = "Web Api jsonplaceholder";
            }
            catch (Exception ex) 
            {
                var error = ex.ToString();
            }
        }
    }
}
