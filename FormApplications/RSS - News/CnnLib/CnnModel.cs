using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlugInProxy;

namespace CnnLib
{
    public class CnnModel : IRssMembers
    {
        private string _link;
        private string _source;
        private string _title;
        private string _description;

        public string Link
        {
            get
            {
                return this._link;
            }

            set
            {
                this._link = value;
            }
        }

        public string Source
        {
            get
            {
                return this._source;
            }

            set
            {
                this._source = value;
            }
        }

        public string Title
        {
            get
            {
                return this._title;
            }

            set
            {
                this._title = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
            }
        }
    }
}
