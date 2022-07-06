﻿using RS2Seminarski.Controllers;
using RS2Seminarski.Model;
using RS2Seminarski.Model.Requests;
using RS2Seminarski.Model.SearchObjects;
using RS2Seminarski.WebAPI.Interfaces;

namespace RS2Seminarski.WebAPI.Controllers
{
    public class RoutineController : BaseCRUDController<Routine, RoutineSearchObject, RoutineInsertRequest, RoutineUpdateRequest>
    {
        public RoutineController(IRoutineService service)
            : base(service)
        {
        }

    }
}
