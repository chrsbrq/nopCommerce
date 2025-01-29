using System.Data;
using LinqToDB;
using LinqToDB.Data;

namespace Nop.Services.Catalog;

public enum FulltextSearchMode
{
    /// <summary>
    /// Exact match (using CONTAINS with prefix_term)
    /// </summary>
    ExactMatch = 0,
    /// <summary>
    /// Using CONTAINS and OR with prefix_term
    /// </summary>
    Or = 5,
    /// <summary>
    /// Using CONTAINS and AND with prefix_term
    /// </summary>
    And = 10
}

internal class SqlParameterHelper
{

    private static DataParameter a(DataType dataType, string name, object value)
    {
        return new DataParameter()
        {
            Name = name,
            Value = value ?? (object)DBNull.Value,
            DataType = dataType
        };
    }

    private static DataParameter b(DataType dataType, string name)
    {
        return new DataParameter()
        {
            Name = name,
            DataType = dataType,
            Direction = new ParameterDirection?(ParameterDirection.Output)
        };
    }

    public static DataParameter GetStringParameter(string parameterName, string parameterValue)
    {
        return SqlParameterHelper.a(DataType.NVarChar, parameterName, (object)parameterValue);
    }

    public static DataParameter GetOutputStringParameter(string parameterName)
    {
        return SqlParameterHelper.b(DataType.NVarChar, parameterName);
    }

    public static DataParameter GetInt32Parameter(string parameterName, int? parameterValue)
    {
        return SqlParameterHelper.a(DataType.Int32, parameterName, (object)parameterValue);
    }

    public static DataParameter GetOutputInt32Parameter(string parameterName)
    {
        return SqlParameterHelper.b(DataType.Int32, parameterName);
    }

    public static DataParameter GetBooleanParameter(string parameterName, bool? parameterValue)
    {
        return SqlParameterHelper.a(DataType.Boolean, parameterName, (object)parameterValue);
    }

    public static DataParameter GetDecimalParameter(string parameterName, Decimal? parameterValue)
    {
        return SqlParameterHelper.a(DataType.Decimal, parameterName, (object)parameterValue);
    }

    public static DataParameter GetDateTimeParameter(string parameterName, DateTime? parameterValue)
    {
        return SqlParameterHelper.a(DataType.DateTime, parameterName, (object)parameterValue);
    }


}
