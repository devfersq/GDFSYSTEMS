using GDFSYSTEMS.ViewModels.Base;
using System;

namespace GDFSYSTEMS.ViewModels
{
    public class MiInformacionViewModel: BaseViewModel
    {
        public string Title { get; set; }
        
        public MiInformacionViewModel()
        {
            try
            {
                Title = "Acerca de mi";
                TextoLabelView = "Hola" + "\r\n" + "Soy Fernando Sanchez Q, tengo 29 años y cuento con amplio conocimiento en el sector (Movil), lo cual facilita y enriquecerá mi trabajo, soy muy bueno para enfrentar nuevos retos, tengo habilidad para cerrar buenos tratos con proveedores como Consultor de TI, además de lograr soluciones a problemas de últimos minuto. Paralelamente, tengo buen manejo con los lenguajes Java & C#. Cuento con noción para Aplicaciones Hibridas con las tecnologías (AngularJS, JQuery, NodeJS, Backbone, bootstrap y WinJS) usando Flutter. Para backend (SQL Server 2008,2014, Postgres, SQLite, MySql y Oracle), para Arquitecturas de software Móvil se usar MVC (Modelo Vista Controlador) o MVVM (Modelo–Vista–Vista-Modelo), con tecnologías de terceros (Apis) tengo noción de Syncfusion, GoogleApis, Telerik y Azure, también cuento con experiencia con Xamarin Form y Xamarin Portable en .Net."+"\r\n"+
                    "Entornos de Desarrollo que uso son"+ "\r\n" + "VS(visual studio), Xamarin Studio, Android studio, Flutter"+ "\r\n" + "OS (Sistemas Operativos) que uso son:"+"\r\n"+ "Macintosh Operating System, FreeBSD, Windows"+ "\r\n"+ "Por último, cuento con 5 reconocimiento internacionales de robótica por la IPN Instituto Politécnico Nacional de México, Tecmilenio, universidad jesuita de Guadalajara, Universidad Autónoma del Perú y por la Universidad Politécnica de Amozoc (UPAM).";
            }
            catch (Exception ex)
            {
                var error = ex.ToString();
            }
        }
        #region Mapeo Get y Set Labe
       
        private string _TextoLabelView;
        public string TextoLabelView
        {
            get { return _TextoLabelView; }
            set
            {
                _TextoLabelView = value;
                OnPropertyChanged(nameof(TextoLabelView)); // Notify that there was a change on this property
            }
        }
        #endregion
    }
}
