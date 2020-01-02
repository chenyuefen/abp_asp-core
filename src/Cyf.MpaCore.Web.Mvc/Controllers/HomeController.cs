﻿using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Cyf.MpaCore.Controllers;

namespace Cyf.MpaCore.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : MpaCoreControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
