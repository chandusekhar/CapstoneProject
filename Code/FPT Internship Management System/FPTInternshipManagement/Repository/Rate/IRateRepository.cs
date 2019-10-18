﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
	public interface IRateRepository
	{
		List<Rate> GetAllRates();
		Dictionary<int,double> CalRate();
		List<User> GetTopRecruiter();
	}
}
