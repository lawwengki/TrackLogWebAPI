using System.Collections.Generic;
using System.Data;

namespace SqlLib2
{
    public interface INpgDbQuery
    {
        //PostgreSQL
        DataTable ExecuteNpgQuery(IDbCommand cmd);
        DataTable ExecuteNpgQuery(string sqlTxt);
        DataSet ExecuteNpgQuery(List<IDbCommand> cmdList);
        DataSet ExecuteNpgQuery(List<string> sqlTxtList);

    }
}
