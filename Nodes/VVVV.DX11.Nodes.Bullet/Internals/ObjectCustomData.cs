﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VVVV.Internals.Bullet
{
	public class ObjectCustomData
	{

		public ObjectCustomData()
		{
			this.MarkedForDeletion = false;
            this.LifeTime = 0;
		}

		public int Id { get; set; }
		public string Custom { get; set; }

		//I dont delete body directly, that cause many crashes
		//Instead they deleted just before the time step on world node
		public bool MarkedForDeletion { get; set; }
		public bool Created { get; set; }
        public double LifeTime { get; set; }

		public ICloneable CustomObject { get; set; }

	}
}
