using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace TrainingTracker_Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TimesheetDetailsController : ControllerBase
    {
        private static readonly TimesheetDetails[] timesheetDetails= new[]
        {
            new TimesheetDetails { CourseName = "C1",  EmpId= 000, EmpName = "AAA", TrainingEndDate=new DateTime(2022,12,12), TrainingStartDate=new DateTime(2022,11,11),TrainingStatus="Ongoing"},
            new TimesheetDetails { CourseName = "C2", EmpId= 111, EmpName = "BBB", TrainingEndDate=new DateTime(2022,12,12), TrainingStartDate=new DateTime(2022,11,11),TrainingStatus="Ongoing"},
            new TimesheetDetails { CourseName = "C3", EmpId= 222, EmpName = "CCC",  TrainingEndDate=new DateTime(2022,12,12), TrainingStartDate=new DateTime(2022,11,11),TrainingStatus="Ongoing"}
        };


        private readonly ILogger<TimesheetDetailsController> _logger;

        public TimesheetDetailsController(ILogger<TimesheetDetailsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public TimesheetDetails[] Get()
        {
            return timesheetDetails;
        }

    }
}
