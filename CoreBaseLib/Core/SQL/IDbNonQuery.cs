using CoreBaseLib.Models;
using System.Collections.Generic;
using System.Data;

namespace SqlLib2
{
	public interface IDbNonQuery
	{
		RVal ExecuteNonQuery(string sqlTxt);
		RVal ExecuteNonQuery(List<string> sqlTxtList);
		RVal ExecuteNonQuery(IDbCommand cmd);
		RVal ExecuteNonQuery(List<IDbCommand> cmdList);
		RVal ExecuteScalar(IDbCommand cmd);

	}

}
