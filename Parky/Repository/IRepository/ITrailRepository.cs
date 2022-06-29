﻿using Parky.Models;
using Parky.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Parky.Repository.IRepository
{
    public interface ITrailRepository
    {
        ICollection<Trail> GetTrails();

        ICollection<Trail> GetTrailsInNationalPark(int npId);
        Trail GetTrail(int trailId);

        bool TrailExists(string name);

        bool TrailExists(int trailId);

        bool CreateTrail(Trail trail);

        bool UpdateTrail(Trail trail);

        bool DeleteTrail(Trail trail);

        bool Save();

    }
}
