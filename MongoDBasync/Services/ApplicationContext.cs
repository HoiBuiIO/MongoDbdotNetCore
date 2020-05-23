using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDBasync.Constract;
using MongoDBasync.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDBasync.Services
{
	public class ApplicationContext: IApplicationContext
	{
		private readonly IMongoDatabase _db;

		public ApplicationContext(IOptions<DatabaseSetting> options)
		{
			var client = new MongoClient(options.Value.ConnectionString);
			_db = client.GetDatabase(options.Value.DatabaseName);
		}

		public IMongoCollection<Game> Games => _db.GetCollection<Game>("Games");
	}
}
