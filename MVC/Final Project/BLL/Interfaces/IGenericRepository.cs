﻿using BLL.Interfaces;
using DAL.Context;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        T GetEntityById(int? id);

        IEnumerable<T> GetAll();

        void Add(T Entity);

        void Update(T Entity);

        void Delete(T Entity);
    }
}
