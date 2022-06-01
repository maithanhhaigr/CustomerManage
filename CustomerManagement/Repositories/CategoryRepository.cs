﻿using CustomerManagement.Data;
using CustomerManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.Repositories
{
    public class CategoryRepository: ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }


    }
}
