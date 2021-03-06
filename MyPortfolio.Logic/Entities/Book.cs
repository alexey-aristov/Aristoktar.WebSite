﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortfolio.Logic.Entities {
	public class Book {
		public int Id {
			get;
			set;
		}
		public string Name {
			get;
			set;
		}

		public int? AuthorId {
			get;
			set;
		}
		public virtual Author Author {
			get;
			set;
		}

		public string Description {
			get;
			set;
		}

		public int? LogoId {
			get;
			set;
		}

		public int? FileId {
			get;
			set;
		}
	}
}
