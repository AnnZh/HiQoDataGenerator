﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Infrastructure.Models;
using Infrastructure.Models.CustomObjectModels;

namespace Infrastructure.Repositories.PostgreRepositories
{
    public class TypesRepository:IRepository<FieldType>
    {
        DataContext _context;

        public TypesRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<FieldType> GetAll()
        {
            return _context.Types.ToList();
        }
        
        public FieldType GetById(int id)
        {
            return _context.Types.Where(type => type.Id == id).ToList().First();
        }

        public FieldType GetByName(string name)
        {
            return _context.Types.Where(type => type.Name == name).ToList().First();
        }

        public void Add(FieldType type)
        {
            _context.Types.Add(type);
            _context.SaveChanges();            
        }

        public void AddRange(List<FieldType> typesRange)
        {
            _context.Types.AddRange(typesRange);
            _context.SaveChanges();
        }

        public bool Remove(int id)
        {
            var typeToDelete = _context.Types.Where(type => type.Id == id).ToList().First();

            if (typeToDelete != null)
            {
                _context.Types.Remove(typeToDelete);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}