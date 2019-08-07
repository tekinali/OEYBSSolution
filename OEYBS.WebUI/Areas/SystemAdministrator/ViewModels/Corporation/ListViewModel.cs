using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OEYBS.Entities.Concrete;

namespace OEYBS.WebUI.Areas.SystemAdministrator.ViewModels.Corporation
{
    public class ListViewModel
    {
        public List<Entities.Concrete.Corporation> Corporations { get; set; }
    }
}