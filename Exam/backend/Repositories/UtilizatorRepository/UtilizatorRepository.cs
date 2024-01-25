﻿using backend.Data;
using backend.Models;
using backend.Repositories.GenericRepository;

namespace backend.Repositories.TestRepository;

public class UtilizatorRepository : GenericRepository<Utilizator>, IUtilizatorRepository
{
    public UtilizatorRepository(DatabaseContext dbContext) : base(dbContext) {}
}