using CoreBaseLib.Models;
using System.Collections.Generic;
using System.Data;

namespace SqlLib2
{
	public interface INpgDbNonQuery
	{
		RVal ExecuteNpgNonQuery(string sqlTxt);
		RVal ExecuteNpgNonQuery(List<string> sqlTxtList);
		RVal ExecuteNpgNonQuery(IDbCommand cmd);
		RVal ExecuteNpgNonQuery(List<IDbCommand> cmdList);
		RVal ExecuteNpgScalar(IDbCommand cmd);

	}

}
