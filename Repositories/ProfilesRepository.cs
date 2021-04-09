using System;
using System.Data;
using sharpblogger.Models;

namespace sharpblogger.Repositories
{
    public class ProfilesRepository
    {
        private readonly IDbConnection _db;

        public ProfilesRepository(IDbConnection db)
        {
            _db = db;
        }

        internal Profile GetById(object id)
        {
            throw new NotImplementedException();
        }

        internal Profile Create(Profile userInfo)
        {
            throw new NotImplementedException();
        }
    }
}