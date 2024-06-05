﻿
using DataLayer.Model;
using DataLayer.Repository.GenericRepository;
using DataLayer.Repository.SpecificRepository.Interface;
using DataLayer.Entity;
namespace DataLayer.Repository.SpecificRepository.Class;

public class NewsRepository : GenericRepository<News>, INewsRepository
{
    public NewsRepository(ApplicationDbContext context) : base(context)
    {
    }
}