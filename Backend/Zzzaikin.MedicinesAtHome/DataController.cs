using Microsoft.AspNetCore.Mvc;

namespace Zzzaikin.MedicinesAtHome
{
    [ApiController]
    [Route("[controller]")]
    public class DataController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public DataController(AppDbContext appDbContext) 
        {
            _appDbContext = appDbContext;
        }
    }
}
