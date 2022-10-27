//Jovann Contreras
//Date 10/25/2022
//Peer reviewed by Carlos Felipe: This program works well and even has the ability to choose between am and pm. That was a nice touch that enhances the overall feel of the program. Good job.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Asking.Models;

namespace ContrerasJAskingQuestionAPI.Controllers
{
    [Route("[controller]")]
    public class QuestionsController : Controller
    {
        [HttpGet]
        [Route("Ask")]

        public string MiniCH3(AskingModel item)
        {
            return $"Hello {item.Name} you woke up at {item.Time}{item.AMorPM}";
        }
    }
}