﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace intro_mvc_6.Models
{
    public class ApplicationRepository : IApplicationRepository
    {
        private ApplicationDbContext _context;

        public ApplicationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<ToDo> GetAllTodos()
        {
            return _context.ToDos.ToList();
        } 
    }

    public interface IApplicationRepository
    {
        List<ToDo> GetAllTodos();
    }
}


