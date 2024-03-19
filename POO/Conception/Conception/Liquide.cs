using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Conception
{
    public class Liquide
    {
		private string _nom = "";
		private string _type = "";

		public string Nom
		{
			get { return _nom; }
		}
        public string Type
        {
            get { return _type; }
        }

    }
}
