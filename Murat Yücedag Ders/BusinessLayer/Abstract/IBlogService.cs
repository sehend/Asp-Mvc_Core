﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IblogService
    {

        void BlogAdd(Blog  blog);

        void BlogRemove(Blog  blog);

        void BlogUpdate(Blog  blog);

        List<Blog> GetList();

        Blog GetById(int id);

        List<Blog> GetBlockListWithGetCategory();

        
    }
}
