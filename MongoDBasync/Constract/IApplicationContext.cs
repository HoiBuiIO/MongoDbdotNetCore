using MongoDB.Driver;
using MongoDBasync.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDBasync.Constract
{
	public interface IApplicationContext
	{
		IMongoCollection<Game> Games { get; }
	}
}
