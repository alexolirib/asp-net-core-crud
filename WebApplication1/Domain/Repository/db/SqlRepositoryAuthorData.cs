﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationCore.Data;

namespace WebApplicationCore.Domain.Repository
{
    public class SqlRepositoryAuthorData : IRepositoryAuthor
    {
        private CollegeDbContext _context;

        public SqlRepositoryAuthorData(CollegeDbContext context)
        {
            _context = context;
        }
        public Author add(Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();
            return author;
        }

        public IEnumerable<Author> GetAllAuthor()
        {
            return _context.Authors.OrderBy(c => c.id);
        }

        public Author GetAuthorById(int id)
        {
            return _context.Authors.FirstOrDefault(c => c.id == id);
        }

        public void remove(Author author)
        {
            _context.Authors.Remove(author);
            _context.SaveChanges();
        }

        public Author upDate(Author author)
        {
            _context.Authors.Update(author);
            _context.SaveChanges();
            return author;
        }
    }
}
