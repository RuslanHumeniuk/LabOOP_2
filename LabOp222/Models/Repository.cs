﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOp222.Models
{
    public class Repository<T> where T : MediaInfo
    {
        public IList<T> MediaInfoObjects = new List<T>();

        public void Add(T obj)
        {
            this.MediaInfoObjects.Add(obj);
        }

        public bool Remove(T obj)
        {
            return this.MediaInfoObjects.Remove(obj);
        }
    }
}
