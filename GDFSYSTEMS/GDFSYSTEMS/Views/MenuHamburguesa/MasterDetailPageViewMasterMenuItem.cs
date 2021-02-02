using System;

namespace GDFSYSTEMS.Views.MenuHamburguesa
{

    public class MasterDetailPageViewMasterMenuItem
    {
        //public MasterDetailPageViewMasterMenuItem()
        //{
        //    TargetType = typeof(MasterDetailPageViewMasterMenuItem);
        //}
        public int Id { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public Type TargetType { get; set; }
    }
}