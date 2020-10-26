using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using Npgsql;
namespace SqlLib2
{
    public class NpgSqlDbTypeMap
    {
        private static Dictionary<Type, NpgsqlDbType> _typeMap;
        public NpgSqlDbTypeMap()
        {
            SetTypeMap();
        }

        private static void SetTypeMap()
        {
            if (_typeMap == null)
            {
                _typeMap = new Dictionary<Type, NpgsqlDbType>();
                _typeMap[typeof(Guid)] = NpgsqlDbType.Uuid;
                _typeMap[typeof(string)] = NpgsqlDbType.Varchar;
                _typeMap[typeof(String)] = NpgsqlDbType.Varchar;
                _typeMap[typeof(char[])] = NpgsqlDbType.Varchar;
                _typeMap[typeof(byte)] = NpgsqlDbType.Smallint;
                _typeMap[typeof(short)] = NpgsqlDbType.Smallint;
                _typeMap[typeof(int)] = NpgsqlDbType.Integer;
                _typeMap[typeof(Int16)] = NpgsqlDbType.Integer;
                _typeMap[typeof(Int32)] = NpgsqlDbType.Integer;
                _typeMap[typeof(Int64)] = NpgsqlDbType.Integer;
                _typeMap[typeof(long)] = NpgsqlDbType.Bigint;
                _typeMap[typeof(byte[])] = NpgsqlDbType.Bytea;
                _typeMap[typeof(bool)] = NpgsqlDbType.Bit;
                _typeMap[typeof(DateTime)] = NpgsqlDbType.Timestamp;
                _typeMap[typeof(DateTimeOffset)] = NpgsqlDbType.TimestampTz;
                _typeMap[typeof(decimal)] = NpgsqlDbType.Money;
                _typeMap[typeof(Decimal)] = NpgsqlDbType.Money;
                _typeMap[typeof(float)] = NpgsqlDbType.Real;
                _typeMap[typeof(double)] = NpgsqlDbType.Double;
                _typeMap[typeof(TimeSpan)] = NpgsqlDbType.Time;
            }
        }
        public static NpgsqlDbType GetDbType(Type giveType)
        {
            SetTypeMap();
            giveType = Nullable.GetUnderlyingType(giveType) ?? giveType;

            if (_typeMap.ContainsKey(giveType))
            {
                return _typeMap[giveType];
            }
            throw new ArgumentException("{giveType.FullName} is not a supported .NET class");
        }
    }
}
