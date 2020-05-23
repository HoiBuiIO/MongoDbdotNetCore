using MongoDBasync.Constract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDBasync.Services
{
	public class DatabaseSetting : IDatabaseSetting
	{
		public string ConnectionString { get; set; }
		public string DatabaseName { get; set; }
	}
}
