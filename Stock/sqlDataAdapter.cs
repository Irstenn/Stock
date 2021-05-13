using System;
using System.Data;

namespace Stock
{
    internal class sqlDataAdapter
    {
        private string v;
        private sqlConnection con;

        public sqlDataAdapter(string v, sqlConnection con)
        {
            this.v = v;
            this.con = con;
        }

        internal void Fill(DataTable dt)
        {
            throw new NotImplementedException();
        }
    }
}