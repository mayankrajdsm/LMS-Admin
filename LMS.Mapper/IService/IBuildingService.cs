﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.Infrastructures.Models;

namespace LMS.Mapper.IService
{
    public interface IBuildingService
    {
        IEnumerable<Building> GetBuildings();
        int InsertBuilding(Building building);
    }
}